using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace winConection1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public String strConn = "Data Source=(local); Initial Catalog=facturacion; Integrated Security=SSPI";
        public String strComm = "SELECT nombre_cli, dir_cli FROM Clientes";

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            
            using(SqlConnection conn = new SqlConnection(strConn)) 
            { 
                conn.Open();
            }
        }
    }
}
