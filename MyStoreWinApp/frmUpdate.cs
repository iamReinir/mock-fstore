using BusinessObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStoreWinApp
{
    public partial class frmUpdate : Form
    {
        public Member _member;
        public frmUpdate(Member toview)
        {
            InitializeComponent();
            name_txt.Text = _member.Name;
            email_txt.Text = _member.Email;
            password_txt.Text = _member.Password;
            city_txt.Text = _member.City;
            country_txt.Text = _member.Country;
        }
    }
}
