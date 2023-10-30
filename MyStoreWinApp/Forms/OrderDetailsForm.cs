using BusinessObject;
using DataAccess;

namespace MyStoreWinApp.Forms
{
    public partial class OrderDetailsForm : Form
    {
        IRepository<OrderDetail> OrderDetailRepo { get; set; }
        IRepository<Member> MemberRepo { get; set; }
        IRepository<Product> ProductRepo { get; set; }
        public Order? Core { get; set; }

        private bool _view = false;
        public bool ViewMode
        {
            get => _view;
            set
            {
                _view = value;
                if (_view)
                {
                    button_addProduct.Enabled = false;
                    button_save.Enabled = false;
                    button_productRemove.Enabled = false;
                    detailTable.AllowUserToDeleteRows = false;
                    detailTable.ReadOnly = true;
                    txt_memID.Enabled = false;
                    date_order.Enabled = false;
                    date_required.Enabled = false;
                    date_shipped.Enabled = false;
                    num_freight.Enabled = false;
                }
            }
        }
        public List<OrderDetail> Details { get; set; } = new List<OrderDetail>();
        List<FullOrderDetail> FullOrders { get; set; } = new List<FullOrderDetail>();
        public OrderDetailsForm(
                IRepository<OrderDetail> detail_repos,
                IRepository<Member> mem_repos,
                IRepository<Product> prod_repos, Order? core = null)
        {
            InitializeComponent();
            this.Core = core;
            OrderDetailRepo = detail_repos;
            MemberRepo = mem_repos;
            ProductRepo = prod_repos;
            if (core != null) InfoFill();
            productIdDataGridViewTextBoxColumn.ReadOnly = true;
            productNameDataGridViewTextBoxColumn.ReadOnly = true;
            unitPriceDataGridViewTextBoxColumn.ReadOnly = true;

        }

        private void InfoFill()
        {
            if (Core == null) return;
            txt_memID.Text = Core.Member_id.ToString();
            MemName_findAndFill();
            date_order.Value = Core.Order_date;
            date_required.Value = Core.Require_date ?? DateTime.Now;

            // Simulate null value. There should be an event to change date_shipped back to Short format
            // when user click, and an event to clean date_shipped when user press Del key
            if (Core.Shipped_date == null)
            {
                date_shipped.CustomFormat = " ";
                date_shipped.Format = DateTimePickerFormat.Custom;
            }
            else
                date_shipped.Value = (DateTime)Core.Shipped_date;

            // Find the order details
            var details = OrderDetailRepo.Foldl<IEnumerable<OrderDetail>>(
                (order_detail, acc) =>
                {
                    if (order_detail.Order_id == Core.Id)
                    {
                        return acc.Append(order_detail);
                    }
                    return acc;
                }, new List<OrderDetail>());

            // Join with the product
            FullOrders = ProductRepo.Foldl<IEnumerable<FullOrderDetail>>(
                (prod, acc) =>
                {
                    foreach (var detail in details)
                    {
                        if (prod.ID == detail.Product_id)
                        {
                            acc = acc.Append(new FullOrderDetail()
                            {
                                ProductId = detail.Product_id,
                                ProductName = prod.Name,
                                Discount = detail.Discount,
                                Quantity = detail.Quantity,
                                UnitPrice = prod.Unit_price ?? 0
                            });
                        }
                    }
                    return acc;
                }, new List<FullOrderDetail>()).ToList();

            detailTable.DataSource = FullOrders;

            // Calculate total
            /*
            var total = ProductRepo.Foldl<decimal>(
                (prod, acc) =>
                {
                    decimal more = 0;
                    foreach (var item in details)
                    {
                        if (item.Product_id == prod.ID)
                        {
                            // basically more += price * (1 - discount) but there are too many casts
                            more += (decimal)(prod.Unit_price ?? 0 * (decimal)(1 - item.Discount));
                        }
                    }
                    return acc + more;
                }, 0); */
            num_freight.Value = Core.Freight ?? 0.0m;
        }

