using BusinessObject;
using DataAccess;
using MyStoreWinApp.Forms;
using System.Data;
using System.Diagnostics;
using static Functional.Ultility;

namespace MyStoreWinApp
{
    public partial class MainForm : Form
    {
        Member? member = null;
        List<(string, string)> admins;
        IRepository<Member> memberRepos;
        IRepository<Product> productRepos;
        IRepository<Order> orderRepos;
        IRepository<OrderDetail> detailRepos;
        Control lowerPanel;

        public MainForm(IDbConnection db, List<(string, string)> admins)
        {
            InitializeComponent();
            this.admins = admins;
            memberRepos = RepositoryObjects.GetRepository<Member>(db);
            productRepos = RepositoryObjects.GetRepository<Product>(db);
            orderRepos = RepositoryObjects.GetRepository<Order>(db);
            detailRepos = RepositoryObjects.GetRepository<OrderDetail>(db);

            var img = new Forms.BannerImage();
            img.Dock = DockStyle.Fill;
            splitContainer1.Panel1.Controls.Add(img);

            var members = memberRepos.Read().ToList();
            var loginForm = new frmLogin(members, admins);
            loginForm.ShowDialog();
            if (loginForm.LoginSuccess == false)
            {
                this.Close();
                return;
            }

            if (loginForm.IsAdmin == false)
            {
                member = loginForm.Member;
            }

            if (member != null)
            {
                menu_addMember.Text = "View profile";
                menu_addMember.Click -= menu_addMember_Click;
                menu_addMember.Click += menu_profile_click;
                menu_Product.Enabled = false;
                menu_allMembers.Enabled = false;
                menu_newOrder.Enabled = false;
                menu_createReport.Enabled = false;
                exportMembersToolStripMenuItem.Enabled = false;
            }

            menu_allOrders_Click(this, new EventArgs());
        }

        public void SwitchForm(Control lower)
        {
            if (lower.IsDisposed) return;
            this.splitContainer1.Panel2.Controls.Clear();
            lowerPanel = lower;
            this.splitContainer1.Panel2.Controls.Add(lower);
            //var size = inner.ClientRectangle.Size;
            //inner.Width += 50;
            //inner.Height += 100;
            //this.Size = size;
            lower.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menu_quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menu_allMembers_Click(object sender, EventArgs e)
        {
            var res = new Forms.MemberControl(memberRepos);
            res.Dock = DockStyle.Fill;
            SwitchForm(res);
            this.Text = "Fstore - Member List";
        }

        private void menu_profile_click(object sender, EventArgs e)
        {
            var addDialog = new Forms.MemberDetailForm(member);
            addDialog.Text = "User profile";
            addDialog.ShowDialog();
            if (addDialog.core == null)
                return;
            memberRepos.Save(addDialog.core);
        }
        private void menu_addMember_Click(object sender, EventArgs e)
        {
            var addDialog = new Forms.MemberDetailForm();
            addDialog.ShowDialog();
            if (addDialog.core == null)
                return;
            memberRepos.Create(addDialog.core);
        }

        private void menu_allProduct_Click(object sender, EventArgs e)
        {
            var form = new Forms.ProductControl(productRepos);
            form.Dock = DockStyle.Fill;
            SwitchForm(form);
            this.Text = "Fstore - Product List";
        }

        private void menu_addProduct_Click(object sender, EventArgs e)
        {
            var addDialog = new Forms.ProductDetailForm();
            addDialog.ShowDialog();
            if (addDialog.Core == null)
                return;
            productRepos.Create(addDialog.Core);
        }

        private void menu_newOrder_Click(object sender, EventArgs e)
        {
            var order = new OrderDetailsForm(detailRepos, memberRepos, productRepos);
            order.FormClosing += Order_FormClosing;
            order.Show();

        }

        private void Order_FormClosing(object? sender, FormClosingEventArgs e)
        {
            var order = sender as OrderDetailsForm;
            if (order.Core == null)
                return;
            order.Core = orderRepos.Create(order.Core);
            var allDetails = Functional.Ultility.Map<OrderDetail, OrderDetail>(
                order.Details.ToArray(),
                (old) => { old.Order_id = order.Core.Id; return old; });
            var existingDetails = detailRepos.Foldl<IEnumerable<OrderDetail>>(
               (or_detail, acc) =>
               {
                   foreach (var detail in order.Details)
                   {

                       if (detail.Order_id == or_detail.Order_id && detail.Product_id == or_detail.Product_id)
                       {
                           acc = acc.Append(detail);
                       }
                   }
                   return acc;
               }, new List<OrderDetail>());

            foreach (var detail in existingDetails) detailRepos.Delete(detail);
            foreach (var detail in allDetails) detailRepos.Create(detail);
        }

        private void menu_allOrders_Click(object sender, EventArgs e)
        {
            var form = new Forms.OrderControl(
                    orderRepos, 
                    memberRepos, 
                    productRepos, 
                    detailRepos, 
                    member);
            form.Dock = DockStyle.Fill;                                                    
            SwitchForm(form);
            this.Text = "Fstore - Order List";
        }

        private void menu_createReport_Click(object sender, EventArgs e)
        {
            var report = new SaleReport(detailRepos, orderRepos, productRepos);
            report.ShowDialog();
        }

        private void exportMembersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (StreamWriter outfile = new StreamWriter("members.csv"))
            {
                outfile.Write(Functional.Ultility.ToSCV(memberRepos.Read()));
                MessageBox.Show("Data exported to file members.csv");
            }

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
