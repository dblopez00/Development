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
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(
                 ConfigurationManager.ConnectionStrings["cs_proyecto"].ConnectionString
             );

            cn.Open();

            if (txcamp.Text == "")
            {
                MessageBox.Show("La casilla Set esta vacia", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txset.Text == "")
            {
                MessageBox.Show("La casilla Where esta vacia", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txwhere.Text == "")
            {
                MessageBox.Show("La casilla Camp esta vacia", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string tablas = "UPDATE People SET " + txcamp.Text + "='" + txset.Text + "' WHERE Id_People=" + txwhere.Text + "";

                SqlCommand comando = new SqlCommand(tablas, cn);
                int show = comando.ExecuteNonQuery();

                cn.Close();
                MessageBox.Show("Se ha actualizado su registro", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
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
    }
}
