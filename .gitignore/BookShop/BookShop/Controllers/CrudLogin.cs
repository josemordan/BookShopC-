using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using BookShop.Models;
using BookShop.Views;

namespace BookShop.Controllers
{
    class CrudLogin :Connexion
    {
        SqlCommand cmd;
        string  iduser;


        public Boolean validingLogin(ModelLogin ml)
        {
            try
            {
                if (validingUser(ml.userName))
                {
                    if (validingPass(ml.passWord))
                    { 
                        Register r = new Register();
                        r.Visible = true;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("User or Pass Incorrect");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("User or Pass Incorrect");
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(" " + e);
            }
            return false;
        }

        public Boolean validingUser(string user)
        {
            try
            {
                SqlDataReader dreader;
                cmd = new SqlCommand("select * from userBook where username ='" + user + "'", this.retornarConn());
                dreader= cmd.ExecuteReader();

                if (dreader.Read())
                {
                    iduser = dreader["id"].ToString();
                    dreader.Close();
                    return true;
                }
                else
                {
                    return false;
                }

                
            }
            catch (Exception e)
            {
                MessageBox.Show(" " + e);
            }
            return false;
        }

        public Boolean validingPass(string pass)
        {
            try
            {
                SqlDataReader dreader;
                cmd = new SqlCommand("select * from userBook where passUser ='" + pass + "' and id ='" + iduser + "'", this.retornarConn());
                dreader = cmd.ExecuteReader();
                if (dreader.Read())
                {
                    dreader.Close();
                    return true;
                }
                else return false;
              
            }
            catch (Exception e)
            {
                MessageBox.Show( " " + e);
            }
            return false;
        }

    }
}
