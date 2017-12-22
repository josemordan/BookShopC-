using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookShop.Models;
using BookShop.Controllers;

namespace BookShop.Views
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            ModelLogin ml = new ModelLogin();
            ml.userName = txtUserName.Text;
            ml.passWord = txtPassWord.Text;
            CrudLogin cl = new CrudLogin();
            cl.validingLogin(ml);
        }

       
    }
}
