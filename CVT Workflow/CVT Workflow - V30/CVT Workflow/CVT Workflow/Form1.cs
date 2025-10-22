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
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        public string connectionstringtxt = "Data Source=A20-CB-DBSE01P;Initial Catalog=DRD;User ID=DRDUsers;Password=24252425";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dRDDataSet14.tbl_cvt_EscalationHandledBy_dotnet' table. You can move, or remove it, as needed.
            //this.tbl_cvt_EscalationHandledBy_dotnetTableAdapter.Fill(this.dRDDataSet14.tbl_cvt_EscalationHandledBy_dotnet);
            // TODO: This line of code loads data into the 'dRDDataSet13.tbl_cvt_daily_dotnet' table. You can move, or remove it, as needed.
            //this.tbl_cvt_daily_dotnetTableAdapter.Fill(this.dRDDataSet13.tbl_cvt_daily_dotnet);
            // TODO: This line of code loads data into the 'dRDDataSet12.tbl_cvt_segment_dotnet' table. You can move, or remove it, as needed.
            //this.tbl_cvt_segment_dotnetTableAdapter.Fill(this.dRDDataSet12.tbl_cvt_segment_dotnet);
            // TODO: This line of code loads data into the 'dRDDataSet11.tbl_locationlist_overall_dotnet' table. You can move, or remove it, as needed.
            //this.tbl_locationlist_overall_dotnetTableAdapter.Fill(this.dRDDataSet11.tbl_locationlist_overall_dotnet);
            // TODO: This line of code loads data into the 'dRDDataSet10.tbl_partylocation_dotnet' table. You can move, or remove it, as needed.
            //this.tbl_partylocation_dotnetTableAdapter.Fill(this.dRDDataSet10.tbl_partylocation_dotnet);
            // TODO: This line of code loads data into the 'dRDDataSet9.tbl_cvt_Approvedby_dotnet' table. You can move, or remove it, as needed.
            //this.tbl_cvt_Approvedby_dotnetTableAdapter.Fill(this.dRDDataSet9.tbl_cvt_Approvedby_dotnet);
            // TODO: This line of code loads data into the 'dRDDataSet8.tbl_cvt_QueryResolvedBy_dotnet' table. You can move, or remove it, as needed.
            //this.tbl_cvt_QueryResolvedBy_dotnetTableAdapter.Fill(this.dRDDataSet8.tbl_cvt_QueryResolvedBy_dotnet);
            // TODO: This line of code loads data into the 'dRDDataSet7.tbl_cvt_QueriedFor_dotnet' table. You can move, or remove it, as needed.
            //this.tbl_cvt_QueriedFor_dotnetTableAdapter.Fill(this.dRDDataSet7.tbl_cvt_QueriedFor_dotnet);
            // TODO: This line of code loads data into the 'dRDDataSet6.tbl_cvt_QueryCategory_dotnet' table. You can move, or remove it, as needed.
            //this.tbl_cvt_QueryCategory_dotnetTableAdapter.Fill(this.dRDDataSet6.tbl_cvt_QueryCategory_dotnet);
            // TODO: This line of code loads data into the 'dRDDataSet5.tbl_cvt_OrgStatus_dotnet' table. You can move, or remove it, as needed.
            //this.tbl_cvt_OrgStatus_dotnetTableAdapter.Fill(this.dRDDataSet5.tbl_cvt_OrgStatus_dotnet);
            // TODO: This line of code loads data into the 'dRDDataSet4.tbl_cvt_Role_dotnet' table. You can move, or remove it, as needed.
            //this.tbl_cvt_Role_dotnetTableAdapter.Fill(this.dRDDataSet4.tbl_cvt_Role_dotnet);
            // TODO: This line of code loads data into the 'dRDDataSet3.tbl_cvt_RevisedBU_dotnet' table. You can move, or remove it, as needed.
            //this.tbl_cvt_RevisedBU_dotnetTableAdapter.Fill(this.dRDDataSet3.tbl_cvt_RevisedBU_dotnet);
            // TODO: This line of code loads data into the 'dRDDataSet2.tbl_cvt_BU_dotnet' table. You can move, or remove it, as needed.
            //this.tbl_cvt_BU_dotnetTableAdapter.Fill(this.dRDDataSet2.tbl_cvt_BU_dotnet);
            // TODO: This line of code loads data into the 'dRDDataSet1.tbl_cvt_Processedby_dotnet' table. You can move, or remove it, as needed.
            //this.tbl_cvt_Processedby_dotnetTableAdapter.Fill(this.dRDDataSet1.tbl_cvt_Processedby_dotnet);
            // TODO: This line of code loads data into the 'dRDDataSet.tbl_cvt_activitytype_dotnet' table. You can move, or remove it, as needed.
            //this.tbl_cvt_activitytype_dotnetTableAdapter.Fill(this.dRDDataSet.tbl_cvt_activitytype_dotnet);
            
            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 300000;//30 secs
            timer1.Tick += new System.EventHandler(timer1_Tick);
            timer1.Start();
            //ActivityType obj_activitytype = new ActivityType();
            //BU obj_bu = new BU();
            //Role obj_role = new Role();
            //OrgStatus obj_orgstatus = new OrgStatus();
            //PartyLocation obj_partylocation = new PartyLocation();
            //RequestorLocation obj_requestorlocation = new RequestorLocation();
            //SegmentName obj_segmentname = new SegmentName();
            //QueryCategory obj_querycategory = new QueryCategory();
            //QueryResolvedBy obj_queryresolvedby = new QueryResolvedBy();
            //ApprovedBy obj_approvedby = new ApprovedBy();
            //EscalationHandledBy obj_escalationhandledby = new EscalationHandledBy();
            //RevisedBU obj_revisedbu = new RevisedBU();
            //OrgCreatedBy obj_orgcreatedby = new OrgCreatedBy();
            //ProjectNonProject obj_projectnonproject = new ProjectNonProject();
            //LegalEntityName obj_legalentityname = new LegalEntityName();
            //Categories obj_categories = new Categories();
            //SubCategories obj_subcategories = new SubCategories();
            //QCDoneBy obj_qcdoneby = new QCDoneBy();
            //activitytype_list();
            role_list();
            orgstatus_list();
            partylocation_list();
            requeststatus_list();
            orgcreatedby_list();
            legalentityname_list();
            categories_qc_list();
            subcategories_qc_list();
            clientonboardingformrequired_list();
            ricopted_list();
            empdetails_list();
            queryraisedby.SelectedIndex = -1;
            approvedby.SelectedIndex = -1;
            qcdoneby.SelectedIndex = -1;
            datagridview_click.Enabled = false;
            requeryby_list();
            activitytype_list();
            requeryby.SelectedIndex = -1;
            //datagridview_click.Visible = false;
            reset_overall();   
        }

        public void hideunhide_approveddates()
        {
            if (role.Text == "FINEX Fund Admins")
            {
                approvedby.SelectedIndex = -1;
                approveddate.CustomFormat = " ";
                approvedtime.CustomFormat = " ";
                approvedby.Enabled = false;
                approveddate.Enabled = false;
                approvedtime.Enabled = false;
            }
            else if (role.Text == "Insured - Standalone")
            {
                approvedby.SelectedIndex = -1;
                approveddate.CustomFormat = " ";
                approvedtime.CustomFormat = " ";
                approvedby.Enabled = false;
                approveddate.Enabled = false;
                approvedtime.Enabled = false;
            }
            else if (role.Text == "Instructing Party")
            {
                approvedby.SelectedIndex = -1;
                approveddate.CustomFormat = " ";
                approvedtime.CustomFormat = " ";
                approvedby.Enabled = false;
                approveddate.Enabled = false;
                approvedtime.Enabled = false;
            }
            else if (role.Text == "Reinsured - Standalone")
            {
                approvedby.SelectedIndex = -1;
                approveddate.CustomFormat = " ";
                approvedtime.CustomFormat = " ";
                approvedby.Enabled = false;
                approveddate.Enabled = false;
                approvedtime.Enabled = false;
            }
            else
            {
                approvedby.Enabled = true;
                approveddate.Enabled = true;
                approvedtime.Enabled = true;
            }
        }

        public void hide_columns()
        {

            label_cofsmsoreceiveddate.Visible = false;
            clientinformationformsmsoexceptiondate.Visible = false;
            label_cofverificationcompletedate.Visible = false;
            clientonboardingverificationcompletedate.Visible = false;
            label_ricopted.Visible = false;
            ricopted.Visible = false;
            label_querydate.Visible = false;
            querydate.Visible = false;
            querytime.Visible = false;
            label_querycategory.Visible = false;
            querycategory.Visible = false;
            label_queriedfor.Visible = false;
            queriedfor.Visible = false;
            label_queryresolveddate.Visible = false;
            queryresolveddate.Visible = false;
            queryresolvedtime.Visible = false;
            checkBox3.Visible = false;
            label_queryraisedby.Visible = false;
            queryraisedby.Visible = false;
            label_approveddate.Visible = false;
            approveddate.Visible = false;
            approvedtime.Visible = false;
            checkBox5.Visible = false;
            label_approvedby.Visible = false;
            approvedby.Visible = false;
            label_plcrequestid.Visible = false;
            plcrequestid.Visible = false;
            label_subcategoriesqc.Visible = false;
            subcategories_qc.Visible = false;
            label_categoriesqc.Visible = false;
            categories_qc.Visible = false;
            label_qcdate.Visible = false;
            qcdate.Visible = false;
            label_qcdoneby.Visible = false;
            qcdoneby.Visible = false;
            label_requerydate.Visible = false;
            requerydate.Visible = false;
            requerytime.Visible = false;
            label_requeryby.Visible = false;
            requeryby.Visible = false;
        }

        public void unhide_columns()
        {
            label_clientonboardingformrequired.Visible = true;
            clientonboardingformrequired.Visible = true;
            label_cofsmsoreceiveddate.Visible = true;
            clientinformationformsmsoexceptiondate.Visible = true;
            label_cofverificationcompletedate.Visible = true;
            clientonboardingverificationcompletedate.Visible = true;
            label_ricopted.Visible = true;
            ricopted.Visible = true;
            label_querydate.Visible = true;
            querydate.Visible = true;
            querytime.Visible = true;
            label_querycategory.Visible = true;
            querycategory.Visible = true;
            label_queriedfor.Visible = true;
            queriedfor.Visible = true;
            label_queryresolveddate.Visible = true;
            queryresolveddate.Visible = true;
            queryresolvedtime.Visible = true;
            checkBox3.Visible = true;
            label_queryraisedby.Visible = true;
            queryraisedby.Visible = true;
            label_approveddate.Visible = true;
            approveddate.Visible = true;
            approvedtime.Visible = true;
            checkBox5.Visible = true;
            label_approvedby.Visible = true;
            approvedby.Visible = true;
            label_plcrequestid.Visible = true;
            plcrequestid.Visible = true;
            label_subcategoriesqc.Visible = true;
            subcategories_qc.Visible = true;
            label_categoriesqc.Visible = true;
            categories_qc.Visible = true;
            label_qcdate.Visible = true;
            qcdate.Visible = true;
            label_qcdoneby.Visible = true;
            qcdoneby.Visible = true;
            label_requerydate.Visible = true;
            requerydate.Visible = true;
            requerytime.Visible = true;
            label_requeryby.Visible = true;
            requeryby.Visible = true;
        }

        public void reset_overall()
        {
            bu_list();
            requestorlocation_list();
            segmentname_list();
            requestid.Enabled = false;
            volumes.Value = 1;
            requestid.Text = string.Empty;
            todaydate.Visible = false;
            activitytype.SelectedIndex = -1;
            partyname.Text = string.Empty;
            todaydate.Text = DateTime.Now.ToLongDateString();
            bu.SelectedIndex = -1;
            role.SelectedIndex = -1;
            orgid.Text = string.Empty;
            orgstatus.SelectedIndex = -1;
            querycategory.SelectedIndex = -1;
            queriedfor.SelectedIndex = -1;
            queryraisedby.SelectedIndex = -1;
            approvedby.SelectedIndex = -1;
            requestoremailaddress.Text = string.Empty;
            requestorlocation.SelectedIndex = -1;
            comments.Text = string.Empty;
            querydate.Enabled = false;
            querytime.Enabled = false;
            querycategory.Enabled = false;
            queriedfor.Enabled = false;
            queryresolveddate.Enabled = false;
            queryresolvedtime.Enabled = false;
            queryraisedby.Enabled = false;
            approveddate.Enabled = false;
            approvedtime.Enabled = false;
            approvedby.Enabled = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            searchbyorgid.Text = string.Empty;
            searchbypartyname.Text = string.Empty;
            requestorsegmentname.SelectedIndex = -1;
            update.Enabled = false;
            insert.Enabled = true;
            legalentity.SelectedIndex = -1;
            plcrequestid.Text = string.Empty;
            categories_qc.SelectedIndex = -1;
            subcategories_qc.SelectedIndex = -1;
            qcdoneby.SelectedIndex = -1;
            qcdate.CustomFormat = " ";
            clientonboardingverificationcompletedate.CustomFormat = " ";
            clientinformationformsmsoexceptiondate.CustomFormat = " ";
            clientonboardingverificationcompletedate.Enabled = false;
            clientinformationformsmsoexceptiondate.Enabled = false;
            clientonboardingformrequired.SelectedIndex = -1;
            ricopted.SelectedIndex = -1;
            ricopted.Enabled = false;
            receiveddate.CustomFormat = " ";
            receivedtime.CustomFormat = " ";
            bu.SelectedIndex = -1;
            requestorsegmentname.SelectedIndex = -1;
            requestorlocation.SelectedIndex = -1;
            inflowprocessedby.SelectedIndex = -1;
            requerydate.CustomFormat = " ";
            requerytime.CustomFormat = " ";
            requeryby.SelectedIndex = -1;
            unhide_columns();
            ubovalidationdate.Enabled = false;
            datagridview_display_overall();
        }

        public void autopopulate_requestorlocation()
        {
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
                cmd.CommandText = "exec usp_cvtworkflow_requestorlocation_autopopulate_dotnet @RequestorEmailAddressparam";
                cmd.Parameters.AddWithValue("@RequestorEmailAddressparam", requestoremailaddress.Text);
                sda.SelectCommand = cmd;
                sda.Fill(dt);
                requestorlocation.DataSource = dt;
                requestorlocation.DisplayMember = "RequestorLocation";
                //requestorlocation.ValueMember = "ID";
                conn.Close();
                requestorlocation.SelectedIndex = -1;
            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details : " + ab.ToString());
            }
        }
        public void autopopulate_segment()
        {
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
                cmd.CommandText = "exec usp_cvtworkflow_segment_autopopulate_dotnet @RequestorEmailAddressparam";
                cmd.Parameters.AddWithValue("@RequestorEmailAddressparam", requestoremailaddress.Text);
                sda.SelectCommand = cmd;
                sda.Fill(dt);
                requestorsegmentname.DataSource = dt;
                requestorsegmentname.DisplayMember = "Segment";
                //requestorsegmentname.ValueMember = "ID";
                conn.Close();
                requestorsegmentname.SelectedIndex = -1;
            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details : " + ab.ToString());
            }
        }

        public void autopopulate_businessunit()
        {
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
                cmd.CommandText = "exec dbo.usp_cvtworkflow_businessunit_autopopulate_dotnet @RequestorEmailAddressparam";
                cmd.Parameters.AddWithValue("@RequestorEmailAddressparam", requestoremailaddress.Text);
                sda.SelectCommand = cmd;
                sda.Fill(dt);
                bu.DataSource = dt;
                bu.DisplayMember = "BusinessUnit";
                //bu.ValueMember = "ID";
                conn.Close();
                bu.SelectedIndex = -1;
            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details : " + ab.ToString());
            }
        }

        public void empdetails_list()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            try
            {
                Emp_Details obj_empname = new Emp_Details();
                DataTable dtaa_processedby = new DataTable();
                
                DataTable dtaa_escalationhandledby = new DataTable();
                DataTable dtaa_qcdoneby = new DataTable();
                DataTable dtaa_inflowprocessedby = new DataTable();
                DataTable dtaa_orgcreatedby = new DataTable();

                
                obj_empname.escalationhandledby_list(dtaa_escalationhandledby);
                obj_empname.processedby_list(dtaa_processedby);
                obj_empname.qcdoneby_list(dtaa_qcdoneby);
                obj_empname.inflowprocessedby_list(dtaa_inflowprocessedby);
                obj_empname.orgcreatedby_list(dtaa_orgcreatedby);

             
                qcdoneby.DataSource = dtaa_qcdoneby;
                qcdoneby.DisplayMember = "EmpName";

                
                inflowprocessedby.DataSource = dtaa_inflowprocessedby;
                inflowprocessedby.DisplayMember = "EmpName";

                conn.Close();

                approvedby.SelectedIndex = -1;
                qcdoneby.SelectedIndex = -1;
                inflowprocessedby.SelectedIndex = -1;

            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details: " + ab.ToString());
            }
        }

        public void approvedby_list()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            try
            {
                Emp_Details obj_empname = new Emp_Details();
                DataTable dtaa_approvedby = new DataTable();
                
                obj_empname.approvedby_list(dtaa_approvedby);
                
                approvedby.DataSource = dtaa_approvedby;
                approvedby.DisplayMember = "EmpName";

                
                conn.Close();

                approvedby.SelectedIndex = -1;
                
            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details: " + ab.ToString());
            }
        }

        public void queryraisedby_list()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            try
            {
                QueryRaisedBy obj_queryraisedby = new QueryRaisedBy();
                DataTable dtaa_raisedby = new DataTable();

                obj_queryraisedby.queryraisedby_list(dtaa_raisedby);

                queryraisedby.DataSource = dtaa_raisedby;
                queryraisedby.DisplayMember = "QueryResolvedBy";

               
                conn.Close();

                queryraisedby.SelectedIndex = -1;

            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details: " + ab.ToString());
            }
        }

        public void requeryby_list()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            try
            {
                ReQueryBy obj_requeryby = new ReQueryBy();
                DataTable dtaa_requeryby = new DataTable();
                obj_requeryby.requeryby_list (dtaa_requeryby);
                requeryby.DataSource = dtaa_requeryby;
                requeryby.DisplayMember = "QueryResolvedBy";
                conn.Close();
                requeryby.SelectedIndex = -1;

            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details: " + ab.ToString());
            }
        }

        public void categories_qc_list()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            try
            {
                Categories obj_categories = new Categories();
                DataTable dtaa = new DataTable();
                obj_categories.categories_list(dtaa);
                categories_qc.DataSource = dtaa;
                categories_qc.DisplayMember = "Categories";
                conn.Close();
                categories_qc.SelectedIndex = -1;
            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details: " + ab.ToString());
            }
        }

        public void clientonboardingformrequired_list()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            try
            {
                Boolean obj_boolean = new Boolean();
                DataTable dtaa = new DataTable();
                obj_boolean.clientonboardingformrequired_list(dtaa);
                clientonboardingformrequired.DataSource = dtaa;
                clientonboardingformrequired.DisplayMember = "Boolean";
                conn.Close();
                clientonboardingformrequired.SelectedIndex = -1;
            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details: " + ab.ToString());
            }
        }

        public void ricopted_list()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            try
            {
                Boolean obj_boolean = new Boolean();
                DataTable dtaa = new DataTable();
                obj_boolean.ricopted_list (dtaa);
                ricopted.DataSource = dtaa;
                ricopted.DisplayMember = "Boolean";
                conn.Close();
                ricopted.SelectedIndex = -1;
            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details: " + ab.ToString());
            }
        }


        public void subcategories_qc_list()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            try
            {
                SubCategories obj_subcategories = new SubCategories();
                DataTable dtaa = new DataTable();
                obj_subcategories.subcategories_list(dtaa);
                subcategories_qc.DataSource = dtaa;
                subcategories_qc.DisplayMember = "SubCategories";
                conn.Close();
                subcategories_qc.SelectedIndex = -1;
            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details: " + ab.ToString());
            }
        }


        public void projectnonproject_list()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            try
            {
                ProjectNonProject obj_projectnonproject = new ProjectNonProject();
                DataTable dtaa = new DataTable();
                obj_projectnonproject.projectnonproject_list(dtaa);
                conn.Close();

            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details: " + ab.ToString());
            }
        }

        public void legalentityname_list()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            try
            {
                LegalEntityName obj_legalentityname = new LegalEntityName();
                DataTable dtaa = new DataTable();
                obj_legalentityname.legalentityname_list(dtaa);
                legalentity.DataSource = dtaa;
                legalentity.DisplayMember = "WTWLegalEntity";
                conn.Close();
                legalentity.SelectedIndex = -1;
            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details: " + ab.ToString());
            }
        }

        public void orgcreatedby_list()
        {
            //if (conn.State == ConnectionState.Open)
            //{
            //    conn.Close();
            //}

            //try
            //{
            //    OrgCreatedBy obj_orgcreatedby = new OrgCreatedBy();
            //    DataTable dtaa = new DataTable();
            //    obj_orgcreatedby.orgcreatedby_list(dtaa);
            //    orgcreatedby.DataSource = dtaa;
            //    orgcreatedby.DisplayMember = "Processedby";
            //    conn.Close();
            //    orgcreatedby.SelectedIndex = -1;
            //}
            //catch (Exception ab)
            //{
            //    MessageBox.Show("Error Generated Details: " + ab.ToString());
            //}
        }

        public void revisedbu_list()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            try
            {
                RevisedBU obj_revisedbu = new RevisedBU();
                DataTable dtaa = new DataTable();
                obj_revisedbu.revisedbu_list(dtaa,bu.Text);
                conn.Close();
            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details: " + ab.ToString());
            }
        }
        
        public void autopopulate_queriedfor_list()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            try
            {
                QueryCategory obj_querycategory = new QueryCategory();
                DataTable dtaa = new DataTable();
                string querycategoryvalue = querycategory.Text;
                obj_querycategory.queriedfor_list(dtaa, querycategoryvalue);
                queriedfor.DataSource = dtaa;
                queriedfor.DisplayMember = "QueriedFor";
                conn.Close();
            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details: " + ab.ToString());
            }
        }

        public void querycategory_list()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            try
            {
                QueryCategory obj_querycategory = new QueryCategory();
                DataTable dtaa = new DataTable();
                obj_querycategory.querycategory_list(dtaa);
                querycategory.DataSource = dtaa;
                querycategory.DisplayMember = "QueryCategory";
                conn.Close();
                querycategory.SelectedIndex = -1;
            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details: " + ab.ToString());
            }
        }

        public void requeststatus_list()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            try
            {
                RequestStatus obj_requeststatus = new RequestStatus();
                DataTable dtaa = new DataTable();
                obj_requeststatus.requeststatus_searchby_ist (dtaa);

                searchbyrequeststatus.DataSource = dtaa;
                searchbyrequeststatus.DisplayMember = "RequestStatus";
                conn.Close();
                searchbyrequeststatus.SelectedIndex = -1;
            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details: " + ab.ToString());
            }
        }

        public void activitytype_list()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            try
            {
                ActivityType obj_activitytype = new ActivityType();
                DataTable dtaa = new DataTable();
                DataTable dtaa_searchby = new DataTable();

                obj_activitytype.activitytype_list(dtaa);
                obj_activitytype.activitytype_searchby_list(dtaa_searchby);

                activitytype.DataSource = dtaa;
                activitytype.DisplayMember = "ActivityType";

                searchbyactivitytype.DataSource = dtaa_searchby;
                searchbyactivitytype.DisplayMember = "ActivityType";

                conn.Close();
                activitytype.SelectedIndex = -1;
                searchbyactivitytype.SelectedIndex = -1;
            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details: " + ab.ToString());
            }
        }

       
        public void bu_list()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            try
            {
                BU obj_bu = new BU();
                DataTable dtaa = new DataTable();
                obj_bu.bu_list(dtaa);
                bu.DataSource = dtaa;
                bu.DisplayMember = "BU";
                conn.Close();
            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details: " + ab.ToString());
            }
        }

        public void role_list()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            try
            {
                Role obj_role = new Role();
                DataTable dtaa = new DataTable();
                obj_role.role_list(dtaa);
                role.DataSource = dtaa;
                role.DisplayMember = "Role";
                conn.Close();
                role.SelectedIndex = -1;
            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details: " + ab.ToString());
            }
        }

        public void orgstatus_list()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            try
            {
                OrgStatus obj_orgstatus = new OrgStatus();
                DataTable dtaa = new DataTable();
                obj_orgstatus.orgstatus_list(dtaa);
                orgstatus.DataSource = dtaa;
                orgstatus.DisplayMember = "OrgStatus";
                conn.Close();
                orgstatus.SelectedIndex = -1;
            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details: " + ab.ToString());
            }
        }

        public void partylocation_list()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            try
            {
                PartyLocation obj_partylocation = new PartyLocation();
                DataTable dtaa = new DataTable();
                obj_partylocation.partylocation_list(dtaa);
                conn.Close();
            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details: " + ab.ToString());
            }
        }

        public void requestorlocation_list()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            try
            {
                RequestorLocation obj_requestorlocation = new RequestorLocation();
                DataTable dtaa = new DataTable();
                obj_requestorlocation.requestorlocation_list(dtaa);
                requestorlocation.DataSource = dtaa;
                requestorlocation.DisplayMember = "Requestor Location";
                conn.Close();
            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details: " + ab.ToString());
            }
        }

        public void segmentname_list()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            try
            {
                SegmentName obj_segmentname = new SegmentName();
                DataTable dtaa = new DataTable();
                obj_segmentname.segmentname_list(dtaa);
                requestorsegmentname.DataSource = dtaa;
                requestorsegmentname.DisplayMember = "SegmentName";
                conn.Close();
            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details: " + ab.ToString());
            }
        }

        
        public void ToCsV(DataGridView dGV, string filename)
        {
            string stOutput = "";
            // Export titles:
            string sHeaders = "";

            for (int j = 0; j < dGV.Columns.Count; j++)
                sHeaders = sHeaders.ToString() + Convert.ToString(dGV.Columns[j].HeaderText) + "\t";
            stOutput += sHeaders + "\r\n";
            // Export data.
            for (int i = 0; i < dGV.RowCount - 1; i++)
            {
                string stLine = "";
                for (int j = 0; j < dGV.Rows[i].Cells.Count; j++)
                    stLine = stLine.ToString() + Convert.ToString(dGV.Rows[i].Cells[j].Value) + "\t";
                stOutput += stLine + "\r\n";
            }
            Encoding utf16 = Encoding.GetEncoding(1254);
            byte[] output = utf16.GetBytes(stOutput);
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(output, 0, output.Length); //write the encoded file
            bw.Flush();
            bw.Close();
            fs.Close();
        }

        public void datagridview_display_overall()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            SqlDataAdapter sda = new SqlDataAdapter();
            DataTable dt = new DataTable();
            conn.ConnectionString = connectionstringtxt;
            cmd.Connection = conn;
            conn.Open();
            cmd.Parameters.Clear();
            if (string.IsNullOrEmpty(searchbyorgid.Text) && string.IsNullOrEmpty(searchbypartyname.Text) && string.IsNullOrEmpty(searchbyactivitytype.Text) && string.IsNullOrEmpty(searchbyrequeststatus.Text))
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select top 100 a.RequestId,a.ActivityType,a.PartyName,a.ReceivedDate,a.ReceivedTime,a.RequestorEmailAddress,a.RequestorLocation,a.RequestorSegmentName,a.BU,a.LegalEntityName,a.Role,a.OrgID,a.OrgStatus,a.ClientOnboardingFormRequired,a.Volumes,a.COF_SMSO_Received_Date,a.COF_Verification_Complete_Date,a.RICOpted,a.InflowProcessedBy,a.InflowProcessedDate,a.InflowProcessedTime,a.QueryDate,a.QueryTime,a.QueryCategory,a.QueriedFor,a.QueryResolvedDate,a.QueryResolvedTime,a.QueryRaisedBy,a.ReQueryBy,a.ReQueryDate,a.ReQueryTime,a.ApprovedDate,a.ApprovedTime,a.ApprovedBy,a.Comments,a.Party_Address,a.PLCRequestID,a.SubCategories_QC,a.Categories_QC,a.QCDate,a.QCDoneBy,a.RequestStatus,a.DunsNumber,a.Chaser1Date,a.Chaser2Date,a.Chaser3Date,isnull(b.TATMissCases,'False') as TATMissCases,a.UBO_ValidationDate from dbo.vw_cvt_datagridview_display_dotnet a left join dbo.vw_cvt_tat_dotnet b on a.RequestID = b.RequestID  where convert(date,a.receiveddate) >= '2023-06-01' and a.IsArchived = 0 order by a.RequestID";
            }
            else
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "dbo.usp_cvt_workflow_datagridview_search_dotnet";

                if (string.IsNullOrEmpty(searchbyorgid.Text))
                {
                    cmd.Parameters.AddWithValue("@orgid", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@orgid", searchbyorgid.Text);
                }
                if (string.IsNullOrEmpty(searchbypartyname.Text))
                {
                    cmd.Parameters.AddWithValue("@partyname", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@partyname", searchbypartyname.Text);
                }
                if (string.IsNullOrEmpty(searchbyrequeststatus.Text))
                {
                    cmd.Parameters.AddWithValue("@requeststatus", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@requeststatus", searchbyrequeststatus.Text);
                }
                if (string.IsNullOrEmpty(searchbyactivitytype.Text))
                {
                    cmd.Parameters.AddWithValue("@activitype", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@activitype", searchbyactivitytype.Text);
                }
            }
            sda.SelectCommand = cmd;
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                querycategory_list();
                queryraisedby_list();
                querydate.Enabled = true;
                querytime.Enabled = true;
                querycategory.Enabled = true;
                queriedfor.Enabled = true;
                queryraisedby.Enabled = true;
            }
            else
            {
                querydate.Enabled = false;
                querytime.Enabled = false;
                querycategory.Enabled = false;
                queriedfor.Enabled = false;
                querycategory.SelectedIndex = -1;
                queriedfor.SelectedIndex = -1;
                queryraisedby.Enabled = false;
                queryraisedby.SelectedIndex = -1;
                querydate.CustomFormat = " ";
                querytime.CustomFormat = " ";
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                queryresolveddate.Enabled = true;
                queryresolvedtime.Enabled = true;
                queryraisedby.Enabled = true;
            }
            else
            {
                queryresolveddate.Enabled = false;
                queryresolvedtime.Enabled = false;
                queryraisedby.Enabled = false;
                queryraisedby.SelectedIndex = -1;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                approvedby_list();
                approveddate.Enabled = true;
                approvedtime.Enabled = true;
                approvedby.Enabled = true;
            }
            else
            {
                approveddate.Enabled = false;
                approvedtime.Enabled = false;
                approvedby.Enabled = false;
                approvedby.SelectedIndex = -1;
                approveddate.CustomFormat = " ";
                approvedtime.CustomFormat = " ";
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            reset_overall();
        }

   

        private void insert_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            try
            {
                cmd.Parameters.Clear();
                conn.ConnectionString = connectionstringtxt;
                cmd.Connection = conn;
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "dbo.usp_cvt_insert_daily_dotnet";
                cmd.Parameters.Add("@Message", SqlDbType.NVarChar, 1000);
                cmd.Parameters["@Message"].Direction = ParameterDirection.Output;

                cmd.Parameters.AddWithValue("@ActivityType", activitytype.Text);
                cmd.Parameters.AddWithValue("@PartyName", partyname.Text);
                cmd.Parameters.AddWithValue("@ReceivedDate", receiveddate.Value.Date);
                cmd.Parameters.AddWithValue("@ReceivedTime", receivedtime.Value.ToLongTimeString());
                if (ubovalidationdate.Text.Trim() == string.Empty)
                {
                    cmd.Parameters.AddWithValue("@UBO_ValidationDate", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@UBO_ValidationDate", ubovalidationdate.Value.Date);
                }
                if (string.IsNullOrEmpty(requeryby.Text))
                {
                    cmd.Parameters.AddWithValue("@ReQueryBy", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ReQueryBy", requeryby.Text);
                }
                if (requerydate.Text.Trim() == string.Empty)
                {
                    cmd.Parameters.AddWithValue("@ReQueryDate", DBNull.Value);
                    cmd.Parameters.AddWithValue("@ReQueryTime", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ReQueryDate", requerydate.Value.Date);
                    cmd.Parameters.AddWithValue("@ReQueryTime", requerytime.Value.ToLongTimeString());
                }
                
                if (string.IsNullOrEmpty(bu.Text))
                {
                    cmd.Parameters.AddWithValue("@BU", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@BU", bu.Text);
                }
               
                if (string.IsNullOrEmpty(role.Text))
                {
                    cmd.Parameters.AddWithValue("@Role", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Role", role.Text);
                }
                if (string.IsNullOrEmpty(orgid.Text))
                {
                    cmd.Parameters.AddWithValue("@OrgID", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@OrgID", orgid.Text);
                }
                if (string.IsNullOrEmpty(orgstatus.Text))
                {
                    cmd.Parameters.AddWithValue("@OrgStatus", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@OrgStatus", orgstatus.Text);
                }
                
                if (string.IsNullOrEmpty(requestorsegmentname.Text))
                {
                    cmd.Parameters.AddWithValue("@RequestorSegmentName", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@RequestorSegmentName", requestorsegmentname.Text);
                }
                if (checkBox3.Checked)
                {
                    cmd.Parameters.AddWithValue("@QueryDate", querydate.Value.Date);
                    cmd.Parameters.AddWithValue("@QueryTime", querytime.Value.ToLongTimeString());
                    cmd.Parameters.AddWithValue("@QueryCategory", querycategory.Text);
                    cmd.Parameters.AddWithValue("@QueriedFor", queriedfor.Text);
                    cmd.Parameters.AddWithValue("@QueryRaisedBy",queryraisedby.Text);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@QueryDate", DBNull.Value);
                    cmd.Parameters.AddWithValue("@QueryTime", DBNull.Value);
                    cmd.Parameters.AddWithValue("@QueryCategory", DBNull.Value);
                    cmd.Parameters.AddWithValue("@QueriedFor", DBNull.Value);
                    cmd.Parameters.AddWithValue("@QueryRaisedBy", DBNull.Value);
                }
                if (checkBox4.Checked)
                {
                    cmd.Parameters.AddWithValue("@QueryResolvedDate", queryresolveddate.Value.Date);
                    cmd.Parameters.AddWithValue("@QueryResolvedTime", queryresolvedtime.Value.ToLongTimeString());
                    //cmd.Parameters.AddWithValue("@QueryResolvedBy", queryraisedby.Text);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@QueryResolvedDate", DBNull.Value);
                    cmd.Parameters.AddWithValue("@QueryResolvedTime", DBNull.Value);
                    //cmd.Parameters.AddWithValue("@QueryResolvedBy", DBNull.Value);
                }
                if (checkBox5.Checked)
                {
                    cmd.Parameters.AddWithValue("@ApprovedDate", approveddate.Value.Date);
                    cmd.Parameters.AddWithValue("@ApprovedTime", approvedtime.Value.ToLongTimeString());
                    cmd.Parameters.AddWithValue("@ApprovedBy", approvedby.Text);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ApprovedDate", DBNull.Value);
                    cmd.Parameters.AddWithValue("@ApprovedTime", DBNull.Value);
                    cmd.Parameters.AddWithValue("@ApprovedBy", DBNull.Value);
                }
                
                if (string.IsNullOrEmpty(requestoremailaddress.Text))
                {
                    cmd.Parameters.AddWithValue("@RequestorEmailAddress", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@RequestorEmailAddress", requestoremailaddress.Text);
                }
                if (string.IsNullOrEmpty(requestorlocation.Text))
                {
                    cmd.Parameters.AddWithValue("@RequestorLocation", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@RequestorLocation", requestorlocation.Text);
                }
                if (string.IsNullOrEmpty(comments.Text))
                {
                    cmd.Parameters.AddWithValue("@Comments", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Comments", comments.Text);
                }
                cmd.Parameters.AddWithValue("@LastUpdatedDateTime", DateTime.Now.ToLocalTime());
                cmd.Parameters.AddWithValue("@Volumes", volumes.Value);
                cmd.Parameters.AddWithValue("@LastUpdatedBy", Environment.UserName.ToString());
                cmd.Parameters.AddWithValue("@MachineName", Environment.MachineName.ToString());
                
                if (string.IsNullOrEmpty(legalentity.Text) && activitytype.Text == "CVT New Request")
                {
                    cmd.Parameters.AddWithValue("@LegalEntityName", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@LegalEntityName", legalentity.Text);
                }
                if (string.IsNullOrEmpty(plcrequestid.Text))
                {
                    cmd.Parameters.AddWithValue("@PLCRequestID", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@PLCRequestID", plcrequestid.Text);
                }
                
                if (string.IsNullOrEmpty(categories_qc.Text))
                {
                    cmd.Parameters.AddWithValue("@CategoriesQC", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@CategoriesQC", categories_qc.Text);
                }
                if (string.IsNullOrEmpty(subcategories_qc.Text))
                {
                    cmd.Parameters.AddWithValue("@SubCategoriesQC", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@SubCategoriesQC", subcategories_qc.Text);
                }
                if (string.IsNullOrEmpty(qcdoneby.Text))
                {
                    cmd.Parameters.AddWithValue("@QCDoneBy", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@QCDoneBy", qcdoneby.Text);
                }
                if (qcdate.Text.Trim() == string.Empty)
                {
                    cmd.Parameters.AddWithValue("@QCDate", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@QCDate", qcdate.Value.Date);
                }
                if (clientonboardingverificationcompletedate.Text.Trim() == string.Empty)
                {
                    cmd.Parameters.AddWithValue("@ClientOnboardingVerificationCompleteDate", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ClientOnboardingVerificationCompleteDate", clientonboardingverificationcompletedate.Value.Date);
                }
                if (clientinformationformsmsoexceptiondate.Text.Trim() == string.Empty)
                {
                    cmd.Parameters.AddWithValue("@ClientInformationFormSMSOExceptionDate", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ClientInformationFormSMSOExceptionDate", clientinformationformsmsoexceptiondate.Value.Date);
                }
                
                if (string.IsNullOrEmpty(clientonboardingformrequired.Text))
                {
                    cmd.Parameters.AddWithValue("@ClientOnboardingFormRequired", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ClientOnboardingFormRequired", clientonboardingformrequired.Text);
                }
                if (string.IsNullOrEmpty(ricopted.Text))
                {
                    cmd.Parameters.AddWithValue("@RICOpted", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@RICOpted", ricopted.Text);
                }
                if (string.IsNullOrEmpty(inflowprocessedby.Text))
                {
                    cmd.Parameters.AddWithValue("@InflowProcessedBy", DBNull.Value);
                    cmd.Parameters.AddWithValue("@InflowProcessedDate", DBNull.Value);
                    cmd.Parameters.AddWithValue("@InflowProcessedTime", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@InflowProcessedBy", inflowprocessedby.Text);
                    cmd.Parameters.AddWithValue("@InflowProcessedDate", inflowprocesseddate.Value.Date);
                    cmd.Parameters.AddWithValue("@InflowProcessedTime", inflowprocessedtime.Value.ToLongTimeString());
                }
                
               

                //If Conditions
                if (string.IsNullOrEmpty(activitytype.Text))
                {
                    MessageBox.Show("Please update Activity Type");
                }
                else if (clientonboardingformrequired.Text == "Yes" && ubovalidationdate.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please update UBO Validation Date");
                }
                else if (string.IsNullOrEmpty(partyname.Text))
                {
                    MessageBox.Show("Please update Party Name");
                }
                else if (string.IsNullOrEmpty(bu.Text) && activitytype.Text != "Account Assigning" && activitytype.Text != "Adhoc" && activitytype.Text != "Emails" && activitytype.Text != "ForDeletion" && activitytype.Text != "Market Security" && activitytype.Text != "Org Exception Report")
                {
                    MessageBox.Show("Please update BU Name");
                }
                else if (string.IsNullOrEmpty(role.Text) && activitytype.Text != "Account Assigning" && activitytype.Text != "Adhoc" && activitytype.Text != "Emails" && activitytype.Text != "ForDeletion" && activitytype.Text != "Market Security" && activitytype.Text != "Org Exception Report")
                {
                    MessageBox.Show("Please update Role");
                }
                else if (activitytype.Text == "BAU Project (Inflow)" && string.IsNullOrEmpty(orgid.Text) && inflowprocesseddate.Text.Trim() != string.Empty)
                {
                    MessageBox.Show("Please update Org ID");
                }
                else if (activitytype.Text == "Inflow" && string.IsNullOrEmpty(orgid.Text) && inflowprocesseddate.Text.Trim() != string.Empty)
                {
                    MessageBox.Show("Please update Org ID");
                }
                else if (activitytype.Text == "Reactivation" && string.IsNullOrEmpty(orgid.Text) && inflowprocesseddate.Text.Trim() != string.Empty)
                {
                    MessageBox.Show("Please update Org ID");
                }
                else if (activitytype.Text == "BAU Project (Inflow)" && string.IsNullOrEmpty(orgstatus.Text))
                {
                    MessageBox.Show("Please update Org Status");
                }
                else if (activitytype.Text == "Inflow" && string.IsNullOrEmpty(orgstatus.Text))
                {
                    MessageBox.Show("Please update Org Status");
                }
                else if (activitytype.Text == "Reactivation" && string.IsNullOrEmpty(orgstatus.Text))
                {
                    MessageBox.Show("Please update Org Status");
                }
                else if (checkBox3.Checked && string.IsNullOrEmpty(querycategory.Text))
                {
                    MessageBox.Show("Please update Query Category");
                }
                else if (checkBox3.Checked && string.IsNullOrEmpty(queriedfor.Text))
                {
                    MessageBox.Show("Please update Queried For");
                }
                else if (checkBox4.Checked && string.IsNullOrEmpty(queryraisedby.Text))
                {
                    MessageBox.Show("Please update Query Resolved By");
                }
                else if (checkBox5.Checked && string.IsNullOrEmpty(approvedby.Text))
                {
                    MessageBox.Show("Please update Approved By");
                }
                else if (receiveddate.Value.Date > todaydate.Value.Date)
                {
                    MessageBox.Show("Received date cannot be greater than Today's date");
                }
                else if (checkBox3.Checked && querydate.Value.Date > todaydate.Value.Date)
                {
                    MessageBox.Show("Query Date cannot be greater than Today's date");
                }
                else if (checkBox4.Checked && queryresolveddate.Value.Date > todaydate.Value.Date)
                {
                    MessageBox.Show("Query Resolved Date cannot be greater than Today's date");
                }
                else if (inflowprocesseddate.Value.Date > todaydate.Value.Date && inflowprocesseddate.Text.Trim() != string.Empty)
                {
                    MessageBox.Show("Inflow Processed Date cannot be greater than Today's date");
                }
                else if (checkBox5.Checked && approveddate.Value.Date > todaydate.Value.Date)
                {
                    MessageBox.Show("Approved Date cannot be greater than Today's date");
                }
                else if (checkBox5.Checked && receiveddate.Value.Date > approveddate.Value.Date)
                {
                    MessageBox.Show("Please check Received date and Approved date");
                }
                else if (checkBox3.Checked && checkBox4.Checked && querydate.Value.Date > queryresolveddate.Value.Date)
                {
                    MessageBox.Show("Please check Query date and Query Resolved date");
                }
                else if (checkBox3.Checked && checkBox5.Checked && querydate.Value.Date > approveddate.Value.Date)
                {
                    MessageBox.Show("Please check Query date and Approved date");
                }
                else if (checkBox4.Checked && checkBox5.Checked && queryresolveddate.Value.Date > approveddate.Value.Date)
                {
                    MessageBox.Show("Please check Query Resolved date and Approved date");
                }
                else if (string.IsNullOrEmpty(requestoremailaddress.Text) && activitytype.Text != "Account Assigning" && activitytype.Text != "Adhoc" && activitytype.Text != "Emails" && activitytype.Text != "ForDeletion" && activitytype.Text != "Market Security" && activitytype.Text != "Wolf Records" && activitytype.Text != "Org Exception Report")
                {
                    MessageBox.Show("Please update Requestor Email Address");
                }
                else if (string.IsNullOrEmpty(requestorlocation.Text) && activitytype.Text != "Account Assigning" && activitytype.Text != "Adhoc" && activitytype.Text != "Emails" && activitytype.Text != "ForDeletion" && activitytype.Text != "Market Security" && activitytype.Text != "Org Exception Report")
                {
                    MessageBox.Show("Please update Requestor Location");
                }
                else if (string.IsNullOrEmpty(requestorsegmentname.Text) && activitytype.Text != "Account Assigning" && activitytype.Text != "Adhoc" && activitytype.Text != "Emails" && activitytype.Text != "ForDeletion" && activitytype.Text != "Market Security" && activitytype.Text != "Org Exception Report")
                {
                    MessageBox.Show("Please update Requestor Segment Name");
                }
                else if (checkBox3.Checked && !checkBox4.Checked && checkBox5.Checked)
                {
                    MessageBox.Show("Please update Query Resolved Date");
                }
                else if (!checkBox3.Checked && checkBox4.Checked)
                {
                    MessageBox.Show("Please update Query Date");
                }
                else if (orgstatus.Text == "Approved" && !checkBox5.Checked)
                {
                    MessageBox.Show("Please update Approved Date as Org Status is marked as Approved");
                }
                else if (checkBox5.Checked && activitytype.Text == "CVT New Request" && orgstatus.Text != "Approved" && orgstatus.Text != "For Deletion")
                {
                    MessageBox.Show("Please check OrgStatus as OrgStatus should be Approved or For Deletion since the record is getting approved");
                }
                else if (orgid.Text != string.Empty && orgid.TextLength < 5)
                {
                    MessageBox.Show("OrgID cannot be less than 5 letters or numbers");
                }
                else if (string.IsNullOrEmpty(legalentity.Text) && activitytype.Text == "CVT New Request" && orgstatus.Text == "Pending CVT SPOE/Approval" && role.Text != "Insured - Standalone")
                {
                    MessageBox.Show("Please update Legal Entity Name");
                }
                else if (string.IsNullOrEmpty(legalentity.Text) && activitytype.Text == "CVT New Request" && orgstatus.Text == "Pending CVT SPOE/Approval" && role.Text != "Reinsured - Standalone")
                {
                    MessageBox.Show("Please update Legal Entity Name");
                }
                else if (qcdate.Value.Date > todaydate.Value.Date && qcdate.Text.Trim() != string.Empty)
                {
                    MessageBox.Show("QC date cannot be greater than Today's date");
                }
                else if (clientonboardingverificationcompletedate.Text.Trim() != string.Empty && clientonboardingverificationcompletedate.Value.Date > todaydate.Value.Date)
                {
                    MessageBox.Show("COF Verification Complete Date cannot be greater than today's date");
                }
                else if (clientinformationformsmsoexceptiondate.Text.Trim() != string.Empty && clientinformationformsmsoexceptiondate.Value.Date > todaydate.Value.Date)
                {
                    MessageBox.Show("COF SMSO Received Date cannot be more than today's date");
                }
                else if (clientonboardingverificationcompletedate.Text.Trim() != string.Empty && string.IsNullOrEmpty(legalentity.Text))
                {
                    MessageBox.Show("Please update Legal Entity Name");
                }
                else if (clientinformationformsmsoexceptiondate.Text.Trim() != string.Empty && string.IsNullOrEmpty(legalentity.Text))
                {
                    MessageBox.Show("Please update Legal Entity Name");
                }
                else if (!string.IsNullOrEmpty(legalentity.Text) && string.IsNullOrEmpty(clientonboardingformrequired.Text) && legalentity.Text == "Willis Limited")
                {
                    MessageBox.Show("Please update Client Onboarding Form Required");
                }
                else if (!string.IsNullOrEmpty(legalentity.Text) && string.IsNullOrEmpty(clientonboardingformrequired.Text) && legalentity.Text == "Willis Towers Watson SA NV")
                {
                    MessageBox.Show("Please update Client Onboarding Form Required");
                }
                else if (!string.IsNullOrEmpty(legalentity.Text) && string.IsNullOrEmpty(clientonboardingformrequired.Text) && legalentity.Text == "Willis Non-IBA")
                {
                    MessageBox.Show("Please update Client Onboarding Form Required");
                }
                else if (!string.IsNullOrEmpty(clientonboardingformrequired.Text) && (clientinformationformsmsoexceptiondate.Text.Trim() == string.Empty && clientonboardingverificationcompletedate.Text.Trim() == string.Empty) && clientonboardingformrequired.Text == "Yes")
                {
                    MessageBox.Show("Please update COF SMSO Received Date or COF Verification Complete Date");
                }
                else if (clientonboardingverificationcompletedate.Text.Trim() != string.Empty && string.IsNullOrEmpty(ricopted.Text))
                {
                    MessageBox.Show("Please update RIC Opted");
                }
                //else if (activitytype.Text == "CVT New Request" && !string.IsNullOrEmpty(queryraisedby.Text) && !string.IsNullOrEmpty(approvedby.Text) && queryraisedby.Text == approvedby.Text)
                //{
                //    MessageBox.Show("Query Resolved By and Approved By should not be the same person");
                //}
                //else if (activitytype.Text == "Reactivation" && !string.IsNullOrEmpty(queryraisedby.Text) && !string.IsNullOrEmpty(approvedby.Text) && queryraisedby.Text == approvedby.Text)
                //{
                //    MessageBox.Show("Query Resolved By and Approved By should not be the same person");
                //}
                //else if (activitytype.Text == "BAU Project" && !string.IsNullOrEmpty(queryraisedby.Text) && !string.IsNullOrEmpty(approvedby.Text) && queryraisedby.Text == approvedby.Text)
                //{
                //    MessageBox.Show("Query Resolved By and Approved By should not be the same person");
                //}
                //else if (activitytype.Text == "Adhoc Project" && !string.IsNullOrEmpty(queryraisedby.Text) && !string.IsNullOrEmpty(approvedby.Text) && queryraisedby.Text == approvedby.Text)
                //{
                //    MessageBox.Show("Query Resolved By and Approved By should not be the same person");
                //}
                else if (!string.IsNullOrEmpty(orgstatus.Text) && orgstatus.Text == "Pending CVT SPOE/Approval" && string.IsNullOrEmpty(plcrequestid.Text))
                {
                    MessageBox.Show("Please update PLC Request ID");
                }
                else if (approveddate.Text.Trim() != string.Empty && checkBox5.Checked == true && orgstatus.Text != "Approved" && (role.Text != "Client Delegate" || role.Text != "Instructing Party" || role.Text != "Insured - Standalone" || role.Text != "Reinsured - Standalone"))
                {
                    MessageBox.Show("Org Status should be approved");
                }
                else if (approveddate.Text.Trim() == string.Empty && checkBox5.Checked == false && orgstatus.Text == "Approved" && (role.Text != "Client Delegate" || role.Text != "Instructing Party" || role.Text != "Insured - Standalone" || role.Text != "Reinsured - Standalone"))
                {
                    MessageBox.Show("Please update Approved Date");
                }
                else if (string.IsNullOrEmpty(requeryby.Text) && requerydate.Text.Trim() != string.Empty)
                {
                    MessageBox.Show("Please update Requery By");
                }
                else if (!string.IsNullOrEmpty(requeryby.Text) && requerydate.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please update Requery Date");
                }
                else if (requerydate.Text.Trim() != string.Empty && requerytime.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please update ReQuery Time");
                }
                else if (requerydate.Text.Trim() == string.Empty && requerytime.Text.Trim() != string.Empty)
                {
                    MessageBox.Show("Please update ReQuery Date");
                }
                else if (receiveddate.Text.Trim() == string.Empty && receivedtime.Text.Trim() != string.Empty)
                {
                    MessageBox.Show("Please update Received Date");
                }
                else if (receiveddate.Text.Trim() != string.Empty && receivedtime.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please update Received Time");
                }
                else if (approveddate.Text.Trim() == string.Empty && approvedtime.Text.Trim() != string.Empty)
                {
                    MessageBox.Show("Please update Apporved Date");
                }
                else if (approveddate.Text.Trim() != string.Empty && approvedtime.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please update Approved Time");
                }
                else if (querydate.Text.Trim() != string.Empty && querytime.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please update Query Time");
                }
                else if (querydate.Text.Trim() == string.Empty && querytime.Text.Trim() != string.Empty)
                {
                    MessageBox.Show("Please update Query Date");
                }
                else
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    string uploadmessage = cmd.Parameters["@Message"].Value.ToString();
                    MessageBox.Show("" + uploadmessage.ToString());
                    cmd.Parameters.Clear();
                    reset_overall();
                    conn.Close();
                }

            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details"  + ab.ToString());
            }

            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            try
            {
                cmd.Parameters.Clear();
                conn.ConnectionString = connectionstringtxt;
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "dbo.usp_cvt_update_daily_dotnet";
                cmd.Parameters.Add("@Message", SqlDbType.NVarChar, 1000);
                cmd.Parameters["@Message"].Direction = ParameterDirection.Output;
                cmd.Parameters.AddWithValue("@RequestID", requestid.Text);
                cmd.Parameters.AddWithValue("@ActivityType", activitytype.Text);
                cmd.Parameters.AddWithValue("@PartyName", partyname.Text);
                cmd.Parameters.AddWithValue("@ReceivedDate", receiveddate.Value.Date);
                cmd.Parameters.AddWithValue("@ReceivedTime", receivedtime.Value.ToLongTimeString());
                if (ubovalidationdate.Text.Trim() == string.Empty)
                {
                    cmd.Parameters.AddWithValue("@UBO_ValidationDate", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@UBO_ValidationDate", ubovalidationdate.Value.Date);
                }
                if (string.IsNullOrEmpty(requeryby.Text))
                {
                    cmd.Parameters.AddWithValue("@ReQueryBy", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ReQueryBy", requeryby.Text);
                }
                if (requerydate.Text.Trim() == string.Empty)
                {
                    cmd.Parameters.AddWithValue("@ReQueryDate", DBNull.Value);
                    cmd.Parameters.AddWithValue("@ReQueryTime", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ReQueryDate", requerydate.Value.Date);
                    cmd.Parameters.AddWithValue("@ReQueryTime", requerytime.Value.ToLongTimeString());
                }
                if (string.IsNullOrEmpty(bu.Text))
                {
                    cmd.Parameters.AddWithValue("@BU", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@BU", bu.Text);
                }
                if (string.IsNullOrEmpty(role.Text))
                {
                    cmd.Parameters.AddWithValue("@Role", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Role", role.Text);
                }
                if (string.IsNullOrEmpty(orgid.Text))
                {
                    cmd.Parameters.AddWithValue("@OrgID", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@OrgID", orgid.Text);
                }
                if (string.IsNullOrEmpty(orgstatus.Text))
                {
                    cmd.Parameters.AddWithValue("@OrgStatus", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@OrgStatus", orgstatus.Text);
                }
                if (string.IsNullOrEmpty(requestorsegmentname.Text))
                {
                    cmd.Parameters.AddWithValue("@RequestorSegmentName", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@RequestorSegmentName", requestorsegmentname.Text);
                }
                if (checkBox3.Checked)
                {
                    cmd.Parameters.AddWithValue("@QueryDate", querydate.Value.Date);
                    cmd.Parameters.AddWithValue("@QueryTime", querytime.Value.ToLongTimeString());
                    cmd.Parameters.AddWithValue("@QueryCategory", querycategory.Text);
                    cmd.Parameters.AddWithValue("@QueriedFor", queriedfor.Text);
                    cmd.Parameters.AddWithValue("@QueryRaisedBy",queryraisedby.Text);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@QueryDate", DBNull.Value);
                    cmd.Parameters.AddWithValue("@QueryTime", DBNull.Value);
                    cmd.Parameters.AddWithValue("@QueryCategory", DBNull.Value);
                    cmd.Parameters.AddWithValue("@QueriedFor", DBNull.Value);
                    cmd.Parameters.AddWithValue("@QueryRaisedBy", DBNull.Value);
                }
                if (checkBox4.Checked)
                {
                    cmd.Parameters.AddWithValue("@QueryResolvedDate", queryresolveddate.Value.Date);
                    cmd.Parameters.AddWithValue("@QueryResolvedTime", queryresolvedtime.Value.ToLongTimeString());
                    //cmd.Parameters.AddWithValue("@QueryResolvedBy", queryraisedby.Text);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@QueryResolvedDate", DBNull.Value);
                    cmd.Parameters.AddWithValue("@QueryResolvedTime", DBNull.Value);
                    //cmd.Parameters.AddWithValue("@QueryResolvedBy", DBNull.Value);
                }
                if (checkBox5.Checked)
                {
                    cmd.Parameters.AddWithValue("@ApprovedDate", approveddate.Value.Date);
                    cmd.Parameters.AddWithValue("@ApprovedTime", approvedtime.Value.ToLongTimeString());
                    cmd.Parameters.AddWithValue("@ApprovedBy", approvedby.Text);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ApprovedDate", DBNull.Value);
                    cmd.Parameters.AddWithValue("@ApprovedTime", DBNull.Value);
                    cmd.Parameters.AddWithValue("@ApprovedBy", DBNull.Value);
                }
                if (string.IsNullOrEmpty(requestoremailaddress.Text))
                {
                    cmd.Parameters.AddWithValue("@RequestorEmailAddress", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@RequestorEmailAddress", requestoremailaddress.Text);
                }
                if (string.IsNullOrEmpty(requestorlocation.Text))
                {
                    cmd.Parameters.AddWithValue("@RequestorLocation", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@RequestorLocation", requestorlocation.Text);
                }
                if (string.IsNullOrEmpty(comments.Text))
                {
                    cmd.Parameters.AddWithValue("@Comments", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Comments", comments.Text);
                }
                cmd.Parameters.AddWithValue("@LastUpdatedDateTime", DateTime.Now.ToLocalTime());
                cmd.Parameters.AddWithValue("@Volumes", volumes.Value);
                cmd.Parameters.AddWithValue("@LastUpdatedBy", Environment.UserName.ToString());
                cmd.Parameters.AddWithValue("@MachineName", Environment.MachineName.ToString());
                if (string.IsNullOrEmpty(legalentity.Text) && activitytype.Text == "CVT New Request")
                {
                    cmd.Parameters.AddWithValue("@LegalEntityName", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@LegalEntityName", legalentity.Text);
                }
                if (string.IsNullOrEmpty(plcrequestid.Text))
                {
                    cmd.Parameters.AddWithValue("@PLCRequestID", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@PLCRequestID", plcrequestid.Text);
                }
                if (string.IsNullOrEmpty(categories_qc.Text))
                {
                    cmd.Parameters.AddWithValue("@CategoriesQC", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@CategoriesQC", categories_qc.Text);
                }
                if (string.IsNullOrEmpty(subcategories_qc.Text))
                {
                    cmd.Parameters.AddWithValue("@SubCategoriesQC", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@SubCategoriesQC", subcategories_qc.Text);
                }
                if (string.IsNullOrEmpty(qcdoneby.Text))
                {
                    cmd.Parameters.AddWithValue("@QCDoneBy", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@QCDoneBy", qcdoneby.Text);
                }
                if (qcdate.Text.Trim() == string.Empty)
                {
                    cmd.Parameters.AddWithValue("@QCDate", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@QCDate", qcdate.Value.Date);
                }
                if (clientonboardingverificationcompletedate.Text.Trim() == string.Empty)
                {
                    cmd.Parameters.AddWithValue("@ClientOnboardingVerificationCompleteDate", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ClientOnboardingVerificationCompleteDate", clientonboardingverificationcompletedate.Value.Date);
                }
                if (clientinformationformsmsoexceptiondate.Text.Trim() == string.Empty)
                {
                    cmd.Parameters.AddWithValue("@ClientInformationFormSMSOExceptionDate", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ClientInformationFormSMSOExceptionDate", clientinformationformsmsoexceptiondate.Value.Date);
                }
                if (string.IsNullOrEmpty(clientonboardingformrequired.Text))
                {
                    cmd.Parameters.AddWithValue("@ClientOnboardingFormRequired", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ClientOnboardingFormRequired", clientonboardingformrequired.Text);
                }
                if (string.IsNullOrEmpty(ricopted.Text))
                {
                    cmd.Parameters.AddWithValue("@RICOpted", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@RICOpted", ricopted.Text);
                }
                

                if (string.IsNullOrEmpty(inflowprocessedby.Text))
                {
                    cmd.Parameters.AddWithValue("@InflowProcessedBy", DBNull.Value);
                    cmd.Parameters.AddWithValue("@InflowProcessedDate", DBNull.Value);
                    cmd.Parameters.AddWithValue("@InflowProcessedTime", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@InflowProcessedBy", inflowprocessedby.Text);
                    cmd.Parameters.AddWithValue("@InflowProcessedDate", inflowprocesseddate.Value.Date);
                    cmd.Parameters.AddWithValue("@InflowProcessedTime", inflowprocessedtime.Value.ToLongTimeString());
                }



                //If Conditions
                if (string.IsNullOrEmpty(activitytype.Text))
                {
                    MessageBox.Show("Please update Activity Type");
                }
                else if (clientonboardingformrequired.Text == "Yes" && ubovalidationdate.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please update UBO Validation Date");
                }
                else if (string.IsNullOrEmpty(partyname.Text))
                {
                    MessageBox.Show("Please update Party Name");
                }
                else if (string.IsNullOrEmpty(bu.Text) && activitytype.Text != "Account Assigning" && activitytype.Text != "Adhoc" && activitytype.Text != "Emails" && activitytype.Text != "ForDeletion" && activitytype.Text != "Market Security" && activitytype.Text != "Org Exception Report")
                {
                    MessageBox.Show("Please update BU Name");
                }
                else if (string.IsNullOrEmpty(role.Text) && activitytype.Text != "Account Assigning" && activitytype.Text != "Adhoc" && activitytype.Text != "Emails" && activitytype.Text != "ForDeletion" && activitytype.Text != "Market Security" && activitytype.Text != "Org Exception Report")
                {
                    MessageBox.Show("Please update Role");
                }
                else if (activitytype.Text == "BAU Project (Inflow)" && string.IsNullOrEmpty(orgid.Text) && inflowprocesseddate.Text.Trim() != string.Empty)
                {
                    MessageBox.Show("Please update Org ID");
                }
                else if (activitytype.Text == "Inflow" && string.IsNullOrEmpty(orgid.Text) && inflowprocesseddate.Text.Trim() != string.Empty)
                {
                    MessageBox.Show("Please update Org ID");
                }
                else if (activitytype.Text == "Reactivation" && string.IsNullOrEmpty(orgid.Text) && inflowprocesseddate.Text.Trim() != string.Empty)
                {
                    MessageBox.Show("Please update Org ID");
                }
                else if (activitytype.Text == "BAU Project (Inflow)" && string.IsNullOrEmpty(orgstatus.Text))
                {
                    MessageBox.Show("Please update Org Status");
                }
                else if (activitytype.Text == "Inflow" && string.IsNullOrEmpty(orgstatus.Text))
                {
                    MessageBox.Show("Please update Org Status");
                }
                else if (activitytype.Text == "Reactivation" && string.IsNullOrEmpty(orgstatus.Text))
                {
                    MessageBox.Show("Please update Org Status");
                }
                else if (checkBox3.Checked && string.IsNullOrEmpty(querycategory.Text))
                {
                    MessageBox.Show("Please update Query Category");
                }
                else if (checkBox3.Checked && string.IsNullOrEmpty(queriedfor.Text))
                {
                    MessageBox.Show("Please update Queried For");
                }
                else if (checkBox4.Checked && string.IsNullOrEmpty(queryraisedby.Text))
                {
                    MessageBox.Show("Please update Query Resolved By");
                }
                else if (checkBox5.Checked && string.IsNullOrEmpty(approvedby.Text))
                {
                    MessageBox.Show("Please update Approved By");
                }
                else if (receiveddate.Value.Date > todaydate.Value.Date)
                {
                    MessageBox.Show("Received date cannot be greater than Today's date");
                }
                else if (checkBox3.Checked && querydate.Value.Date > todaydate.Value.Date)
                {
                    MessageBox.Show("Query Date cannot be greater than Today's date");
                }
                else if (checkBox4.Checked && queryresolveddate.Value.Date > todaydate.Value.Date)
                {
                    MessageBox.Show("Query Resolved Date cannot be greater than Today's date");
                }
                else if (inflowprocesseddate.Value.Date > todaydate.Value.Date && inflowprocesseddate.Text.Trim() != string.Empty)
                {
                    MessageBox.Show("Inflow Processed Date cannot be greater than Today's date");
                }
                else if (checkBox5.Checked && approveddate.Value.Date > todaydate.Value.Date)
                {
                    MessageBox.Show("Approved Date cannot be greater than Today's date");
                }
                else if (checkBox5.Checked && receiveddate.Value.Date > approveddate.Value.Date)
                {
                    MessageBox.Show("Please check Received date and Approved date");
                }
                else if (checkBox3.Checked && checkBox4.Checked && querydate.Value.Date > queryresolveddate.Value.Date)
                {
                    MessageBox.Show("Please check Query date and Query Resolved date");
                }
                else if (checkBox3.Checked && checkBox5.Checked && querydate.Value.Date > approveddate.Value.Date)
                {
                    MessageBox.Show("Please check Query date and Approved date");
                }
                else if (checkBox4.Checked && checkBox5.Checked && queryresolveddate.Value.Date > approveddate.Value.Date)
                {
                    MessageBox.Show("Please check Query Resolved date and Approved date");
                }
                else if (string.IsNullOrEmpty(requestoremailaddress.Text) && activitytype.Text != "Account Assigning" && activitytype.Text != "Adhoc" && activitytype.Text != "Emails" && activitytype.Text != "ForDeletion" && activitytype.Text != "Market Security" && activitytype.Text != "Wolf Records" && activitytype.Text != "Org Exception Report")
                {
                    MessageBox.Show("Please update Requestor Email Address");
                }
                else if (string.IsNullOrEmpty(requestorlocation.Text) && activitytype.Text != "Account Assigning" && activitytype.Text != "Adhoc" && activitytype.Text != "Emails" && activitytype.Text != "ForDeletion" && activitytype.Text != "Market Security" && activitytype.Text != "Org Exception Report")
                {
                    MessageBox.Show("Please update Requestor Location");
                }
                else if (string.IsNullOrEmpty(requestorsegmentname.Text) && activitytype.Text != "Account Assigning" && activitytype.Text != "Adhoc" && activitytype.Text != "Emails" && activitytype.Text != "ForDeletion" && activitytype.Text != "Market Security" && activitytype.Text != "Org Exception Report")
                {
                    MessageBox.Show("Please update Requestor Segment Name");
                }
                else if (checkBox3.Checked && !checkBox4.Checked && checkBox5.Checked)
                {
                    MessageBox.Show("Please update Query Resolved Date");
                }
                else if (!checkBox3.Checked && checkBox4.Checked)
                {
                    MessageBox.Show("Please update Query Date");
                }
                else if (orgstatus.Text == "Approved" && !checkBox5.Checked)
                {
                    MessageBox.Show("Please update Approved Date as Org Status is marked as Approved");
                }
                else if (checkBox5.Checked && activitytype.Text == "CVT New Request" && orgstatus.Text != "Approved" && orgstatus.Text != "For Deletion")
                {
                    MessageBox.Show("Please check OrgStatus as OrgStatus should be Approved or For Deletion since the record is getting approved");
                }
                else if (orgid.Text != string.Empty && orgid.TextLength < 5)
                {
                    MessageBox.Show("OrgID cannot be less than 5 letters or numbers");
                }
                else if (string.IsNullOrEmpty(legalentity.Text) && activitytype.Text == "CVT New Request" && orgstatus.Text == "Pending CVT SPOE/Approval" && role.Text != "Insured - Standalone")
                {
                    MessageBox.Show("Please update Legal Entity Name");
                }
                else if (string.IsNullOrEmpty(legalentity.Text) && activitytype.Text == "CVT New Request" && orgstatus.Text == "Pending CVT SPOE/Approval" && role.Text != "Reinsured - Standalone")
                {
                    MessageBox.Show("Please update Legal Entity Name");
                }
                else if (qcdate.Value.Date > todaydate.Value.Date && qcdate.Text.Trim() != string.Empty)
                {
                    MessageBox.Show("QC date cannot be greater than Today's date");
                }
                else if (clientonboardingverificationcompletedate.Text.Trim() != string.Empty && clientonboardingverificationcompletedate.Value.Date > todaydate.Value.Date)
                {
                    MessageBox.Show("COF Verification Complete Date cannot be greater than today's date");
                }
                else if (clientinformationformsmsoexceptiondate.Text.Trim() != string.Empty && clientinformationformsmsoexceptiondate.Value.Date > todaydate.Value.Date)
                {
                    MessageBox.Show("COF SMSO Received Date cannot be more than today's date");
                }
                else if (clientonboardingverificationcompletedate.Text.Trim() != string.Empty && string.IsNullOrEmpty(legalentity.Text))
                {
                    MessageBox.Show("Please update Legal Entity Name");
                }
                else if (clientinformationformsmsoexceptiondate.Text.Trim() != string.Empty && string.IsNullOrEmpty(legalentity.Text))
                {
                    MessageBox.Show("Please update Legal Entity Name");
                }
                else if (!string.IsNullOrEmpty(legalentity.Text) && string.IsNullOrEmpty(clientonboardingformrequired.Text) && legalentity.Text == "Willis Limited")
                {
                    MessageBox.Show("Please update Client Onboarding Form Required");
                }
                else if (!string.IsNullOrEmpty(legalentity.Text) && string.IsNullOrEmpty(clientonboardingformrequired.Text) && legalentity.Text == "Willis Towers Watson SA NV")
                {
                    MessageBox.Show("Please update Client Onboarding Form Required");
                }
                else if (!string.IsNullOrEmpty(legalentity.Text) && string.IsNullOrEmpty(clientonboardingformrequired.Text) && legalentity.Text == "Willis Non-IBA")
                {
                    MessageBox.Show("Please update Client Onboarding Form Required");
                }
                else if (!string.IsNullOrEmpty(clientonboardingformrequired.Text) && (clientinformationformsmsoexceptiondate.Text.Trim() == string.Empty && clientonboardingverificationcompletedate.Text.Trim() == string.Empty) && clientonboardingformrequired.Text == "Yes")
                {
                    MessageBox.Show("Please update COF SMSO Received Date or COF Verification Complete Date");
                }
                else if (clientonboardingverificationcompletedate.Text.Trim() != string.Empty && string.IsNullOrEmpty(ricopted.Text))
                {
                    MessageBox.Show("Please update RIC Opted");
                }
                //else if (activitytype.Text == "CVT New Request" && !string.IsNullOrEmpty(queryraisedby.Text) && !string.IsNullOrEmpty(approvedby.Text) && queryraisedby.Text == approvedby.Text)
                //{
                //    MessageBox.Show("Query Resolved By and Approved By should not be the same person");
                //}
                //else if (activitytype.Text == "Reactivation" && !string.IsNullOrEmpty(queryraisedby.Text) && !string.IsNullOrEmpty(approvedby.Text) && queryraisedby.Text == approvedby.Text)
                //{
                //    MessageBox.Show("Query Resolved By and Approved By should not be the same person");
                //}
                //else if (activitytype.Text == "BAU Project" && !string.IsNullOrEmpty(queryraisedby.Text) && !string.IsNullOrEmpty(approvedby.Text) && queryraisedby.Text == approvedby.Text)
                //{
                //    MessageBox.Show("Query Resolved By and Approved By should not be the same person");
                //}
                //else if (activitytype.Text == "Adhoc Project" && !string.IsNullOrEmpty(queryraisedby.Text) && !string.IsNullOrEmpty(approvedby.Text) && queryraisedby.Text == approvedby.Text)
                //{
                //    MessageBox.Show("Query Resolved By and Approved By should not be the same person");
                //}
                else if (!string.IsNullOrEmpty(orgstatus.Text) && orgstatus.Text == "Pending CVT SPOE/Approval" && string.IsNullOrEmpty(plcrequestid.Text))
                {
                    MessageBox.Show("Please update PLC Request ID");
                }
                else if (approveddate.Text.Trim() != string.Empty && checkBox5.Checked == true && orgstatus.Text != "Approved" && (role.Text != "Client Delegate" || role.Text != "Instructing Party" || role.Text != "Insured - Standalone" || role.Text != "Reinsured - Standalone"))
                {
                    MessageBox.Show("Org Status should be approved");
                }
                else if (approveddate.Text.Trim() == string.Empty && checkBox5.Checked == false && orgstatus.Text == "Approved" && (role.Text != "Client Delegate" || role.Text != "Instructing Party" || role.Text != "Insured - Standalone" || role.Text != "Reinsured - Standalone"))
                {
                    MessageBox.Show("Please update Approved Date");
                }
                else if (string.IsNullOrEmpty(requeryby.Text) && requerydate.Text.Trim() != string.Empty)
                {
                    MessageBox.Show("Please update Requery By");
                }
                else if (!string.IsNullOrEmpty(requeryby.Text) && requerydate.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please update Requery Date");
                }
                else if (requerydate.Text.Trim() != string.Empty && requerytime.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please update ReQuery Time");
                }
                else if (requerydate.Text.Trim() == string.Empty && requerytime.Text.Trim() != string.Empty)
                {
                    MessageBox.Show("Please update ReQuery Date");
                }
                else if (receiveddate.Text.Trim() == string.Empty && receivedtime.Text.Trim() != string.Empty)
                {
                    MessageBox.Show("Please update Received Date");
                }
                else if (receiveddate.Text.Trim() != string.Empty && receivedtime.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please update Received Time");
                }
                else if (approveddate.Text.Trim() == string.Empty && approvedtime.Text.Trim() != string.Empty)
                {
                    MessageBox.Show("Please update Apporved Date");
                }
                else if (approveddate.Text.Trim() != string.Empty && approvedtime.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please update Approved Time");
                }
                else if (querydate.Text.Trim() != string.Empty && querytime.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please update Query Time");
                }
                else if (querydate.Text.Trim() == string.Empty && querytime.Text.Trim() != string.Empty)
                {
                    MessageBox.Show("Please update Query Date");
                }
                else
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    string uploadmessage = cmd.Parameters["@Message"].Value.ToString();
                    MessageBox.Show("" + uploadmessage.ToString());
                    cmd.Parameters.Clear();
                    reset_overall();
                    conn.Close();
                }

            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details" + ab.ToString());
            }

            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel Documents (*.xls)|*.xls";
                sfd.FileName = "export.xls";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    //ToCsV(dataGridView1, @"c:\export.xls");
                    ToCsV(dataGridView1, sfd.FileName); // Here dataGridview1 is your grid view name
                }
                MessageBox.Show("Export completed successfully");
            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details:" + ab.ToString());
            }
        }

        private void bu_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (bu.SelectedIndex != 1)
            //{
            //    revisedbu_automatic();
            //}
            revisedbu_list();
            //revisedbu_automatic();
        }

        private void bu_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //if (bu.SelectedValue.ToString() != "0")
            //{
            //    revisedbu_automatic();
            //}
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                linkLabel1.LinkVisited = true;
                System.Diagnostics.Process.Start("http://A20-CB-DBSE01P/Reports/report/DRD%20MI%20Mumbai/DRD%20Reports/rpt_SSRS_CVT_RawData_DotNet");
            }
            catch (Exception ab)
            {
                MessageBox.Show("Unable to open link that was clicked. Following are the error generated details" + ab.ToString());
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                linkLabel1.LinkVisited = true;
                System.Diagnostics.Process.Start("http://A20-CB-DBSE01P/Reports/report/DRD%20MI%20Mumbai/DRD%20Reports/rpt_SSRS_CVT_TATDaily_DotNet");
            }
            catch (Exception ab)
            {
                MessageBox.Show("Unable to open link that was clicked. Following are the error generated details" + ab.ToString());
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            datagridview_display_overall();
            //cvt_bau_pending();
            //cvt_overall_completed();
        }

        
        private void searchbyorginflow_TextChanged(object sender, EventArgs e)
        {
            datagridview_display_overall();
        }

        
       
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void requestorsegmentname_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void comments_TextChanged(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void requestorlocation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void requestoremailaddress_TextChanged(object sender, EventArgs e)
        {
            if (datagridview_click.Enabled == false)
            {
                autopopulate_segment();
                autopopulate_requestorlocation();
                autopopulate_businessunit();
            }
            else
            {
                //bu_list();
                //segmentname_list();
                //requestorlocation_list();
            }
            //if (string.IsNullOrEmpty(requestoremailaddress.Text))
            //{
            //    requestorlocation.SelectedIndex = -1;
            //    requestorsegmentname.SelectedIndex = -1;
            //}
        }


        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void approveddate_ValueChanged(object sender, EventArgs e)
        {
            approveddate.CustomFormat = "dd-MMMM-yyyy";
        }

        private void approvedtime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void approvedby_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void queryresolvedby_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void queryresolvedtime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void queryresolveddate_ValueChanged(object sender, EventArgs e)
        {
            queryresolveddate.CustomFormat = "dd-MMMM-yyyy";
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void querydate_ValueChanged(object sender, EventArgs e)
        {
            querydate.CustomFormat = "dd-MMMM-yyyy";
        }

        private void querytime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void queriedfor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void querycategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (checkBox3.Checked && querycategory.Text != string.Empty && querycategory.Text == "Offshore Country – Insufficient documents provided")
            //{
            //    queriedfor.Text = "Creation Discrepancies";
            //}
            if (!string.IsNullOrEmpty(querycategory.Text))
            {
                autopopulate_queriedfor_list();
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void firstcheckcompleteddate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void firstcheckcompletedtime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void volumes_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }


        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void kyccompleteddate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void kyccompletedtime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void role_SelectedIndexChanged(object sender, EventArgs e)
        {
            hideunhide_approveddates();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void orgid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void orgstatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string messsage = "Do you want to update the record?";
            string title = "Message Box";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(messsage, title, buttons);
            if (result == DialogResult.Yes)
            {
                
                datagridview_click.Enabled = true;
                bu_list();
                segmentname_list();
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                    requestid.Text = row.Cells["txtRequestId"].Value.ToString();
                    //activitytype_list();
                    activitytype.Text = row.Cells["txtActivityType"].Value.ToString();
                    partyname.Text = row.Cells["txtPartyName"].Value.ToString();
                    receiveddate.Text = row.Cells["txtReceivedDate"].Value.ToString();
                    receiveddate.CustomFormat = "dd-MMMM-yyyy";
                    receivedtime.Text = row.Cells["txtReceivedTime"].Value.ToString();
                    receivedtime.CustomFormat = "HH:mm:ss";
                    if (string.IsNullOrEmpty(row.Cells["txtUBO_ValidationDate"].Value.ToString()))
                    {
                        ubovalidationdate.CustomFormat = " ";
                    }
                    else
                    {
                        ubovalidationdate.Text = row.Cells["txtUBO_ValidationDate"].Value.ToString();
                        ubovalidationdate.CustomFormat = "dd-MMMM-yyyy";
                    }
                    if (string.IsNullOrEmpty(row.Cells["txtReQueryBy"].Value.ToString()))
                    {
                        requeryby.SelectedIndex = -1;
                        requerydate.CustomFormat = " ";
                        requerytime.CustomFormat = " ";
                    }
                    else
                    {
                        requeryby.Text = row.Cells["txtReQueryBy"].Value.ToString();
                        requerydate.Text = row.Cells["txtRequeryDate"].Value.ToString();
                        requerydate.CustomFormat = "dd-MMMM-yyyy";
                        requerytime.Text = row.Cells["txtRequeryTime"].Value.ToString();
                        requerytime.CustomFormat = "HH:mm:ss";
                    }
                    
                    if (string.IsNullOrEmpty(row.Cells["txtClientOnboardingVerificationCompleteDate"].Value.ToString()))
                    {
                        clientonboardingverificationcompletedate.CustomFormat = " ";
                    }
                    else
                    {
                        clientonboardingverificationcompletedate.Text = row.Cells["txtClientOnboardingVerificationCompleteDate"].Value.ToString();
                        clientonboardingverificationcompletedate.CustomFormat = "dd-MMMM-yyyy";
                    }
                    if (string.IsNullOrEmpty(row.Cells["txtClientInformationFormSMSOExceptionDate"].Value.ToString()))
                    {
                        clientinformationformsmsoexceptiondate.CustomFormat = " ";
                    }
                    else
                    {
                        clientinformationformsmsoexceptiondate.Text = row.Cells["txtClientInformationFormSMSOExceptionDate"].Value.ToString();
                        clientinformationformsmsoexceptiondate.CustomFormat = "dd-MMMM-yyyy";
                    }
                    
                    if (string.IsNullOrEmpty(row.Cells["txtBU"].Value.ToString()))
                    {
                        bu.SelectedIndex = -1;
                    }
                    else
                    {
                        //bu_list();
                        bu.Text = row.Cells["txtBU"].Value.ToString();
                    }
                    
                    if (string.IsNullOrEmpty(row.Cells["txtRole"].Value.ToString()))
                    {
                        role.SelectedIndex = -1;
                    }
                    else
                    {
                        
                        role.Text = row.Cells["txtRole"].Value.ToString();
                    }
                    if (string.IsNullOrEmpty(row.Cells["txtOrgID"].Value.ToString()))
                    {
                        orgid.Text = string.Empty;
                    }
                    else
                    {
                        orgid.Text = row.Cells["txtOrgID"].Value.ToString();
                    }
                    if (string.IsNullOrEmpty(row.Cells["txtOrgStatus"].Value.ToString()))
                    {
                        orgstatus.SelectedIndex = -1;
                    }
                    else
                    {
                        
                        orgstatus.Text = row.Cells["txtOrgStatus"].Value.ToString();
                    }
                    
                    if (string.IsNullOrEmpty(row.Cells["txtRequestorSegmentName"].Value.ToString()))
                    {
                        requestorsegmentname.SelectedIndex = -1;
                    }
                    else
                    {

                        requestorsegmentname.Text = row.Cells["txtRequestorSegmentName"].Value.ToString();
                    }
                    if (string.IsNullOrEmpty(row.Cells["txtQueryDate"].Value.ToString()))
                    {
                        checkBox3.Checked = false;
                    }
                    else
                    {
                        checkBox3.Checked = true;
                        querydate.Text = row.Cells["txtQueryDate"].Value.ToString();
                        querydate.CustomFormat = "dd-MMMM-yyyy";
                        querytime.Text = row.Cells["txtQueryTime"].Value.ToString();
                        querytime.CustomFormat = "HH:mm:ss";
                        querycategory.Text = row.Cells["txtQueryCategory"].Value.ToString();
                        queriedfor.Text = row.Cells["txtQueriedFor"].Value.ToString();
                        queryraisedby.Text = row.Cells["txtQueryRaisedBy"].Value.ToString();
                    }
                    if (string.IsNullOrEmpty(row.Cells["txtQueryResolvedDate"].Value.ToString()))
                    {
                        checkBox4.Checked = false;
                    }
                    else
                    {
                        checkBox4.Checked = true;
                        queryresolveddate.Text = row.Cells["txtQueryResolvedDate"].Value.ToString();
                        queryresolveddate.CustomFormat = "dd-MMMM-yyyy";
                        queryresolvedtime.Text = row.Cells["txtQueryResolvedTime"].Value.ToString();
                        queryresolvedtime.CustomFormat = "HH:mm:ss";
                        
                    }
                    if (string.IsNullOrEmpty(row.Cells["txtApprovedDate"].Value.ToString()))
                    {
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        checkBox5.Checked = true;
                        approveddate.Text = row.Cells["txtApprovedDate"].Value.ToString();
                        approveddate.CustomFormat = "dd-MMMM-yyyy";
                        approvedtime.Text = row.Cells["txtApprovedTime"].Value.ToString();
                        approvedtime.CustomFormat = "HH:mm:ss";
                        approvedby.Text = row.Cells["txtApprovedBy"].Value.ToString();
                    }
                    
                    if (string.IsNullOrEmpty(row.Cells["txtRequestorEmailAddress"].Value.ToString()))
                    {
                        requestoremailaddress.Text = string.Empty;
                    }
                    else
                    {
                        requestoremailaddress.Text = row.Cells["txtRequestorEmailAddress"].Value.ToString();
                    }
                    if (string.IsNullOrEmpty(row.Cells["txtRequestorLocation"].Value.ToString()))
                    {
                        requestorlocation.SelectedIndex = -1;
                    }
                    else
                    {

                        requestorlocation.Text = row.Cells["txtRequestorLocation"].Value.ToString();
                    }
                    if (string.IsNullOrEmpty(row.Cells["txtComments"].Value.ToString()))
                    {
                        comments.Text = string.Empty;
                    }
                    else
                    {
                        comments.Text = row.Cells["txtComments"].Value.ToString();
                    }
                    volumes.Value = Convert.ToInt32(row.Cells["txtVolumes"].Value);
                    
                    if (string.IsNullOrEmpty(row.Cells["txtLegalEntityName"].Value.ToString()))
                    {
                        legalentity.SelectedIndex = -1;
                    }
                    else
                    {
                        //legalentityname_list();
                        legalentity.Text = row.Cells["txtLegalEntityName"].Value.ToString();
                    }
                    if (string.IsNullOrEmpty(row.Cells["txtPLCRequestID"].Value.ToString()))
                    {
                        plcrequestid.Text = string.Empty;
                    }
                    else
                    {
                        plcrequestid.Text = row.Cells["txtPLCRequestID"].Value.ToString();
                    }
                    //if (string.IsNullOrEmpty(row.Cells["txtSMSOQuerySentDate"].Value.ToString()))
                    //{
                    //    smsoquerysentdate.CustomFormat = " ";
                    //}
                    //else
                    //{
                    //    smsoquerysentdate.Text = row.Cells["txtSMSOQuerySentDate"].Value.ToString();
                    //    smsoquerysentdate.CustomFormat = "dd-MMMM-yyyy";
                    //}
                    //
                    if (string.IsNullOrEmpty(row.Cells["txtCategories_QC"].Value.ToString()))
                    {
                        categories_qc.SelectedIndex = -1;
                    }
                    else
                    {
                        categories_qc.Text = row.Cells["txtCategories_QC"].Value.ToString();
                    }
                    if (string.IsNullOrEmpty(row.Cells["txtSubCategories_QC"].Value.ToString()))
                    {
                        subcategories_qc.SelectedIndex = -1;
                    }
                    else
                    {
                        subcategories_qc.Text = row.Cells["txtSubCategories_QC"].Value.ToString();
                    }
                    if (string.IsNullOrEmpty(row.Cells["txtQCDoneBy"].Value.ToString()))
                    {
                        qcdoneby.SelectedIndex = -1;
                    }
                    else
                    {
                        qcdoneby.Text = row.Cells["txtQCDoneBy"].Value.ToString();
                    }
                    if (string.IsNullOrEmpty(row.Cells["txtQCDate"].Value.ToString()))
                    {
                        qcdate.CustomFormat = " ";
                    }
                    else
                    {

                        qcdate.Text = row.Cells["txtQCDate"].Value.ToString();
                        qcdate.CustomFormat = "dd-MMMM-yyyy";
                    }
                    //if (string.IsNullOrEmpty(row.Cells["txtPartyAddress"].Value.ToString()))
                    //{
                    //    partyaddress.Text = string.Empty;
                    //}
                    //else
                    //{
                    //    partyaddress.Text = row.Cells["txtPartyAddress"].Value.ToString();
                    //}
                    if (string.IsNullOrEmpty(row.Cells["txtClientOnboardingFormRequired"].Value.ToString()))
                    {
                        clientonboardingformrequired.SelectedIndex = -1;
                    }
                    else
                    {
                        clientonboardingformrequired.Text = row.Cells["txtClientOnboardingFormRequired"].Value.ToString();
                    }
                    if (string.IsNullOrEmpty(row.Cells["txtRICOpted"].Value.ToString()))
                    {
                        ricopted.SelectedIndex = -1;
                    }
                    else
                    {
                        ricopted.Text = row.Cells["txtRICOpted"].Value.ToString();
                    }
                    if (string.IsNullOrEmpty(row.Cells["txtRequestorEmailAddress"].Value.ToString()))
                    {
                        requestoremailaddress.Text = string.Empty;
                    }
                    else
                    {
                        requestoremailaddress.Text = row.Cells["txtRequestorEmailAddress"].Value.ToString();
                    }
                    if (string.IsNullOrEmpty(row.Cells["txtRequestorLocation"].Value.ToString()))
                    {
                        requestorlocation.SelectedIndex = -1;
                    }
                    else
                    {
                        requestorlocation.Text = row.Cells["txtRequestorLocation"].Value.ToString();
                    }
                    
                    if (string.IsNullOrEmpty(row.Cells["txtInflowProcessedBy"].Value.ToString()))
                    {
                        inflowprocessedby.SelectedIndex = -1;
                    }
                    else
                    {
                        inflowprocessedby.Text = row.Cells["txtInflowProcessedBy"].Value.ToString();
                    }
                    if (string.IsNullOrEmpty(row.Cells["txtInflowProcessedDate"].Value.ToString()))
                    {
                        inflowprocesseddate.CustomFormat = " ";
                        inflowprocessedtime.CustomFormat = " ";
                    }
                    else
                    {
                        inflowprocesseddate.Text = row.Cells["txtInflowProcessedDate"].Value.ToString();
                        inflowprocesseddate.CustomFormat = "dd-MMMM-yyyy";
                        inflowprocessedtime.Text = row.Cells["txtInflowProcessedTime"].Value.ToString();
                        inflowprocessedtime.CustomFormat = "HH:mm:ss";
                    }
                    //
                    if (activitytype.Text == "CVT New Request" && role.Text == "Client")
                    {
                        insert.Enabled = true;
                        update.Enabled = true;
                    }
                    //else if (activitytype.Text == "Org Creation" && role.Text.Equals("Client",StringComparison.CurrentCultureIgnoreCase))
                    else if (activitytype.Text == "Org Creation" && role.Text == "Client")
                    {
                        insert.Enabled = true;
                        update.Enabled = true;
                    }
                    else if (activitytype.Text == "Reactivation" && role.Text == "Client")
                    {
                        insert.Enabled = true;
                        update.Enabled = true;
                    }
                    else
                    {
                        if (activitytype.Text == "BAU Project (Inflow)")
                        {
                            insert.Enabled = true;
                        }
                        else if (activitytype.Text == "BAU Project (Org Creation and Inflow)")
                        {
                            insert.Enabled = true;
                        }
                        else if (activitytype.Text == "Inflow")
                        {
                            insert.Enabled = true;
                        }
                        else if (activitytype.Text == "Org Creation & Inflow")
                        {
                            insert.Enabled = true;
                        }
                        else
                        {
                            insert.Enabled = false;
                        }
                        update.Enabled = true;
                    }
                    
                }
            }
            else
            {
                requestid.Focus();
                datagridview_click.Enabled = false;
            }
        }

        private void activitytype_DropDown(object sender, EventArgs e)
        {
            //activitytype_list();
        }

        private void processedby_DropDown(object sender, EventArgs e)
        {
            //processedby_list();
        }

        private void bu_DropDown(object sender, EventArgs e)
        {
            //bu_list();
        }

        private void role_DropDown(object sender, EventArgs e)
        {
            //role_list();
        }

        private void orgstatus_DropDown(object sender, EventArgs e)
        {
            //orgstatus_list();
        }

        private void partylocation_DropDown(object sender, EventArgs e)
        {
            //partylocation_list();
        }

        private void querycategory_DropDown(object sender, EventArgs e)
        {
            //querycategory_list();
            
        }

        private void queriedfor_DropDown(object sender, EventArgs e)
        {
            //queriedfor_list();
        }

        private void queryresolvedby_DropDown(object sender, EventArgs e)
        {
            //queryresolvedby_list();
        }

        private void approvedby_DropDown(object sender, EventArgs e)
        {
            //approvedby_list();
        }

        private void escalationhandledby_DropDown(object sender, EventArgs e)
        {
            //escalationhandledby_list();
        }

        private void orgcreatedby_DropDown(object sender, EventArgs e)
        {
            //orgcreatedby_list();
        }

        private void revisedbu_DropDown(object sender, EventArgs e)
        {
            //revisedbu_list();
        }

        private void legalentity_DropDown(object sender, EventArgs e)
        {
            //legalentityname_list();
        }

        private void projectnonproject_DropDown(object sender, EventArgs e)
        {
            //projectnonproject_list();
        }

        private void legalentity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Space || e.KeyCode == Keys.Back)
            {
                legalentity.SelectedIndex = -1;
            }
        }

        private void insert_MouseLeave(object sender, EventArgs e)
        {
        
        }

        private void qcdate_ValueChanged(object sender, EventArgs e)
        {
            qcdate.CustomFormat = "dd-MMMM-yyyy";
        }

        private void qcdate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Space || e.KeyCode == Keys.Back)
            {
                qcdate.CustomFormat = " ";
            }
        }

        private void categories_qc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Space || e.KeyCode == Keys.Back)
            {
                categories_qc.SelectedIndex = -1;
            }
        }

        private void subcategories_qc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Space || e.KeyCode == Keys.Back)
            {
                subcategories_qc.SelectedIndex = -1;
            }
        }

        private void qcdoneby_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Space || e.KeyCode == Keys.Back)
            {
                qcdoneby.SelectedIndex = -1;
            }
        }

        private void clientonboardingverificationcompletedate_ValueChanged(object sender, EventArgs e)
        {
            clientonboardingverificationcompletedate.CustomFormat = "dd-MMMM-yyyy";
            ricopted.Enabled = true;
        }

        private void clientonboardingverificationcompletedate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Space || e.KeyCode == Keys.Back)
            {
                clientonboardingverificationcompletedate.CustomFormat = " ";
            }
            ricopted.Enabled = false;
            ricopted.SelectedIndex = -1;
        }

        private void clientinformationformsmsoexceptiondate_ValueChanged(object sender, EventArgs e)
        {
            clientinformationformsmsoexceptiondate.CustomFormat = "dd-MMMM-yyyy";
        }

        private void clientinformationformsmsoexceptiondate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Space || e.KeyCode == Keys.Back)
            {
                clientinformationformsmsoexceptiondate.CustomFormat = " ";
            }
        }

        private void legalentity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (legalentity.Text != "Willis Limited" && legalentity.Text != "Willis Towers Watson SA NV")
            {
                clientinformationformsmsoexceptiondate.Enabled = false;
                clientonboardingverificationcompletedate.Enabled = false;
            }
            else
            {
                clientinformationformsmsoexceptiondate.Enabled = true;
                clientonboardingverificationcompletedate.Enabled = true;
            }
        }

        private void clientonboardingformrequired_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Space || e.KeyCode == Keys.Back)
            {
                clientonboardingformrequired.SelectedIndex = -1;
            }
        }

        private void inflowprocesseddate_ValueChanged(object sender, EventArgs e)
        {
            inflowprocesseddate.CustomFormat = "dd-MMMM-yyyy";
        }

        private void inflowprocesseddate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Space || e.KeyCode == Keys.Back)
            {
                inflowprocesseddate.CustomFormat = " ";
            }
        }

        private void inflowprocessedtime_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Space || e.KeyCode == Keys.Back)
            {
                inflowprocessedtime.CustomFormat = " ";
            }
        }

        private void inflowprocessedtime_MouseDown(object sender, MouseEventArgs e)
        {
            inflowprocessedtime.Text = DateTime.Now.ToLongTimeString();
            inflowprocessedtime.CustomFormat = "HH:mm:ss";
        }

        private void receiveddate_ValueChanged(object sender, EventArgs e)
        {
            receiveddate.CustomFormat = "dd-MMMM-yyyy";
        }

        private void receiveddate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Space || e.KeyCode == Keys.Back)
            {
                receiveddate.CustomFormat = " ";
            }
        }

        private void receivedtime_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Space || e.KeyCode == Keys.Back)
            {
                receivedtime.CustomFormat = " ";
            }
        }

        private void receivedtime_MouseDown(object sender, MouseEventArgs e)
        {
            receivedtime.Text = DateTime.Now.ToLongTimeString();
            receivedtime.CustomFormat = "HH:mm:ss";
        }

        private void querydate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Space || e.KeyCode == Keys.Back)
            {
                querydate.CustomFormat = " ";
            }
        }

        private void querytime_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Space || e.KeyCode == Keys.Back)
            {
                querytime.CustomFormat = " ";
            }
        }

        private void querytime_MouseDown(object sender, MouseEventArgs e)
        {
            querytime.Text = DateTime.Now.ToLongTimeString();
            querytime.CustomFormat = "HH:mm:ss";
        }

        private void queryresolveddate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Space || e.KeyCode == Keys.Back)
            {
                queryresolveddate.CustomFormat = " ";
            }
        }

        private void queryresolvedtime_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Space || e.KeyCode == Keys.Back)
            {
                queryresolvedtime.CustomFormat = " ";
            }
        }

        private void queryresolvedtime_MouseDown(object sender, MouseEventArgs e)
        {
            queryresolvedtime.Text = DateTime.Now.ToLongTimeString();
            queryresolvedtime.CustomFormat = "HH:mm:ss";
        }

        private void approveddate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Space || e.KeyCode == Keys.Back)
            {
                approveddate.CustomFormat = " ";
            }
        }

        private void approvedtime_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Space || e.KeyCode == Keys.Back)
            {
                approvedtime.CustomFormat = " ";
            }
        }

        private void approvedtime_MouseDown(object sender, MouseEventArgs e)
        {
            approvedtime.Text = DateTime.Now.ToLongTimeString();
            approvedtime.CustomFormat = "HH:mm:ss";
        }

        private void searchbyactivitytype_SelectedIndexChanged(object sender, EventArgs e)
        {
            datagridview_display_overall();
        }

        private void searchbyrequeststatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            datagridview_display_overall();
        }

        private void activitytype_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void searchbyactivitytype_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Space || e.KeyCode == Keys.Back)
            {
                searchbyactivitytype.SelectedIndex = -1;
            }
        }

        private void searchbyrequeststatus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Space || e.KeyCode == Keys.Back)
            {
                searchbyrequeststatus.SelectedIndex = -1;
            }
        }

        private void activitytype_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (activitytype.Text == "Org Creation & Inflow")
            //{
            //    orgcreatedby.Enabled = true;
            //    orgcreatedby.SelectedIndex = -1;
            //}
            //else if (activitytype.Text == "BAU Project (Org Creation and Inflow)")
            //{
            //    orgcreatedby.Enabled = true;
            //    orgcreatedby.SelectedIndex = -1;
            //}
            //else if (activitytype.Text == "Adhoc Project (Org Creation and Inflow)")
            //{
            //    orgcreatedby.Enabled = true;
            //    orgcreatedby.SelectedIndex = -1;
            //}
            //else
            //{
            //    orgcreatedby.Enabled = false;
            //}

            if (activitytype.Text == "Emails")
            {
                hide_columns();
            }
            else if (activitytype.Text == "ForDeletion")
            {
                hide_columns();
            }
            else if (activitytype.Text == "Market Security")
            {
                hide_columns();
            }
            else if (activitytype.Text == "Org Exception Report")
            {
                hide_columns();
            }
            else if (activitytype.Text == "Wolf Records")
            {
                hide_columns();
            }
            else
            {
                unhide_columns();
            }
        }

        private void searchbypartyname_TextChanged(object sender, EventArgs e)
        {
            datagridview_display_overall();
        }

        private void inflowprocessedby_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Space || e.KeyCode == Keys.Back)
            {
                inflowprocessedby.SelectedIndex = -1;
            }
        }

       

       

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow myrow in dataGridView1.Rows)
            {
                if (myrow.Cells["txtTATMissCases"].Value.ToString() == "True")
                {
                    myrow.DefaultCellStyle.BackColor = Color.OrangeRed;
                    //myrow.DefaultCellStyle.ForeColor = Color.White;
                }
            }
        }

        private void label_cofverificationcompletedate_Click(object sender, EventArgs e)
        {

        }

        private void requerydate_ValueChanged(object sender, EventArgs e)
        {
            requerydate.CustomFormat = "dd-MMMM-yyyy";
        }

        private void requerydate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Space || e.KeyCode == Keys.Back)
            {
                requerydate.CustomFormat = " ";
            }
        }

        private void requerytime_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Space || e.KeyCode == Keys.Back)
            {
                requerytime.CustomFormat = " ";
            }
        }

        private void requerytime_MouseDown(object sender, MouseEventArgs e)
        {
            requerytime.Text = DateTime.Now.ToLongTimeString();
            requerytime.CustomFormat = "HH:mm:ss";
        }

        private void subcategories_qc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void requeryby_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Space || e.KeyCode == Keys.Back)
            {
                requeryby.SelectedIndex = -1;
            }
        }

        private void ubovalidationdate_ValueChanged(object sender, EventArgs e)
        {
            ubovalidationdate.CustomFormat = "dd-MMMM-yyyy";
        }

        private void ubovalidationdate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Space || e.KeyCode == Keys.Back)
            {
                ubovalidationdate.CustomFormat = " ";
            }
        }

        private void clientonboardingformrequired_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clientonboardingformrequired.Text == "Yes")
            {
                ubovalidationdate.Enabled = true;
            }
            else
            {
                ubovalidationdate.Enabled = false;
            }
        }

        private void mainpage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_Page obj_mainpage = new Main_Page();
            obj_mainpage.Show();
        }

        

     
 
    }
}
