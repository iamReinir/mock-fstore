using BusinessObject;
using DataAccess;
using MyStoreWinApp.ViewModels;
using System.Windows.Forms;

namespace MyStoreWinApp.Forms
{
    public partial class SaleReport : Form
    {

        IRepository<OrderDetail> _orderDetails;
        IRepository<Order> _orders;
        IRepository<Product> _products;

        public SaleReport(
                IRepository<OrderDetail> orderDetails,
                IRepository<Order> orders,
                IRepository<Product> products)
        : this()
        {
            _orderDetails = orderDetails;
            _orders = orders;
            _products = products;
        }

        public SaleReport()
        {
            InitializeComponent();
        }

        private void UpdateTable()
        {
            reportTable.DataSource = null;
            if (date_from.Value.CompareTo(date_to.Value) > 0)
                return;
            reportTable.DataSource = CreateRows(date_from.Value, date_to.Value);
        }

        private ICollection<SaleReportRow> CreateRows(DateTime from, DateTime to)
        {
            // Foldl uses disconnected data architecture.
            // Cannot nest a Foldl inside a Foldl
            Func<OrderDetail, bool> relevant = (orderDetail) =>
            {
                return
                    _orders.Foldl<bool>((order, acc) =>
                    {
                        if (order.Id == orderDetail.Order_id
                            && order.Order_date.CompareTo(from) > 0
                            && order.Order_date.CompareTo(to) < 0)
                            return true;
                        return acc;
                    }, false);
            };


            var res = new List<SaleReportRow>();
            foreach (var product in _products.Read())
            {
                var relevantDetails = new List<OrderDetail>();
                foreach (var detail in _orderDetails.Read())
                {
                    if (!relevant(detail)) continue;
                    if (detail.Product_id == product.ID)
                    {
                        relevantDetails.Add(detail);
                    }
                }
                var newrow = new SaleReportRow(product, relevantDetails);
                res.Add(newrow);
            }
            return res;
        }

        private void date_from_ValueChanged(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void date_to_ValueChanged(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void button_toExcel_Click(object sender, EventArgs e)
        {
            using (StreamWriter file = new("sale_report.csv"))
            {
                var tableData = reportTable.DataSource as ICollection<SaleReportRow>;
                string output = "Sale Report\n";
                output += $"from,{date_from.Value},to,{date_to.Value}\n";
                output += Functional.Ultility.ToSCV(tableData);
                file.Write(output);
                MessageBox.Show("Data exported to sale_report.csv");
            }
        }
        // space is used as delimiter
        const string asc = "\u02C4"; // ^, ascending sort, TRUE
        const string desc = "\u02C5"; //v, descending sort, FALSE      

        private void TableDataChangeTo(ICollection<Product>? products = null)
        {
            // Repopulate the table with data
            if (products != null)
                reportTable.DataSource = products;

            Func<string, (string, string)> flag_checker = col_name =>
            {
                var toks = col_name.Split(' ');
                if (toks.Length == 1)
                {
                    return (col_name, "");
                }
                return (toks[1], toks[0]);
            };

            // Get list to work on            
            var init_data = (IEnumerable<SaleReportRow>)(reportTable.DataSource);
            // Sort by the column that have the "mark"
            foreach (DataGridViewColumn col in reportTable.Columns)
            {
                var (attr, sort_direction) = flag_checker(col.HeaderText);
                if (sort_direction == asc) init_data = init_data
                        .OrderBy(prod
                            => typeof(SaleReportRow).GetProperty(attr).GetValue(prod));
                else if (sort_direction == desc)
                    init_data = init_data
                        .OrderByDescending(prod
                            => typeof(SaleReportRow).GetProperty(attr).GetValue(prod));
            }
            reportTable.DataSource = init_data.ToList();
        }

        private void reportTable_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Func<string, string> toggle_header_text = (headerName) =>
            {
                var toks = headerName.Split(' ');
                if (toks.Length == 1)
                {
                    return asc + " " + headerName;
                }
                return (toks[0] == asc ? desc : asc) + " " + toks[1];
            };
            Func<string, string> flag_clear = col_name =>
            {
                var toks = col_name.Split(' ');
                if (toks.Length == 1)
                    return col_name;
                return toks[1];
            };

            // Get the field name and sort "mark"
            var column = (sender as DataGridView).Columns[e.ColumnIndex];
            var old_header = column.HeaderText;

            // Clear the arrows on all field
            foreach (DataGridViewColumn col in (sender as DataGridView).Columns)
                col.HeaderText = flag_clear(col.HeaderText);

            // Update the column which the opposite type of sort "mark"
            column.HeaderText = toggle_header_text(old_header);

            // Update the table
            TableDataChangeTo();
        }
    }
}
