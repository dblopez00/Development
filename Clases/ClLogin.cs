using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Development.Clases
{
    public class ClLogin 
    {
        public  ClLogin ()
        {
            username = string.Empty;
            password = string.Empty;
            try
            {
                SqlConnection cn = new SqlConnection(
                   ConfigurationManager.ConnectionStrings["cs_proyecto"].ConnectionString
               );

                Login lg = new Login();
                cn.Open();

                //string tablas = "SELECT * FROM Admin WHERE Username='" + txusername.Text + "' AND Password='" + txpass.Text + "'";
                SqlCommand comando = new SqlCommand();
                SqlParameter param = new SqlParameter();

                comando.Connection = cn;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "sp_admin";

                param = new SqlParameter();
                comando.Parameters.Add("@Username", SqlDbType.VarChar).Value = username;
                comando.Parameters.Add("@Password", SqlDbType.VarChar).Value = password;
                SqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    MessageBox.Show("Bienvenido a Development SQl", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    People pop = new People();
                    pop.Show();
                    this.Hide();
                }
                else if (username == "" && password == "")
                {
                    MessageBox.Show("Hay casillas vacias", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lo sentimos, el Username o la Password no aparece en la Base de Datos", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error en el programa" + ex);
            }
        }

        public ClLogin(string Pusername, string Ppassword)
        {
            username = Pusername;
            password = Ppassword;
        }

        public string username { get;  set; }
        public string password { get;  set; }

        private void Hide()
        {
            throw new NotImplementedException();
        }

    }

}
