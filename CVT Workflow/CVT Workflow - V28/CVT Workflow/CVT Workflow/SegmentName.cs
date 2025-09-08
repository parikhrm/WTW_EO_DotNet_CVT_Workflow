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
using System.Data.OleDb;
using System.Configuration;

namespace CVT_Workflow
{
    class SegmentName
    {
        public void segmentname_list(DataTable dta)
        {
            string connectionstringtxt = "Data Source=A20-CB-DBSE01P;Initial Catalog=DRD;User ID=DRDUsers;Password=24252425";
            SqlCommand cmd = new SqlCommand();
            SqlConnection conn = new SqlConnection();

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                DataTable dt = new DataTable();
                conn.ConnectionString = connectionstringtxt;
                cmd.Connection = conn;
                conn.Open();
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                //cmd.CommandText = "select * from tbl_cvt_segment_dotnet with(nolock) order by SegmentName asc";
                cmd.CommandText = "select * from dbo.tbl_kycrdcworkflow_segmentname_dotnet with(nolock) union select distinct a.Segment,b.ID from tbl_bumapping_GlobalDirectory a with(nolock) inner join tbl_kycrdcworkflow_segmentname_dotnet b with(nolock) on a.Segment = b.SegmentName where 1=1 and a.Segment is not null order by SegmentName asc";
                sda.SelectCommand = cmd;
                dt = dta;
                sda.Fill(dta);
            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details : " + ab.ToString());
            }
        }
    }
}
