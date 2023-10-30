using DataAccess;
using BusinessObject;
using System.Runtime.CompilerServices;

namespace MyStoreWinApp.Forms
{
    public partial class frmAdd : Form
    {
        private Member? _member = null;
        public frmAdd(Member? mem = null)
        {
            InitializeComponent();
            _member = mem;
            if(_member != null )
            {
                head_msg.Text = $"Member #{_member.ID}";
                name_txt.Text = _member.Name;
                email_txt.Text = _member.Email;
                password_txt.Text = _member.Password;
                city_txt.Text = _member.City;
                country_txt.Text = _member.Country;
            }
        }

        public Member? GetMember()
        {                     
            return _member;
        }

        public void ViewMode()
        {
            name_txt.ReadOnly = true;
            email_txt.ReadOnly = true;
            password_txt.ReadOnly = true;
            city_txt.ReadOnly = true;
            country_txt.ReadOnly = true;
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure these infomation is correct ??",
                                     "Confirm Information!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.No)
                return;
            var newMem = new Member();
            newMem.Name = name_txt.Text.Trim();
            newMem.Email = email_txt.Text.Trim();
            newMem.Password = password_txt.Text.Trim();
            newMem.City = city_txt.Text.Trim();
            newMem.Country = country_txt.Text.Trim();            
            _member = newMem;
            this.Close();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to cancel ??",
                                     "Confirm Cancel!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                _member = null;
                this.Close();
            }
        }
    }
}
