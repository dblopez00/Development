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

namespace Development
{
    public partial class People : Form
    {
        public People()
        {
            InitializeComponent();
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(
                   ConfigurationManager.ConnectionStrings["cs_proyecto"].ConnectionString
               );

            cn.Open();

            if (txname.Text == "")
            {
                MessageBox.Show("El espacio Nombre vacio", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txlastname.Text == "")
            {
                MessageBox.Show("El espacion Raza esta vacio", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txgender.Text == "")
            {
                MessageBox.Show("El espacion Sexo esta vacio", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txage.Text == "")
            {
                MessageBox.Show("El espacion Tipo esta vacio", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txphone.Text == "")
            {
                MessageBox.Show("El espacion Color esta vacio", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txced.Text == "")
            {
                MessageBox.Show("El espacion Edad esta vacio", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string tablas = "INSERT INTO People (Name, Lastname, Gender, Age, Phone, Cedula) VALUES ('" + txname.Text + "','" + txlastname.Text + "','" + txgender.Text + "','" + txage.Text + "','" + txphone.Text + "','" + txced.Text + "')";

                SqlCommand comando = new SqlCommand(tablas, cn);

                int result = comando.ExecuteNonQuery();

                MessageBox.Show("Registro listo", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cn.Close();


                txname.Clear();
                txlastname.Clear();
                txgender.Clear();
                txage.Clear();
                txphone.Clear();
                txced.Clear();
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            Update up = new Update();
            up.Show();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            Delete de = new Delete();
            de.Show();
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            //SqlConnection cn = new SqlConnection(
            //      ConfigurationManager.ConnectionStrings["cs_proyecto"].ConnectionString
            //  );

            //cn.Open();

            //string tablas = "SELECT * FROM People";

            //SqlCommand comando = new SqlCommand(tablas, cn);

            //SqlDataAdapter adapter = new SqlDataAdapter(comando);
            //DataSet set = new DataSet();
            //adapter.Fill(set);
            //datashow.DataSource = set.Tables[0];

            //cn.Close();

            SqlConnection cn = new SqlConnection(
                  ConfigurationManager.ConnectionStrings["cs_proyecto"].ConnectionString
              );
            SqlDataAdapter adapter;
            SqlParameter param;
            SqlCommand comando = new SqlCommand();
            DataSet ds = new DataSet();

            cn.Open();

            comando.Connection = cn;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "sp_consulta";

            param = new SqlParameter();
            comando.Parameters.Add("@Name", SqlDbType.VarChar).Value = "Debbi";
            comando.Parameters.Add("@PhoneNumber", SqlDbType.VarChar).Value = "123456";
            //param.Direction = ParameterDirection.Input;
            //param.DbType = DbType.String;
            //comando.Parameters.Add(param);

            adapter = new SqlDataAdapter(comando);
            adapter.Fill(ds);

            for (int i = 0; i <= ds.Tables[0].Rows.Count; i++)
            {
                datashow.DataSource = ds.Tables[0];    
            }
            

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.Show();
        }
    }
}
