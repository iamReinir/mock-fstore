using BusinessObject;

namespace MyStoreWinApp
{
    public partial class frmLogin : Form
    {

        public bool IsAdmin { get; set; } = false;

        public Member Member { get; set; }
        public bool LoginSuccess { get; set; } = false;

        private List<Member> normal_users;
        private List<(string, string)> admin_users;
        public frmLogin(
                    List<Member> normal_users,
                    List<(string,string)> admin_users)
        {
            InitializeComponent();            
            this.normal_users = normal_users;
            this.admin_users = admin_users;
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {            
            
            foreach(var (email,password) in admin_users)
            {
                if(email == email_txt.Text && password == password_txt.Text)
                {
                    IsAdmin = true;
                    LoginSuccess = true;
                    MessageBox.Show("Login sucess!");
                    this.Close();
                    return;
                }
            }

            foreach(var mem in normal_users) {
                var email = mem.Email;
                var password = mem.Password;
                if (email == email_txt.Text && password == password_txt.Text)
                {
                    IsAdmin = false;
                    Member = mem;
                    LoginSuccess = true;
                    MessageBox.Show("Login sucess!");
                    this.Close();
                    return;
                }
            }            
            MessageBox.Show("Wrong email or password!");
        }
    }
}
