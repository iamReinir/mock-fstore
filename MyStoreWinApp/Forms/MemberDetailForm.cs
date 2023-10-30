using BusinessObject;
using System.CodeDom;

namespace MyStoreWinApp.Forms
{
    public partial class MemberDetailForm : Form
    {
        public Member? core;
        public MemberDetailForm(Member? core = null)
        {
            InitializeComponent();
            this.core = core;
            InfoFill();
        }

        private void InfoFill()
        {
            if (core == null) return;
            txtBox_name.Text = core.Name;
            txtBox_email.Text = core.Email;
            txtBox_password.Text = core.Password;
            txtBox_country.Text = core.Country;
            txtBox_companyName.Text = core.CompanyName;
            txtBox_City.Text = core.City;
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Save Member?", "Confirmation", MessageBoxButtons.OKCancel)
                == DialogResult.Cancel)
                return;
            core ??= new Member();
            core.Name = txtBox_name.Text.Trim();
            core.Email = txtBox_email.Text.Trim();
            core.Password = txtBox_password.Text.Trim();
            core.Country = txtBox_country.Text.Trim();
            core.CompanyName = txtBox_companyName.Text.Trim();
            core.City = txtBox_City.Text.Trim();
            this.Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to cancel?", "Confirm cancel"
                , MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            core = null;
            this.Close();
        }
    }
}
