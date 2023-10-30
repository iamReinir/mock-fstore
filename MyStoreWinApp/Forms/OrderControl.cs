using BusinessObject;
using DataAccess;

namespace MyStoreWinApp.Forms
{
    public partial class OrderControl : UserControl
    {
        IRepository<Order> _repos;
        IRepository<Member> _members;
        IRepository<Product> _products;
        IRepository<OrderDetail> _orders;

        Member? target = null;

        public OrderControl(
            IRepository<Order> repos, 
            IRepository<Member> members, 
            IRepository<Product> products, 
            IRepository<OrderDetail> orders,
            Member member_to_show_order = null)

        {
            InitializeComponent();
            _repos = repos;
            _members = members;
            _products = products;
            _orders = orders;
            target = member_to_show_order;
            if (target != null)
            {
                button_delete.Enabled = false;
                button_update.Text = "Detail";
            }
            updateTable();
        }

        private void updateTable()
        {
            ICollection<Order> dataToFill;
            if(target == null)
                dataToFill = _repos.Read();
            else
            {
                dataToFill = _repos.Foldl<ICollection<Order>>((order,acc) =>
                {
                    if (order.Member_id == target.ID) acc.Add(order);
                        return acc;
                }, new List<Order>());
            }

            orderBindingSource.DataSource = null;
            orderBindingSource.DataSource = dataToFill;

        }
        private void button_update_Click(object sender, EventArgs e)
        {            
            var updateForm = new OrderDetailsForm(_orders, _members, _products, orderBindingSource[orderTable.CurrentRow.Index] as Order);
            if (target != null)
                updateForm.ViewMode = true;
            updateForm.Show();
            updateForm.FormClosing += (e, x) =>
            {
                if (updateForm.Core == null) return;
                _repos.Save(updateForm.Core);
                var allDetails = Functional.Ultility.Map<OrderDetail, OrderDetail>(
                updateForm.Details.ToArray(),
                (old) => { old.Order_id = updateForm.Core.Id; return old; });
                var existingDetails = _orders.Foldl<IEnumerable<OrderDetail>>(
                   (or_detail, acc) => {
                       foreach (var detail in updateForm.Details)
                       {

                           if (detail.Order_id == or_detail.Order_id && detail.Product_id == or_detail.Product_id)
                           {
                               acc = acc.Append(detail);
                           }
                       }
                       return acc;
                   }, new List<OrderDetail>());

                foreach (var detail in existingDetails) _orders.Delete(detail);
                foreach (var detail in allDetails) _orders.Create(detail);
                updateTable();
            };
        }
        private void button_delete_Click(object sender, EventArgs e)
        {
            int id = (int)orderTable.CurrentRow.Cells[0].Value;
            var tableData = (orderTable.DataSource as ICollection<Order>);
            _repos.Delete(new Order() { Id = id });
            updateTable();
        }
    }
}
