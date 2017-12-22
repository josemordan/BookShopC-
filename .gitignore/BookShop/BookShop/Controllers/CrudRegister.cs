using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using BookShop.Models;

namespace BookShop.Controllers
{
    class CrudRegister : Connexion
    {
        SqlCommand cmd;

        public void insertBook(ModelRegister mr)
        {
            try
            {
                cmd = new SqlCommand("insert into book  values('" + mr.titleBook + "','" + mr.pageBook + "', '" + mr.yearBook + "','" + mr.nameAuthor + "','" + mr.nationalityAuthor + "','" + mr.ageAuthor + "','" + mr.generoBook + "','" + mr.stateBook + "')", this.retornarConn());
                cmd.ExecuteNonQuery();
            }
                //(nameBook, page, year, nameAuthor, nationality, ageAuthor, generoBook, stateBook)
            catch (Exception e)
            {
                MessageBox.Show(" "+e);
            }
        }
    }
}
