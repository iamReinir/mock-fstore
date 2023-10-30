using BusinessObject;

namespace MyStoreWinApp.Forms
{
    public partial class ProductDetailForm : Form
    {
        public Product? Core { get; set; }
        public ProductDetailForm(Product? core = null)
        {
            InitializeComponent();
            Core = core;
            InfoFill();
        }

        private void InfoFill()
        {
            if (Core == null) return;
            txtBox_name.Text = Core.Name;
            txtBox_category.Text = Core.Category;
            txtBox_weight.Text = Core.Weight;
            txtBox_unitPrice.Value = (decimal)Core.Unit_price;
            txtBox_inStock.Value = (decimal)Core.Unit_instock;
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Save Product?", "Confirmation", MessageBoxButtons.OKCancel)
                == DialogResult.Cancel)
                return;
            Core ??= new Product();
            Core.Name = txtBox_name.Text.Trim();
            Core.Category = txtBox_category.Text.Trim();
            Core.Unit_price = txtBox_unitPrice.Value;
            Core.Weight = txtBox_weight.Text.Trim();
            Core.Unit_instock = int.Parse(txtBox_inStock.Text.Trim());
            this.Close();
        }

        private void ProductDetailForm_Load(object sender, EventArgs e)
        {

        }

        private void button_Cancel_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to cancel?", "Confirm cancel"
                , MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            Core = null;
            this.Close();
        }
    }
}
