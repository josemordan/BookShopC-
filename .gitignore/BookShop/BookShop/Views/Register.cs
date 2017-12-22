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


namespace BookShop
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            loadCmbBox();
       
        }
        public void loadCmbBox()
        {
            cmbGeneroBook.Items.Add("Epic");
            cmbGeneroBook.Items.Add("Lyrical");
            cmbGeneroBook.Items.Add("Dramatric");
            cmbStateBook.Items.Add("New");
            cmbStateBook.Items.Add("Used");
            cmbStateBook.Items.Add("Bad");

        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtNameBook.Text == "") MessageBox.Show("Please, to can't be  null");
            else if (txtPageBook.Text == "") MessageBox.Show("Please, to can't be null");
            else if (txtYearBook.Text == "") MessageBox.Show("Please, to can't be null");
            else if (txtnameAuthor.Text == "") MessageBox.Show("Please, to can't be null");
            else if (txtNationalityAuthor.Text == "") MessageBox.Show("Please, to can't be null");
            else if (txtAgeAuthor.Text == "") MessageBox.Show("Please, to can't be null");
            else if (cmbGeneroBook.Text == "") MessageBox.Show("Please, to can't be null");
            else if (cmbStateBook.Text == "") MessageBox.Show("Please, to can't be null");
            else
            {
                ModelRegister mr = new ModelRegister();
                mr.titleBook = txtNameBook.Text;
                mr.pageBook = Convert.ToInt32(txtPageBook.Text);
                mr.yearBook = Convert.ToInt32(txtYearBook.Text);
                mr.nameAuthor = txtnameAuthor.Text;
                mr.nationalityAuthor = txtNationalityAuthor.Text;
                mr.ageAuthor = Convert.ToInt32(txtAgeAuthor.Text);
                mr.generoBook = cmbGeneroBook.Text;
                mr.stateBook = cmbStateBook.Text;
                CrudRegister cr = new CrudRegister();
                cr.insertBook(mr);
                MessageBox.Show("The Book was insert successful");
                cleanTxt();

            }
        }
        private void btnClean_Click(object sender, EventArgs e)
        {
            cleanTxt();
        }

        private void txtAgeAuthor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void txtPageBook_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtYearBook_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        public void cleanTxt()
        {
            txtNameBook.Text = "";
            txtPageBook.Text = "";
            txtYearBook.Text = "";
            txtnameAuthor.Text = "";
            txtAgeAuthor.Text = "";
            txtNationalityAuthor.Text = "";
            cmbGeneroBook.Text = "";
            cmbStateBook.Text = "";
        }

        private void cmbGeneroBook_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void cmbStateBook_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }

    }
}
