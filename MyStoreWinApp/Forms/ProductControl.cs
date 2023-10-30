using BusinessObject;
using DataAccess;
using System.Linq;

namespace MyStoreWinApp.Forms
{
    public partial class ProductControl : UserControl
    {
        public IRepository<Product> ProductRepos { get; set; }

        // space is used as delimiter
        const string asc = "\u02C4"; // ^, ascending sort, TRUE
        const string desc = "\u02C5"; //v, descending sort, FALSE
        public ProductControl(IRepository<Product> repos)
        {
            InitializeComponent();
            ProductRepos = repos;
            ProductRepos.OnRepositoryChanged += ProductRepos_OnRepositoryChanged;
            foreach (var mem in ProductRepos.Read())
                productBindingSource.Add(mem);
        }
    
        private void TableDataChangeTo(ICollection<Product>? products = null)
        {
            // Repopulate the table with data
            if (products != null)
                productBindingSource.DataSource = products;

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
            IEnumerable<Product> init_data;
            init_data = productBindingSource.List.OfType<Product>();

            // Sort by the column that have the "mark"
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                var (attr, sort_direction) = flag_checker(col.HeaderText);
                if (sort_direction == asc) init_data = init_data
                        .OrderBy(prod
                            => typeof(Product).GetProperty(attr).GetValue(prod));
                else if (sort_direction == desc)
                    init_data = init_data
                        .OrderByDescending(prod
                            => typeof(Product).GetProperty(attr).GetValue(prod));
            }
            productBindingSource.DataSource = init_data;
        }
        public void ProductRepos_OnRepositoryChanged(object? sender, Product e)
        {
            var list = ProductRepos.Read();

            productBindingSource.Clear();
            foreach (var mem in ProductRepos.Read())
                productBindingSource.Add(mem);
        }

        private int Current_id()
        {
            int row = dataGridView1.CurrentCell.RowIndex;
            return
                int.Parse(dataGridView1.Rows[row].Cells[0].Value.ToString());
        }
        private void button_update_Click(object sender, EventArgs e)
        {
            var id_to_update = dataGridView1.CurrentCell.RowIndex;
            var toDisplay = productBindingSource[id_to_update];
            var updateForm = new ProductDetailForm(toDisplay as Product);
            updateForm.ShowDialog();
            if (updateForm.Core == null) return;
            ProductRepos.Save(updateForm.Core);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            var id = Current_id();
            if (MessageBox.Show(
                $"Do you really want to delete product #{id} ?",
                "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            ProductRepos.Delete(new Product() { ID = id });
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Func<string, string> toggle_header_text = (headerName) =>{
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

        private void txtBox_search_TextChanged(object sender, EventArgs e)
        {
            string query = (sender as TextBox).Text;
            Func<Product, bool> filter = (prod)
                => prod.Name.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0
                || prod.ID.ToString() == query
                || prod.Category == query;

            var data = ProductRepos.Foldl<IEnumerable<Product>>((prod, acc) =>
            {
                if (filter(prod))
                    return acc.Append(prod);
                return acc;
            }, new List<Product>());
            TableDataChangeTo(data.ToList());
        }
    }
}
