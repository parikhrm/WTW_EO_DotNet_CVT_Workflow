using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;
using System.Configuration;
using System.IO;

namespace CVT_Workflow
{
    public partial class Main_Page : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        public string connectionstringtxt = "Data Source=A20-CB-DBSE01P;Initial Catalog=DRD;User ID=DRDUsers;Password=24252425";

        public Main_Page()
        {
            InitializeComponent();
        }

        private void cvt_workflow_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 obj_form1 = new Form1();
            obj_form1.Show();
        }

        private void passfort_cvt_Click(object sender, EventArgs e)
        {
            this.Hide();
            PassFort_CVT obj_passfort = new PassFort_CVT();
            obj_passfort.Show();
        }
    }
}
