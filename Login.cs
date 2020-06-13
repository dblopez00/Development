using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Development.Clases;

namespace Development
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                ClLogin cllog = new ClLogin();
                cllog.username = txusername.Text;
                cllog.password = txpass.Text;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error." + ex.Source);
                throw;
            }
            

            //try
            //{
            //    SqlConnection cn = new SqlConnection(
            //       ConfigurationManager.ConnectionStrings["cs_proyecto"].ConnectionString
            //   );

            //    cn.Open();

            //    //string tablas = "SELECT * FROM Admin WHERE Username='" + txusername.Text + "' AND Password='" + txpass.Text + "'";
            //    SqlCommand comando = new SqlCommand();
            //    SqlParameter param = new SqlParameter();

            //    comando.Connection = cn;
            //    comando.CommandType = CommandType.StoredProcedure;
            //    comando.CommandText = "sp_admin";

            //    param = new SqlParameter();
            //    comando.Parameters.Add("@Username", SqlDbType.VarChar).Value = txusername.Text;
            //    comando.Parameters.Add("@Password", SqlDbType.VarChar).Value = txpass.Text;
            //    SqlDataReader reader = comando.ExecuteReader();

            //    if (reader.Read())
            //    {
            //        MessageBox.Show("Bienvenido a Development SQl", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        People pop = new People();
            //        pop.Show();
            //        this.Hide();
            //    }
            //    else if (txusername.Text == "" && txpass.Text == "")
            //    {
            //        MessageBox.Show("Hay casillas vacias", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    else
            //    {
            //        MessageBox.Show("Lo sentimos, el Username o la Password no aparece en la Base de Datos", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    cn.Close();
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show("Hubo un error en el programa" + ex);
            //}
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void UpPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txusername_Enter(object sender, EventArgs e)
        {
            if (txusername.Text == "USERNAME")
            {
                txusername.Text = "";
            }
        }

        private void txusername_Leave(object sender, EventArgs e)
        {
            if (txusername.Text == "")
            {
                txusername.Text = "USERNAME";
            }
        }

        private void txpass_Enter(object sender, EventArgs e)
        {
            if (txpass.Text == "PASSWORD")
            {
                txpass.Text = "";
            }
        }

        private void txpass_Leave(object sender, EventArgs e)
        {
            if (txpass.Text == "")
            {
                txpass.Text = "PASSWORD";
            }
        }
    }
}