        Member? customer;
        private void MemName_findAndFill()
        {
            Font italic = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            Font normal = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            int memid;
            try
            {
                memid = int.Parse(txt_memID.Text);
                customer = MemberRepo.Foldl<Member?>(
                   (mem, acc) => mem.ID == memid ? mem : acc, null);
            }
            catch (Exception) { customer = null; }

            if (customer == null)
            {
                txt_memName.Text = "MEMBER NOT FOUND";
                txt_memName.Font = italic;
            }
            else
            {
                txt_memName.Text = customer.Name;
                txt_memName.Font = normal;
            }
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_memID_TextChanged(object sender, EventArgs e)
        {
            MemName_findAndFill();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to cancel?", "Confirmation", MessageBoxButtons.YesNo)
                == DialogResult.Yes)
            {
                Core = null;
                this.Close();
            }
        }

        Product? cursored_product;
        private void num_productID_ValueChanged(object sender, EventArgs e)
        {
            int id = (int)num_productID.Value;
            cursored_product = ProductRepo.Foldl<Product>((prod, acc) => prod.ID == id ? prod : acc, null);
            txt_product.Text = cursored_product?.Name ?? "Product ID";
        }

        private void button_addProduct_click(object sender, EventArgs e)
        {
            if (cursored_product == null)
            {
                MessageBox.Show("Cannot find the product with this ID!");
                return;
            }

            if( txt_quantity.Text == "" )
            {
                MessageBox.Show("Please specify a quantity!");
                return;
            }

            var newOrderProd = new FullOrderDetail()
            {
                ProductName = cursored_product.Name,
                Discount = (float)(num_discount.Value / 100.0M),
                ProductId = (int)cursored_product.ID,
                Quantity = int.Parse(txt_quantity.Text),
                UnitPrice = (decimal)cursored_product.Unit_price
            };
            foreach (var item in FullOrders)
            {
                if (item.ProductId == cursored_product.ID)
                {
                    MessageBox.Show("There's already this product in this order. Consider Update that instead.");
                    return;
                }
            }
            FullOrders.Add(newOrderProd);
            detailTable.DataSource = null;
            detailTable.DataSource = FullOrders;
        }

        private void button_RemvoveProduct_Click(object sender, EventArgs e)
        {
            int rowIndex = (detailTable.CurrentCell.RowIndex);
            FullOrders.Remove(FullOrders[rowIndex]);
            detailTable.DataSource = null;
            detailTable.DataSource = FullOrders;
        }

        private void detailTable_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {

            DataGridViewCell? affected_cell = (sender as DataGridView)?.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (detailTable.Columns[e.ColumnIndex].HeaderText == "Discount")
            {
                try
                {
                    affected_cell.ErrorText = "";
                    var val = decimal.Parse(affected_cell.Value.ToString());
                    if ((val < 0.0m) || (val > 1.0m))
                        throw new Exception();
                }
                catch (Exception)
                {
                    affected_cell.ErrorText = "Value need to be a decimal between 0 and 1";
                    e.Cancel = true;
                    affected_cell.Value = 0.0m;
                }
            }
            else if (detailTable.Columns[e.ColumnIndex].HeaderText == "Quantity")
            {
                try
                {
                    affected_cell.ErrorText = "";
                    if (!(int.Parse(affected_cell.Value.ToString()) > 0))
                        throw new Exception();
                }
                catch (Exception)
                {
                    affected_cell.ErrorText = "Value need to be a positive integer";
                    e.Cancel = true;
                    affected_cell.Value = 1;
                }
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (customer == null)
            {
                MessageBox.Show("Cannot find this member");
                return;
            }

            if (MessageBox.Show("You sure to save this order?", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                return;
            Core = new Order()
            {
                Id = Core?.Id ?? -1,
                Member_id = customer.ID,
                Freight = num_freight.Value,
                Order_date = date_order.Value,
                Require_date = date_required.Value,
                Shipped_date = date_shipped.Value
            };

            // FullDetail to a less-info OrderDetail
            Details.AddRange(Functional.Ultility.Map<FullOrderDetail, OrderDetail>(FullOrders.ToArray(),
                (bef) =>
                {
                    return new OrderDetail
                    {
                        Order_id = Core.Id,
                        Discount = bef.Discount,
                        Product_id = bef.ProductId,
                        Quantity = bef.Quantity
                    };
                }));

            this.Close();
        }
    }
    public class FullOrderDetail
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public double Discount { get; set; }

        public static Func<object[], FullOrderDetail> Constructor;
        static FullOrderDetail()
        {
            Constructor = (attr) =>
            {
                return new FullOrderDetail()
                {
                };
            };
        }
    }
}
