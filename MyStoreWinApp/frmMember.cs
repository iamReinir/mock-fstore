using BusinessObject;
using DataAccess;
using MyStoreWinApp.Forms;

namespace MyStoreWinApp
{
    public partial class frmMember : Form
    {
        private IMemberRepository _memberRepository;
        private List<Member> _display;

        const string allCity = "All City";
        const string allCountry = "All Country";
        private string search_str = "";
        private string search_city = allCity;
        private string search_country = allCountry;

        public frmMember(IMemberRepository repo)
        {
            InitializeComponent();
            /*
            var login = new frmLogin(new AppConfig(repo));
            login.ShowDialog();
            if (!login.loginSuccess)
            {
                this.Close();
                return;
            }
            if (login.role == AppConfig.Role.NORMAL)
            {
                MessageBox.Show("Logged in as Normal user!");
                (new frmAdd(login.member)).ShowDialog();
                this.Close();
                return;
            }
            MessageBox.Show("Logged in as Administrator!");
            search_txt.TextChanged += search_txt_change;
            _memberRepository = repo;
            UpdateComboBox();
            UpdateDataGrid();
            */
        }

        private ICollection<String> Allcity(IMemberRepository memRepo)
        {
            var result = new SortedSet<String>();
            foreach (Member x in memRepo.GetAll())
            {
                result.Add(x.City);
            }
            result.Add(allCity);
            return result;
        }
        private ICollection<String> AllCountry(IMemberRepository memRepo)
        {
            var result = new SortedSet<String>();
            foreach (Member x in memRepo.GetAll())
            {
                result.Add(x.Country);
            }
            result.Add(allCountry);
            return result;
        }


        private void UpdateDataGrid()
        {
            Func<Member, bool> thisCity = (member) =>
            {
                return member.City == search_city || search_city == allCity;
            };
            Func<Member, bool> thisCountry = (member)
                => member.Country == search_country || search_country == allCountry;
            Func<Member, bool> has_search_str = (member) =>
            {
                if (search_str == "" || member.Name == null) return true;
                bool result = false;
                bool contains = member.
                    Name.IndexOf(search_str, StringComparison.OrdinalIgnoreCase) >= 0;
                result = result || contains;
                try
                {
                    result = result || member.ID == int.Parse(search_str);
                }
                catch { }
                return result;
            };
            int Name_des(Member x, Member y)
            {
                return string.Compare(x.Name, y.Name);
            }
            List<Member> mlist = _memberRepository.GetAll()
                .ToList()
                .Filter(thisCity)
                .Filter(thisCountry)
                .Filter(has_search_str)
                .SortBy(Name_des);
            UpdateDataGrid(mlist);
        }
        private void UpdateDataGrid(Func<Member, bool> criteria)
        {
            List<Member> mlist = new();
            foreach (var mem in _memberRepository.GetAll())
            {
                if (criteria(mem) == true)
                    mlist.Add(mem);
            }
            UpdateDataGrid(mlist);

        }

        private void UpdateComboBox()
        {
            city_cb.Items.Clear();
            country_cb.Items.Clear();
            foreach (var city in Allcity(_memberRepository))
                city_cb.Items.Add(city);
            foreach (var country in AllCountry(_memberRepository))
                country_cb.Items.Add(country);
        }
        private void UpdateDataGrid(IEnumerable<Member>? members)
        {
            if (members == null)
                members = _memberRepository.GetAll().ToList();
            dataGrid.CellValueChanged -= dataGrid_contentChange;
            dataGrid.DataSource = members.ToList();
            dataGrid.CellValueChanged += dataGrid_contentChange;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            var addForm = new frmAdd();
            addForm.ShowDialog();
            Member? newMem = addForm.GetMember();
            if (newMem == null) return;
            _memberRepository.Create(newMem);
            UpdateComboBox();
            UpdateDataGrid();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int row = dataGrid.CurrentCell.RowIndex;
                int id_to_delete = int.Parse(dataGrid.Rows[row].Cells[0].Value.ToString());
                var confirm = MessageBox
                    .Show($"Do you really want to delete member id {id_to_delete}?",
                            "Confirm Deletion!!", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.No) return;
                _memberRepository.Delete(id_to_delete);
                UpdateComboBox();
                UpdateDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unexpected Error!!");
            }
        }

        private void dataGrid_contentChange(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = dataGrid.CurrentCell.RowIndex;
                int id_to_update = int.Parse(dataGrid.Rows[row].Cells[0].Value.ToString());
                var confirm = MessageBox
                    .Show($"Do you really want to update member id {id_to_update}?",
                            "Confirm Update!!", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.No) return;
                Member mem = new Member(id_to_update);
                var currow = dataGrid.Rows[row].Cells;
                mem.Name = currow[1].Value.ToString();
                mem.Email = currow[2].Value.ToString();
                mem.Password = currow[3].Value.ToString();
                mem.City = currow[4].Value.ToString();
                mem.Country = currow[5].Value.ToString();
                _memberRepository.Update(mem);
                UpdateComboBox();
                UpdateDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unexpected Error!!");
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            int row = dataGrid.CurrentCell.RowIndex;
            int id_to_update = int.Parse(dataGrid.Rows[row].Cells[0].Value.ToString());
            var updateBox = new frmAdd(_memberRepository.Read(id_to_update));
            updateBox.ShowDialog();
            var mem = updateBox?.GetMember();
            // The form does not get member's id, so we have to provide it with the id
            mem.ID = id_to_update;
            _memberRepository.Update(mem);
            UpdateComboBox();
            UpdateDataGrid();
        }

        private void city_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            search_city = city_cb.Text;
            UpdateDataGrid();
        }

        private void country_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            search_country = country_cb.Text;
            UpdateDataGrid();
        }
        private void search_txt_change(object sender, EventArgs e)
        {
            search_str = search_txt.Text;
            UpdateDataGrid();
        }
    }

    public static class ListExtension
    {
        public static List<Member> Filter(this List<Member> list, Func<Member, bool> func)
        {
            var res = new List<Member>();
            foreach (var item in list)
            {
                if (func(item)) res.Add(item);
            }
            return res;
        }
        public static List<Member> SortBy(this List<Member> list, Comparison<Member> func)
        {
            var res = new List<Member>(list);
            res.Sort(func);
            return res;
        }
    }
}

