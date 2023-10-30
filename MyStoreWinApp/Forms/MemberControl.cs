using BusinessObject;
using DataAccess;

namespace MyStoreWinApp.Forms
{
    public partial class MemberControl : UserControl
    {
        public IRepository<Member> MemberRepos { get; set; }
        public MemberControl(IRepository<Member> repos)
        {
            InitializeComponent();
            MemberRepos = repos;
            MemberRepos.OnRepositoryChanged += MemberRepos_OnRepositoryChanged;
            foreach (var mem in MemberRepos.Read())
                memberBindingSource.Add(mem);
        }

        public void MemberRepos_OnRepositoryChanged(object? sender, Member e)
        {
            memberBindingSource.Clear();
            foreach (var mem in MemberRepos.Read())
                memberBindingSource.Add(mem);
        }

        private int Current_id()
        {
            int row = dataGridView1.CurrentCell.RowIndex;
            return
                int.Parse(dataGridView1.Rows[row].Cells[0].Value.ToString());
        }
        private void button_update_Click(object sender, EventArgs e)
        {
            var id_to_update = Current_id();
            var toDisplay = MemberRepos.Foldl<Member>(
                 (cur, acc) =>
                 {
                     if (acc != null) return acc;
                     if (cur.ID == id_to_update) return cur;
                     return null;
                 }, null);
            var updateForm = new MemberDetailForm(toDisplay);
            updateForm.ShowDialog();
            if (updateForm.core == null) return;
            MemberRepos.Save(updateForm.core);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            var id = Current_id();
            if (MessageBox.Show(
                $"Do you really want to delete member #{id} ?",
                "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            MemberRepos.Delete(new Member() { ID = id });
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Space is used as delimiter, so please dont add space to column text
            const string asc = "\u02C4"; // ^, ascending sort, TRUE
            const string desc = "\u02C5"; //v, descending sort, FALSE
            Func<string, (string, bool)> flag_checker = col_name =>
            {
                var toks = col_name.Split(' ');
                if (toks.Length == 1)
                {
                    return (col_name, true);
                }
                return (toks[1], toks[0] != asc);
            };

            var col_name = (sender as DataGridView).Columns[e.ColumnIndex].HeaderText;
            var (name, dir) = flag_checker(col_name);

            // Clear the arrows
            foreach (DataGridViewColumn col in (sender as DataGridView).Columns)
            {
                (col.HeaderText, _) = flag_checker(col.HeaderText);
            }

            // Sort the column and Add arrow to clicked column
            string indicator = dir ? asc : desc;
            IOrderedEnumerable<Member> data;
            if (dir) // asc
            {
                data = MemberRepos.Read().OrderBy(prod => typeof(Member).GetProperty(name).GetValue(prod));
                (sender as DataGridView).Columns[e.ColumnIndex].HeaderText = indicator + " " + name;
            }
            else // desc
            {
                data = MemberRepos.Read().OrderByDescending(prod => typeof(Member).GetProperty(name).GetValue(prod));
                (sender as DataGridView).Columns[e.ColumnIndex].HeaderText = indicator + " " + name;
            }

            TableDataChangeTo(data.ToList());
        }

        private void TableDataChangeTo(ICollection<Member> products)
        {
            memberBindingSource.Clear();
            foreach (var mem in products)
                memberBindingSource.Add(mem);
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            string searchString = textBox_search.Text;
            var data = MemberRepos.Foldl<IEnumerable<Member>>((mem, acc)=>{
                if (mem.ID.ToString() == searchString
                || mem.Name.IndexOf(searchString, StringComparison.OrdinalIgnoreCase) >= 0)
                    return acc.Append(mem);
                return acc;
            },new List<Member>());
            TableDataChangeTo(data.ToList());
        }
    }
}
