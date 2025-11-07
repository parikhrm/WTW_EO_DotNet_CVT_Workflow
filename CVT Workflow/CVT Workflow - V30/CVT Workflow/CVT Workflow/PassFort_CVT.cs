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
    public partial class PassFort_CVT : Form
    {
        public string connectionstringtxt = "Data Source=A20-CB-DBSE01P;Initial Catalog=DRD;User ID=DRDUsers;Password=24252425";
        //public string connectionstringtxt = ConfigurationManager.ConnectionStrings["KYC_RDC_Workflow.Properties.Settings.DRDConnectionString"].ConnectionString;
        //string connectionstringtxt = System.Configuration.ConfigurationManager.ConnectionStrings["connection_string"].ConnectionString;
        SqlCommand cmd = new SqlCommand();
        SqlConnection conn = new SqlConnection();

        public PassFort_CVT()
        {
            InitializeComponent();
        }

        private void PassFort_CVT_Load(object sender, EventArgs e)
        {
            legalentityname_list();
            role_list();
            orgstatus_list();
            categories_qc_list();
            subcategories_qc_list();
            empdetails_list();
            approvedby_list();
            requestorlocation_list();
            activitytype_list();
            queryraisedby_list();
            query_category_list();
            reset_overall();
        }

        public void reset_overall()
        {
            current_datetime.Text = DateTime.Now.ToLongDateString();
            current_datetime.Visible = false;
            //insert.Enabled = true;
            //update.Enabled = false;
            requestid.Enabled = false;
            requestid.Text = string.Empty;
            partyname.Text = string.Empty;
            activity_type.SelectedIndex= -1;
            received_date.CustomFormat = " ";
            requestor_email_address.Text = string.Empty;
            legal_entity_name.SelectedIndex = -1;
            role.SelectedIndex = -1;
            orgid.Text = string.Empty;
            org_status.SelectedIndex = -1;
            inflow_processed_by.SelectedIndex = -1;
            inflow_processed_date.CustomFormat = " ";
            ubo_validated_by.SelectedIndex = -1;
            ubo_validation_date.CustomFormat = " ";
            query_raised_date.CustomFormat = " ";
            //query_raised_date.Enabled = false;
            requery_raised_date.CustomFormat = " ";
            //requery_raised_date.Enabled = false;
            query_category.SelectedIndex = -1;
            query_category_requery.SelectedIndex = -1;
            //query_category.Enabled = false;
            queried_for.SelectedIndex = -1;
            queried_for_requery.SelectedIndex = -1;
            //queried_for.Enabled = false;
            query_raised_by.SelectedIndex = -1;
            requery_raised_by.SelectedIndex = -1;
            //query_raised_by.Enabled = false;
            query_resolved_date.CustomFormat = " ";
            volumes.Text = string.Empty;
            approved_date.CustomFormat = " ";
            approved_by.SelectedIndex = -1;
            pf_risk_category.SelectedIndex = -1;
            other_parties.SelectedIndex = -1;
            gcid_in_ecs_status.SelectedIndex = -1;
            fca_updated_in_eclipse.SelectedIndex = -1;
            comments.Text = string.Empty;
            sub_categories_qc.SelectedIndex = -1;
            categories_qc.SelectedIndex = -1;
            qcdate.CustomFormat = " ";
            qc_done_by.SelectedIndex = -1;
            volumes.Text = "1";
            party_location.SelectedIndex = -1;
            new_client.SelectedIndex = -1;
            pf_log.Text = string.Empty;
            screening_volumes.Text = string.Empty;
            datagridview_display_overall();
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

                obj_activitytype.activitytype_list(dtaa);

                activity_type.DataSource = dtaa;
                activity_type.DisplayMember = "ActivityType";


                conn.Close();
                activity_type.SelectedIndex = -1;
            }

            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details: " + ab.ToString());
            }
        }

        public void hideunhide_approveddates()
        {
            if (role.Text == "FINEX Fund Admins")
            {
                approved_by.SelectedIndex = -1;
                approved_date.CustomFormat = " ";
                approved_by.Enabled = false;
                approved_date.Enabled = false;
            }

            //else if (role.Text == "Insured - Standalone")
            //{
            //    approved_by.SelectedIndex = -1;
            //    approved_date.CustomFormat = " ";
            //    approved_by.Enabled = false;
            //    approved_date.Enabled = false;
            //}
            else if (role.Text == "Instructing Party")
            {
                approved_by.SelectedIndex = -1;
                approved_date.CustomFormat = " ";
                approved_by.Enabled = false;
                approved_date.Enabled = false;
            }
            //else if (role.Text == "Reinsured - Standalone")
            //{
            //    approved_by.SelectedIndex = -1;
            //    approved_date.CustomFormat = " ";
            //    approved_by.Enabled = false;
            //    approved_date.Enabled = false;
            //}
            else
            {
                approved_by.Enabled = true;
                approved_date.Enabled = true;
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
                string querycategoryvalue = query_category.Text;
                obj_querycategory.queriedfor_list(dtaa, querycategoryvalue);
                queried_for.DataSource = dtaa;
                queried_for.DisplayMember = "QueriedFor";
                //queried_for.SelectedIndex = -1;
                conn.Close();
            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details: " + ab.ToString());
            }
        }

        public void autopopulate_queriedfor_requery_list()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            try
            {
                QueryCategory obj_querycategory = new QueryCategory();
                DataTable dtaa = new DataTable();
                string querycategoryvalue = query_category_requery.Text;
                obj_querycategory.queriedfor_list(dtaa, querycategoryvalue);
                queried_for_requery.DataSource = dtaa;
                queried_for_requery.DisplayMember = "QueriedFor";
                //queried_for.SelectedIndex = -1;
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
                party_location.DataSource = dtaa;
                party_location.DisplayMember = "Requestor Location";
                conn.Close();
                party_location.SelectedIndex = -1;
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
                QueryRaisedBy obj_requeryraisedby = new QueryRaisedBy();

                DataTable dtaa_raisedby = new DataTable();
                DataTable dtaa_reraisedby = new DataTable();

                obj_queryraisedby.queryraisedby_list(dtaa_raisedby);
                obj_requeryraisedby.queryraisedby_list(dtaa_reraisedby);

                query_raised_by.DataSource = dtaa_raisedby;
                query_raised_by.DisplayMember = "QueryResolvedBy";

                requery_raised_by.DataSource = dtaa_reraisedby;
                requery_raised_by.DisplayMember = "QueryResolvedBy";


                conn.Close();

                query_raised_by.SelectedIndex = -1;
                requery_raised_by.SelectedIndex = -1;

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
                query_category.DataSource = dtaa;
                query_category.DisplayMember = "QueryCategory";
                conn.Close();
                query_category.SelectedIndex = -1;
            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details: " + ab.ToString());
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

                DataTable dtaa_qcdoneby = new DataTable();
                DataTable dtaa_inflowprocessedby = new DataTable();
                DataTable dtaa_ubovalidatedby = new DataTable();
  

                obj_empname.qcdoneby_list(dtaa_qcdoneby);
                obj_empname.inflowprocessedby_list(dtaa_inflowprocessedby);
                obj_empname.ubovalidatedby_list(dtaa_ubovalidatedby);
                

                qc_done_by.DataSource = dtaa_qcdoneby;
                qc_done_by.DisplayMember = "EmpName";


                inflow_processed_by.DataSource = dtaa_inflowprocessedby;
                inflow_processed_by.DisplayMember = "EmpName";

                ubo_validated_by.DataSource = dtaa_ubovalidatedby;
                ubo_validated_by.DisplayMember = "EmpName";

                conn.Close();

                qc_done_by.SelectedIndex = -1;
                inflow_processed_by.SelectedIndex = -1;

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

                approved_by.DataSource = dtaa_approvedby;
                approved_by.DisplayMember = "EmpName";


                conn.Close();

                approved_by.SelectedIndex = -1;

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
                sub_categories_qc.DataSource = dtaa;
                sub_categories_qc.DisplayMember = "SubCategories";
                conn.Close();
                sub_categories_qc.SelectedIndex = -1;
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
                org_status.DataSource = dtaa;
                org_status.DisplayMember = "OrgStatus";
                conn.Close();
                org_status.SelectedIndex = -1;
            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details: " + ab.ToString());
            }
        }

        public void query_category_list()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            try
            {
                QueryCategory obj_querycategory = new QueryCategory();
                QueryCategory obj_querycategory1 = new QueryCategory();
                DataTable dtaa = new DataTable();
                DataTable dtaa1 = new DataTable();

                obj_querycategory.querycategory_list(dtaa);
                obj_querycategory1.querycategory_list(dtaa1);

                query_category.DataSource = dtaa;
                query_category.DisplayMember = "QueryCategory";

                query_category_requery.DataSource = dtaa1;
                query_category_requery.DisplayMember = "QueryCategory";

                conn.Close();
                query_category.SelectedIndex = -1;
                query_category_requery.SelectedIndex = -1;
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
                legal_entity_name.DataSource = dtaa;
                legal_entity_name.DisplayMember = "WTWLegalEntity";
                conn.Close();
                legal_entity_name.SelectedIndex = -1;
            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details: " + ab.ToString());
            }
        }



        private void received_date_ValueChanged(object sender, EventArgs e)
        {
            received_date.CustomFormat = "dd-MMMM-yyyy";
        }

        private void received_date_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Space || e.KeyCode == Keys.Back)
            {
                received_date.CustomFormat = " ";
            }
        }


        private void ubo_validation_date_ValueChanged(object sender, EventArgs e)
        {
            ubo_validation_date.CustomFormat = "dd-MMMM-yyyy";
        }

        private void ubo_validation_date_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Space || e.KeyCode == Keys.Back)
            {
                ubo_validation_date.CustomFormat = " ";
            }
        }

        
        private void query_raised_date_ValueChanged(object sender, EventArgs e)
        {
            query_raised_date.CustomFormat = "dd-MMMM-yyyy";
        }

        private void query_raised_date_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Space || e.KeyCode == Keys.Back)
            {
                query_raised_date.CustomFormat = " ";
            }
        }

        
        private void query_resolved_date_ValueChanged(object sender, EventArgs e)
        {
            query_resolved_date.CustomFormat = "dd-MMMM-yyyy";
        }

        private void query_resolved_date_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Space || e.KeyCode == Keys.Back)
            {
                query_resolved_date.CustomFormat = " ";
            }
        }

       
        private void approved_date_ValueChanged(object sender, EventArgs e)
        {
            approved_date.CustomFormat = "dd-MMMM-yyyy";
        }

        private void approved_date_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Space || e.KeyCode == Keys.Back)
            {
                approved_date.CustomFormat = " ";
            }
        }

        public void datagridview_display_overall()
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

                if (string.IsNullOrEmpty(searchby_partyname.Text) && string.IsNullOrEmpty(searchby_orgid.Text))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select top 100 RequestID,PartyName,Received_Date,Requestor_Email_Address,Legal_Entity_Name,Role,OrgID,Org_Status,Inflow_Processed_By,Inflow_Processed_Date,UBO_Validated_By,UBO_Validated_Date,Query_Raised_Date,Query_Category,Queried_For,Query_Raised_By,Query_Resolved_Date,Volumes,Approved_Date,Approved_By,PF_Risk_Category,Other_Parties,GCID_In_ECS_Status,FCA_Updated_In_Eclipse,Comments,Sub_Categories_QC,Categories_QC,QC_Date,QC_Done_By,a.LastUpdatedDateTime,b.EmpName,Party_Location,New_Client,PF_Log,Activity_Type,Screening_Volumes,ReQuery_Raised_Date,ReQuery_Raised_By,Query_Category_ReQuery,Queried_For_ReQuery from dbo.tbl_passfort_cvt_daily_dotnet a with(nolock)  inner join dbo.tbl_emp_details b with(nolock) on a.lastupdatedby = substring(b.intid,5,len(b.intid)) where a.IsDeleted = 0 and a.lastupdatedby = @lastupdatedby";
                    cmd.Parameters.AddWithValue("@lastupdatedby", Environment.UserName.ToString());
                }
                else
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "dbo.usp_passfort_cvt_datagridview_search_dotnet";
                    if (string.IsNullOrEmpty(searchby_orgid.Text))
                    {
                        cmd.Parameters.AddWithValue("@orgid", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@orgid", searchby_orgid.Text);
                    }
                    if (string.IsNullOrEmpty(searchby_partyname.Text))
                    {
                        cmd.Parameters.AddWithValue("@partyname", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@partyname", searchby_partyname.Text);
                    }

                }
                sda.SelectCommand = cmd;
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details : " + ab.ToString());
            }
        }

        private void querycategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(query_category.Text))
            {
                autopopulate_queriedfor_list();
            }
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
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "dbo.usp_passfort_cvt_insert_daily_dotnet";
                cmd.Parameters.Add("@Message", SqlDbType.NVarChar, 1000);
                cmd.Parameters["@Message"].Direction = ParameterDirection.Output;
                cmd.Parameters.AddWithValue("@PartyName",partyname.Text);
                cmd.Parameters.AddWithValue("@Received_Date",received_date.Value.Date);
                cmd.Parameters.AddWithValue("@Requestor_Email_Address",requestor_email_address.Text);
                cmd.Parameters.AddWithValue("@Legal_Entity_Name",legal_entity_name.Text);
                cmd.Parameters.AddWithValue("@Role",role.Text);
                cmd.Parameters.AddWithValue("@OrgID",orgid.Text);
                cmd.Parameters.AddWithValue("@Org_Status",org_status.Text);
                cmd.Parameters.AddWithValue("@Inflow_Processed_By",inflow_processed_by.Text);
                cmd.Parameters.AddWithValue("@Inflow_Processed_Date",inflow_processed_date.Value.Date);
                if (string.IsNullOrEmpty(ubo_validated_by.Text))
                {
                    cmd.Parameters.AddWithValue("@UBO_Validated_By", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@UBO_Validated_By", ubo_validated_by.Text);
                }
                if (ubo_validation_date.Text.Trim() == string.Empty)
                {
                    cmd.Parameters.AddWithValue("@UBO_Validated_Date", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@UBO_Validated_Date", ubo_validation_date.Value.Date);
                }
                if (query_raised_date.Text.Trim() == string.Empty)
                {
                    cmd.Parameters.AddWithValue("@Query_Raised_Date",DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Query_Raised_Date", query_raised_date.Value.Date);
                }
                if (requery_raised_date.Text.Trim() == string.Empty)
                {
                    cmd.Parameters.AddWithValue("@ReQuery_Raised_Date", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ReQuery_Raised_Date", requery_raised_date.Value.Date);
                }
                if (string.IsNullOrEmpty(query_raised_by.Text))
                {
                    cmd.Parameters.AddWithValue("@Query_Raised_By",DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Query_Raised_By", query_raised_by.Text);
                }
                if (string.IsNullOrEmpty(requery_raised_by.Text))
                {
                    cmd.Parameters.AddWithValue("@ReQuery_Raised_By", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ReQuery_Raised_By", requery_raised_by.Text);
                }
                if (string.IsNullOrEmpty(queried_for.Text))
                {
                    cmd.Parameters.AddWithValue("@Queried_For",DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Queried_For", queried_for.Text);
                }
                if (string.IsNullOrEmpty(queried_for_requery.Text))
                {
                    cmd.Parameters.AddWithValue("@Queried_For_ReQuery", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Queried_For_ReQuery", queried_for_requery.Text);
                }
                if (string.IsNullOrEmpty(query_category.Text))
                {
                    cmd.Parameters.AddWithValue("@Query_Category",DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Query_Category", query_category.Text);
                }
                if (string.IsNullOrEmpty(query_category_requery.Text))
                {
                    cmd.Parameters.AddWithValue("@Query_Category_ReQuery", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Query_Category_ReQuery", query_category_requery.Text);
                }
                if (query_resolved_date.Text.Trim() == string.Empty)
                {
                    cmd.Parameters.AddWithValue("@Query_Resolved_Date", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Query_Resolved_Date", query_resolved_date.Value.Date);
                }
                if (string.IsNullOrEmpty(volumes.Text))
                {
                    cmd.Parameters.AddWithValue("@Volumes", 0);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Volumes", volumes.Text);
                }
                if (string.IsNullOrEmpty(approved_by.Text))
                {
                    cmd.Parameters.AddWithValue("@Approved_Date", DBNull.Value);
                    cmd.Parameters.AddWithValue("@Approved_By", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Approved_Date", approved_date.Value.Date);
                    cmd.Parameters.AddWithValue("@Approved_By", approved_by.Text);
                }
                cmd.Parameters.AddWithValue("@PF_Risk_Category",pf_risk_category.Text);
                if (string.IsNullOrEmpty(other_parties.Text))
                {
                    cmd.Parameters.AddWithValue("@Other_Parties", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Other_Parties", other_parties.Text);
                }
                if (string.IsNullOrEmpty(gcid_in_ecs_status.Text))
                {
                    cmd.Parameters.AddWithValue("@GCID_In_ECS_Status", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@GCID_In_ECS_Status", gcid_in_ecs_status.Text);
                }
                if (string.IsNullOrEmpty(fca_updated_in_eclipse.Text))
                {
                    cmd.Parameters.AddWithValue("@FCA_Updated_In_Eclipse", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@FCA_Updated_In_Eclipse", fca_updated_in_eclipse.Text);
                }
                if (string.IsNullOrEmpty(comments.Text))
                {
                    cmd.Parameters.AddWithValue("@Comments", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Comments", comments.Text);
                }
                if (string.IsNullOrEmpty(sub_categories_qc.Text))
                {
                    cmd.Parameters.AddWithValue("@Sub_Categories_QC", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Sub_Categories_QC", sub_categories_qc.Text);
                }
                if (string.IsNullOrEmpty(categories_qc.Text))
                {
                    cmd.Parameters.AddWithValue("@Categories_QC", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Categories_QC", categories_qc.Text);
                }
                if (qcdate.Text.Trim() == string.Empty)
                {
                    cmd.Parameters.AddWithValue("@QC_Date", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@QC_Date", qcdate.Value.Date);
                }
                if (string.IsNullOrEmpty(qc_done_by.Text))
                {
                    cmd.Parameters.AddWithValue("@QC_Done_By", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@QC_Done_By", qc_done_by.Text);
                }
                cmd.Parameters.AddWithValue("@LastUpdatedBy",Environment.UserName.ToString());
                cmd.Parameters.AddWithValue("@MachineName",Environment.MachineName.ToString());
                cmd.Parameters.AddWithValue("@Activity_Type",activity_type.Text);
                if (string.IsNullOrEmpty(party_location.Text))
                {
                    cmd.Parameters.AddWithValue("@Party_Location", DBNull.Value);
                }
                else if (string.IsNullOrEmpty(activity_type.Text))
                {
                    MessageBox.Show("Please update Activity Type");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Party_Location", party_location.Text);
                }
                if (string.IsNullOrEmpty(new_client.Text))
                {
                    cmd.Parameters.AddWithValue("@New_Client", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@New_Client", new_client.Text);
                }
                if (string.IsNullOrEmpty(pf_log.Text))
                {
                    cmd.Parameters.AddWithValue("@PF_Log", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@PF_Log", pf_log.Text);
                }
                cmd.Parameters.AddWithValue("@Screening_Volumes", screening_volumes.Text);


                //if conditions
                if (string.IsNullOrEmpty(partyname.Text))
                {
                    MessageBox.Show("Please update Party Name");
                }
                else if (received_date.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please update Received Date");
                }
                else if (string.IsNullOrEmpty(requestor_email_address.Text))
                {
                    MessageBox.Show("Please update Requestor Email Address");
                }
                else if (string.IsNullOrEmpty(legal_entity_name.Text))
                {
                    MessageBox.Show("Please update Legal Entity Name");
                }
                else if (string.IsNullOrEmpty(role.Text))
                {
                    MessageBox.Show("Please update Role");
                }
                else if (string.IsNullOrEmpty(orgid.Text))
                {
                    MessageBox.Show("Please update Org ID");
                }
                else if (string.IsNullOrEmpty(org_status.Text))
                {
                    MessageBox.Show("Please update Org Status");
                }
                else if (string.IsNullOrEmpty(inflow_processed_by.Text))
                {
                    MessageBox.Show("Please update Inflow Processed by");
                }
                else if (inflow_processed_date.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please update Inflow Processed Date");
                }
                else if (string.IsNullOrEmpty(pf_risk_category.Text) && approved_date.Text.Trim() != string.Empty)
                {
                    MessageBox.Show("Please update PF Risk Category");
                }
                else if (received_date.Value.Date > current_datetime.Value.Date)
                {
                    MessageBox.Show("Received Date cannot be more than today's date");
                }
                else if (inflow_processed_date.Value.Date > current_datetime.Value.Date)
                {
                    MessageBox.Show("Inflow Processed date cannot be more than today's date");
                }
                else if (ubo_validation_date.Value.Date > current_datetime.Value.Date)
                {
                    MessageBox.Show("UBO Validation date cannot be more than today's date");
                }
                else if (query_raised_date.Value.Date > current_datetime.Value.Date)
                {
                    MessageBox.Show("Query Raised date cannot be more than today's date");
                }
                else if (query_resolved_date.Value.Date > current_datetime.Value.Date)
                {
                    MessageBox.Show("Query Resolved date cannot be more than today's date");
                }
                else if (requery_raised_date.Value.Date > current_datetime.Value.Date)
                {
                    MessageBox.Show("Re-Query Raised date cannot be more than today's date");
                }
                else if (approved_date.Value.Date > current_datetime.Value.Date)
                {
                    MessageBox.Show("Approved date cannot be more than today's date");
                }
                else if (query_raised_date.Text.Trim() != string.Empty && string.IsNullOrEmpty(query_category.Text))
                {
                    MessageBox.Show("Please update Query Category");
                }
                else if (requery_raised_date.Text.Trim() != string.Empty && string.IsNullOrEmpty(query_category_requery.Text))
                {
                    MessageBox.Show("Please update Query Category ReQuery");
                }
                else if (query_raised_date.Text.Trim() != string.Empty && string.IsNullOrEmpty(queried_for.Text))
                {
                    MessageBox.Show("Please update Queried For");
                }
                else if (requery_raised_date.Text.Trim() != string.Empty && string.IsNullOrEmpty(queried_for_requery.Text))
                {
                    MessageBox.Show("Please update Queried For ReQuery");
                }
                else if(query_raised_date.Text.Trim() != string.Empty && string.IsNullOrEmpty(query_raised_by.Text))
                {
                    MessageBox.Show("Please update Query Raised By");
                }
                else if (requery_raised_date.Text.Trim() != string.Empty && string.IsNullOrEmpty(requery_raised_by.Text))
                {
                    MessageBox.Show("Please update Re-Query Raised By");
                }
                else if (approved_date.Text.Trim() != string.Empty && string.IsNullOrEmpty(approved_by.Text))
                {
                    MessageBox.Show("Please update Approved by");
                }
                else if (!string.IsNullOrEmpty(approved_by.Text) && approved_date.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please update Approved Date");
                }
                else if (org_status.Text == "Approved" && approved_date.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please update Approved Date as Org Status is marked as Approved");
                }
                else if (orgid.Text != string.Empty && orgid.TextLength < 5)
                {
                    MessageBox.Show("OrgID cannot be less than 5 letters or numbers");
                }
                else if (approved_date.Text.Trim() != string.Empty && org_status.Text != "Approved" && (role.Text != "Client Delegate" || role.Text != "Instructing Party" || role.Text != "Insured - Standalone" || role.Text != "Reinsured - Standalone"))
                {
                    MessageBox.Show("Org Status should be approved");
                }
                else if (approved_date.Text.Trim() == string.Empty && org_status.Text == "Approved" && (role.Text != "Client Delegate" || role.Text != "Instructing Party" || role.Text != "Insured - Standalone" || role.Text != "Reinsured - Standalone"))
                {
                    MessageBox.Show("Please update Approved Date");
                }
                //if conditions added on 22nd Oct 2025
                else if (role.Text == "Client" && org_status.Text == "Pending CVT SPOE/Approval" && string.IsNullOrEmpty(pf_risk_category.Text))
                {
                    MessageBox.Show("Please update PF Risk Category");
                }
                else if (role.Text == "Client" && org_status.Text == "Pending CVT SPOE/Approval" && string.IsNullOrEmpty(other_parties.Text))
                {
                    MessageBox.Show("Please update Other parties");
                }
                else if (role.Text == "Client" && org_status.Text == "Pending CVT SPOE/Approval" && string.IsNullOrEmpty(gcid_in_ecs_status.Text))
                {
                    MessageBox.Show("Please update GCID in ECS Status");
                }
                else if (role.Text == "Client" && org_status.Text == "Pending CVT SPOE/Approval" && string.IsNullOrEmpty(fca_updated_in_eclipse.Text))
                {
                    MessageBox.Show("Please update FCA Updated in Eclipse");
                }
                else if (role.Text == "Client" && org_status.Text == "Pending CVT SPOE/Approval" && string.IsNullOrEmpty(new_client.Text))
                {
                    MessageBox.Show("Please update New client");
                }
                else if (org_status.Text == "Pending CVT SPOE/Approval" && inflow_processed_date.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please update Inflow Processed Date");
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
                MessageBox.Show("Error Generated Details :" + ab.ToString());
            }
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
                cmd.CommandText = "dbo.usp_passfort_cvt_update_daily_dotnet";
                cmd.Parameters.Add("@Message", SqlDbType.NVarChar, 1000);
                cmd.Parameters["@Message"].Direction = ParameterDirection.Output;
                cmd.Parameters.AddWithValue("@RequestID",requestid.Text);
                cmd.Parameters.AddWithValue("@PartyName", partyname.Text);
                cmd.Parameters.AddWithValue("@Received_Date", received_date.Value.Date);
                cmd.Parameters.AddWithValue("@Requestor_Email_Address", requestor_email_address.Text);
                cmd.Parameters.AddWithValue("@Legal_Entity_Name", legal_entity_name.Text);
                cmd.Parameters.AddWithValue("@Role", role.Text);
                cmd.Parameters.AddWithValue("@OrgID", orgid.Text);
                cmd.Parameters.AddWithValue("@Org_Status", org_status.Text);
                cmd.Parameters.AddWithValue("@Inflow_Processed_By", inflow_processed_by.Text);
                cmd.Parameters.AddWithValue("@Inflow_Processed_Date", inflow_processed_date.Value.Date);
                if (string.IsNullOrEmpty(ubo_validated_by.Text))
                {
                    cmd.Parameters.AddWithValue("@UBO_Validated_By", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@UBO_Validated_By", ubo_validated_by.Text);
                }
                if (ubo_validation_date.Text.Trim() == string.Empty)
                {
                    cmd.Parameters.AddWithValue("@UBO_Validated_Date", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@UBO_Validated_Date", ubo_validation_date.Value.Date);
                }
                if (query_raised_date.Text.Trim() == string.Empty)
                {
                    cmd.Parameters.AddWithValue("@Query_Raised_Date", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Query_Raised_Date", query_raised_date.Value.Date);
                }
                if (requery_raised_date.Text.Trim() == string.Empty)
                {
                    cmd.Parameters.AddWithValue("@ReQuery_Raised_Date", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ReQuery_Raised_Date", requery_raised_date.Value.Date);
                }
                if (string.IsNullOrEmpty(query_raised_by.Text))
                {
                    cmd.Parameters.AddWithValue("@Query_Raised_By", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Query_Raised_By", query_raised_by.Text);
                }
                if (string.IsNullOrEmpty(requery_raised_by.Text))
                {
                    cmd.Parameters.AddWithValue("@ReQuery_Raised_By", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ReQuery_Raised_By", requery_raised_by.Text);
                }
                if (string.IsNullOrEmpty(queried_for.Text))
                {
                    cmd.Parameters.AddWithValue("@Queried_For", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Queried_For", queried_for.Text);
                }
                if (string.IsNullOrEmpty(queried_for_requery.Text))
                {
                    cmd.Parameters.AddWithValue("@Queried_For_ReQuery", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Queried_For_ReQuery", queried_for_requery.Text);
                }
                if (string.IsNullOrEmpty(query_category.Text))
                {
                    cmd.Parameters.AddWithValue("@Query_Category", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Query_Category", query_category.Text);
                }
                if (string.IsNullOrEmpty(query_category_requery.Text))
                {
                    cmd.Parameters.AddWithValue("@Query_Category_ReQuery", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Query_Category_ReQuery", query_category_requery.Text);
                }
                if (query_resolved_date.Text.Trim() == string.Empty)
                {
                    cmd.Parameters.AddWithValue("@Query_Resolved_Date", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Query_Resolved_Date", query_resolved_date.Value.Date);
                }
                if (string.IsNullOrEmpty(volumes.Text))
                {
                    cmd.Parameters.AddWithValue("@Volumes", 0);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Volumes", volumes.Text);
                }
                if (string.IsNullOrEmpty(approved_by.Text))
                {
                    cmd.Parameters.AddWithValue("@Approved_Date", DBNull.Value);
                    cmd.Parameters.AddWithValue("@Approved_By", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Approved_Date", approved_date.Value.Date);
                    cmd.Parameters.AddWithValue("@Approved_By", approved_by.Text);
                }
                cmd.Parameters.AddWithValue("@PF_Risk_Category", pf_risk_category.Text);
                if (string.IsNullOrEmpty(other_parties.Text))
                {
                    cmd.Parameters.AddWithValue("@Other_Parties", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Other_Parties", other_parties.Text);
                }
                if (string.IsNullOrEmpty(gcid_in_ecs_status.Text))
                {
                    cmd.Parameters.AddWithValue("@GCID_In_ECS_Status", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@GCID_In_ECS_Status", gcid_in_ecs_status.Text);
                }
                if (string.IsNullOrEmpty(fca_updated_in_eclipse.Text))
                {
                    cmd.Parameters.AddWithValue("@FCA_Updated_In_Eclipse", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@FCA_Updated_In_Eclipse", fca_updated_in_eclipse.Text);
                }
                if (string.IsNullOrEmpty(comments.Text))
                {
                    cmd.Parameters.AddWithValue("@Comments", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Comments", comments.Text);
                }
                if (string.IsNullOrEmpty(sub_categories_qc.Text))
                {
                    cmd.Parameters.AddWithValue("@Sub_Categories_QC", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Sub_Categories_QC", sub_categories_qc.Text);
                }
                if (string.IsNullOrEmpty(categories_qc.Text))
                {
                    cmd.Parameters.AddWithValue("@Categories_QC", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Categories_QC", categories_qc.Text);
                }
                if (qcdate.Text.Trim() == string.Empty)
                {
                    cmd.Parameters.AddWithValue("@QC_Date", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@QC_Date", qcdate.Value.Date);
                }
                if (string.IsNullOrEmpty(qc_done_by.Text))
                {
                    cmd.Parameters.AddWithValue("@QC_Done_By", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@QC_Done_By", qc_done_by.Text);
                }
                cmd.Parameters.AddWithValue("@LastUpdatedBy", Environment.UserName.ToString());
                cmd.Parameters.AddWithValue("@MachineName", Environment.MachineName.ToString());
                if (string.IsNullOrEmpty(party_location.Text))
                {
                    cmd.Parameters.AddWithValue("@Party_Location", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Party_Location", party_location.Text);
                }
                if (string.IsNullOrEmpty(new_client.Text))
                {
                    cmd.Parameters.AddWithValue("@New_Client", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@New_Client", new_client.Text);
                }
                if (string.IsNullOrEmpty(pf_log.Text))
                {
                    cmd.Parameters.AddWithValue("@PF_Log", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@PF_Log", pf_log.Text);
                }
                cmd.Parameters.AddWithValue("@Activity_Type",activity_type.Text);
                cmd.Parameters.AddWithValue("@Screening_Volumes", screening_volumes.Text);

                //if conditions
                if (string.IsNullOrEmpty(partyname.Text))
                {
                    MessageBox.Show("Please update Party Name");
                }
                else if (received_date.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please update Received Date");
                }
                else if (string.IsNullOrEmpty(requestor_email_address.Text))
                {
                    MessageBox.Show("Please update Requestor Email Address");
                }
                else if (string.IsNullOrEmpty(legal_entity_name.Text))
                {
                    MessageBox.Show("Please update Legal Entity Name");
                }
                else if (string.IsNullOrEmpty(role.Text))
                {
                    MessageBox.Show("Please update Role");
                }
                else if (string.IsNullOrEmpty(orgid.Text))
                {
                    MessageBox.Show("Please update Org ID");
                }
                else if (string.IsNullOrEmpty(org_status.Text))
                {
                    MessageBox.Show("Please update Org Status");
                }
                else if (string.IsNullOrEmpty(inflow_processed_by.Text))
                {
                    MessageBox.Show("Please update Inflow Processed by");
                }
                else if (inflow_processed_date.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please update Inflow Processed Date");
                }
                else if (string.IsNullOrEmpty(pf_risk_category.Text) && approved_date.Text.Trim() != string.Empty)
                {
                    MessageBox.Show("Please update PF Risk Category");
                }
                else if (received_date.Value.Date > current_datetime.Value.Date)
                {
                    MessageBox.Show("Received Date cannot be more than today's date");
                }
                else if (inflow_processed_date.Value.Date > current_datetime.Value.Date)
                {
                    MessageBox.Show("Inflow Processed date cannot be more than today's date");
                }
                else if (ubo_validation_date.Value.Date > current_datetime.Value.Date)
                {
                    MessageBox.Show("UBO Validation date cannot be more than today's date");
                }
                else if (query_raised_date.Value.Date > current_datetime.Value.Date)
                {
                    MessageBox.Show("Query Raised date cannot be more than today's date");
                }
                else if (query_resolved_date.Value.Date > current_datetime.Value.Date)
                {
                    MessageBox.Show("Query Resolved date cannot be more than today's date");
                }
                else if (requery_raised_date.Value.Date > current_datetime.Value.Date)
                {
                    MessageBox.Show("Re-Query Raised date cannot be more than today's date");
                }
                else if (approved_date.Value.Date > current_datetime.Value.Date)
                {
                    MessageBox.Show("Approved date cannot be more than today's date");
                }
                else if (query_raised_date.Text.Trim() != string.Empty && string.IsNullOrEmpty(query_category.Text))
                {
                    MessageBox.Show("Please update Query Category");
                }
                else if (requery_raised_date.Text.Trim() != string.Empty && string.IsNullOrEmpty(query_category_requery.Text))
                {
                    MessageBox.Show("Please update Query Category ReQuery");
                }
                else if (query_raised_date.Text.Trim() != string.Empty && string.IsNullOrEmpty(queried_for.Text))
                {
                    MessageBox.Show("Please update Queried For");
                }
                else if (requery_raised_date.Text.Trim() != string.Empty && string.IsNullOrEmpty(queried_for_requery.Text))
                {
                    MessageBox.Show("Please update Queried For ReQuery");
                }
                else if (query_raised_date.Text.Trim() != string.Empty && string.IsNullOrEmpty(query_raised_by.Text))
                {
                    MessageBox.Show("Please update Query Raised By");
                }
                else if (requery_raised_date.Text.Trim() != string.Empty && string.IsNullOrEmpty(requery_raised_by.Text))
                {
                    MessageBox.Show("Please update Re-Query Raised By");
                }
                else if (approved_date.Text.Trim() != string.Empty && string.IsNullOrEmpty(approved_by.Text))
                {
                    MessageBox.Show("Please update Approved by");
                }
                else if (!string.IsNullOrEmpty(approved_by.Text) && approved_date.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please update Approved Date");
                }
                else if (org_status.Text == "Approved" && approved_date.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please update Approved Date as Org Status is marked as Approved");
                }
                else if (orgid.Text != string.Empty && orgid.TextLength < 5)
                {
                    MessageBox.Show("OrgID cannot be less than 5 letters or numbers");
                }
                else if (approved_date.Text.Trim() != string.Empty && org_status.Text != "Approved" && (role.Text != "Client Delegate" || role.Text != "Instructing Party" || role.Text != "Insured - Standalone" || role.Text != "Reinsured - Standalone"))
                {
                    MessageBox.Show("Org Status should be approved");
                }
                else if (approved_date.Text.Trim() == string.Empty && org_status.Text == "Approved" && (role.Text != "Client Delegate" || role.Text != "Instructing Party" || role.Text != "Insured - Standalone" || role.Text != "Reinsured - Standalone"))
                {
                    MessageBox.Show("Please update Approved Date");
                }
                //if conditions added on 22nd Oct 2025
                else if (role.Text == "Client" && org_status.Text == "Pending CVT SPOE/Approval" && string.IsNullOrEmpty(pf_risk_category.Text))
                {
                    MessageBox.Show("Please update PF Risk Category");
                }
                else if (role.Text == "Client" && org_status.Text == "Pending CVT SPOE/Approval" && string.IsNullOrEmpty(other_parties.Text))
                {
                    MessageBox.Show("Please update Other parties");
                }
                else if (role.Text == "Client" && org_status.Text == "Pending CVT SPOE/Approval" && string.IsNullOrEmpty(gcid_in_ecs_status.Text))
                {
                    MessageBox.Show("Please update GCID in ECS Status");
                }
                else if (role.Text == "Client" && org_status.Text == "Pending CVT SPOE/Approval" && string.IsNullOrEmpty(fca_updated_in_eclipse.Text))
                {
                    MessageBox.Show("Please update FCA Updated in Eclipse");
                }
                else if (role.Text == "Client" && org_status.Text == "Pending CVT SPOE/Approval" && string.IsNullOrEmpty(new_client.Text))
                {
                    MessageBox.Show("Please update New client");
                }
                else if (org_status.Text == "Pending CVT SPOE/Approval" && inflow_processed_date.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please update Inflow Processed Date");
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
                MessageBox.Show("Error Generated Details :" + ab.ToString());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string messsage = "Do you want to update the record?";
            string title = "Message Box";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(messsage, title, buttons);
            if (result == DialogResult.Yes)
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                    requestid.Text = row.Cells["txt_RequestID"].Value.ToString();
                    partyname.Text = row.Cells["txt_PartyName"].Value.ToString();
                    activity_type.Text = row.Cells["txt_Activity_Type"].Value.ToString();
                    received_date.Text = row.Cells["txt_Received_Date"].Value.ToString();
                    received_date.CustomFormat = "dd-MMMM-yyyy";
                    requestor_email_address.Text = row.Cells["txt_Requestor_Email_Address"].Value.ToString();
                    legal_entity_name.Text = row.Cells["txt_Legal_Entity_Name"].Value.ToString();
                    role.Text = row.Cells["txt_Role"].Value.ToString();
                    orgid.Text = row.Cells["txt_OrgID"].Value.ToString();
                    org_status.Text = row.Cells["txt_Org_Status"].Value.ToString();
                    inflow_processed_by.Text = row.Cells["txt_Inflow_Processed_By"].Value.ToString();
                    inflow_processed_date.Text = row.Cells["txt_Inflow_Processed_Date"].Value.ToString();
                    inflow_processed_date.CustomFormat = "dd-MMMM-yyyy";
                    if (string.IsNullOrEmpty(row.Cells["txt_UBO_Validated_By"].Value.ToString()))
                    {
                        ubo_validated_by.SelectedIndex = -1;
                    }
                    else
                    {
                        ubo_validated_by.Text = row.Cells["txt_UBO_Validated_By"].Value.ToString();
                    }
                    if (string.IsNullOrEmpty(row.Cells["txt_UBO_Validated_Date"].Value.ToString()))
                    {
                        ubo_validation_date.CustomFormat = " ";
                    }
                    else
                    {
                        ubo_validation_date.Text = row.Cells["txt_UBO_Validated_Date"].Value.ToString();
                        ubo_validation_date.CustomFormat = "dd-MMMM-yyyy";
                    }
                    if (string.IsNullOrEmpty(row.Cells["txt_Query_Raised_Date"].Value.ToString()))
                    {
                        query_raised_date.CustomFormat = " ";
                    }
                    else
                    {
                        query_raised_date.Text = row.Cells["txt_Query_Raised_Date"].Value.ToString();
                        query_raised_date.CustomFormat = "dd-MMMM-yyyy";
                    }
                    if (string.IsNullOrEmpty(row.Cells["txt_ReQuery_Raised_Date"].Value.ToString()))
                    {
                        requery_raised_date.CustomFormat = " ";
                    }
                    else
                    {
                        requery_raised_date.Text = row.Cells["txt_ReQuery_Raised_Date"].Value.ToString();
                        requery_raised_date.CustomFormat = "dd-MMMM-yyyy";
                    }
                    if (string.IsNullOrEmpty(row.Cells["txt_Query_Category"].Value.ToString()))
                    {
                        query_category.SelectedIndex = -1;
                    }
                    else
                    {
                        query_category.Text = row.Cells["txt_Query_Category"].Value.ToString();
                    }
                    if (string.IsNullOrEmpty(row.Cells["txt_Queried_For"].Value.ToString()))
                    {
                        queried_for.SelectedIndex = -1;
                    }
                    else
                    {
                        queried_for.Text = row.Cells["txt_Queried_For"].Value.ToString();
                    }
                    if (string.IsNullOrEmpty(row.Cells["txt_Query_Raised_By"].Value.ToString()))
                    {
                        query_raised_by.SelectedIndex = -1;
                    }
                    else
                    {
                        query_raised_by.Text = row.Cells["txt_Query_Raised_By"].Value.ToString();
                    }
                    if (string.IsNullOrEmpty(row.Cells["txt_ReQuery_Raised_By"].Value.ToString()))
                    {
                        requery_raised_by.SelectedIndex = -1;
                    }
                    else
                    {
                        requery_raised_by.Text = row.Cells["txt_ReQuery_Raised_By"].Value.ToString();
                    }
                    if (string.IsNullOrEmpty(row.Cells["txt_Query_Resolved_Date"].Value.ToString()))
                    {
                        query_resolved_date.CustomFormat = " ";
                    }
                    else
                    {
                        query_resolved_date.Text = row.Cells["txt_Query_Resolved_Date"].Value.ToString();
                        query_resolved_date.CustomFormat = "dd-MMMM-yyyy";
                    }
                    if (string.IsNullOrEmpty(row.Cells["txt_Volumes"].Value.ToString()))
                    {
                        volumes.Text = string.Empty;
                    }
                    else
                    {
                        volumes.Text = row.Cells["txt_Volumes"].Value.ToString();
                    }
                    if (string.IsNullOrEmpty(row.Cells["txt_Approved_Date"].Value.ToString()))
                    {
                        approved_by.SelectedIndex = -1;
                        approved_date.CustomFormat = " ";
                    }
                    else
                    {
                        approved_date.Text = row.Cells["txt_Approved_Date"].Value.ToString();
                        approved_date.CustomFormat = "dd-MMMM-yyyy";
                        approved_by.Text = row.Cells["txt_Approved_By"].Value.ToString();
                    }
                    if (string.IsNullOrEmpty(row.Cells["txt_PF_Risk_Category"].Value.ToString()))
                    {
                        pf_risk_category.SelectedIndex = -1;
                    }
                    else
                    {
                        pf_risk_category.Text = row.Cells["txt_PF_Risk_Category"].Value.ToString();
                    }
                    if (string.IsNullOrEmpty(row.Cells["txt_Other_Parties"].Value.ToString()))
                    {
                        other_parties.SelectedIndex = -1;
                    }
                    else
                    {
                        other_parties.Text = row.Cells["txt_Other_Parties"].Value.ToString();
                    }
                    if (string.IsNullOrEmpty(row.Cells["txt_GCID_In_ECS_Status"].Value.ToString()))
                    {
                        gcid_in_ecs_status.Text = row.Cells["txt_GCID_In_ECS_Status"].Value.ToString();
                    }
                    else
                    {
                        gcid_in_ecs_status.Text = row.Cells["txt_GCID_In_ECS_Status"].Value.ToString();
                    }
                    if (string.IsNullOrEmpty(row.Cells["txt_FCA_Updated_In_Eclipse"].Value.ToString()))
                    {
                        fca_updated_in_eclipse.SelectedIndex = -1;
                    }
                    else
                    {
                        fca_updated_in_eclipse.Text = row.Cells["txt_FCA_Updated_In_Eclipse"].Value.ToString();
                    }
                    if (string.IsNullOrEmpty(row.Cells["txt_Comments"].Value.ToString()))
                    {
                        comments.Text = string.Empty;
                    }
                    else
                    {
                        comments.Text = row.Cells["txt_Comments"].Value.ToString();
                    }
                    if (string.IsNullOrEmpty(row.Cells["txt_Sub_Categories_QC"].Value.ToString()))
                    {
                        sub_categories_qc.SelectedIndex = -1;
                    }
                    else
                    {
                        sub_categories_qc.Text = row.Cells["txt_Sub_Categories_QC"].Value.ToString();
                    }
                    if (string.IsNullOrEmpty(row.Cells["txt_Categories_QC"].Value.ToString()))
                    {
                        categories_qc.SelectedIndex = -1;
                    }
                    else
                    {
                        categories_qc.Text = row.Cells["txt_Categories_QC"].Value.ToString();
                    }
                    if (string.IsNullOrEmpty(row.Cells["txt_QC_Date"].Value.ToString()))
                    {
                        qcdate.CustomFormat = " ";
                    }
                    else
                    {
                        qcdate.Text = row.Cells["txt_QC_Date"].Value.ToString();
                        qcdate.CustomFormat = "dd-MMMM-yyyy";
                    }
                    if (string.IsNullOrEmpty(row.Cells["txt_QC_Done_By"].Value.ToString()))
                    {
                        qc_done_by.SelectedIndex = -1;
                    }
                    else
                    {
                        qc_done_by.Text = row.Cells["txt_QC_Done_By"].Value.ToString();
                    }
                    if (string.IsNullOrEmpty(row.Cells["txt_Party_Location"].Value.ToString()))
                    {
                        party_location.SelectedIndex = -1;
                    }
                    else
                    {
                        party_location.Text = row.Cells["txt_Party_Location"].Value.ToString();
                    }
                    if (string.IsNullOrEmpty(row.Cells["txt_New_Client"].Value.ToString()))
                    {
                        new_client.SelectedIndex = -1;
                    }
                    else
                    {
                        new_client.Text = row.Cells["txt_New_Client"].Value.ToString();
                    }
                    if (string.IsNullOrEmpty(row.Cells["txt_PF_Log"].Value.ToString()))
                    {
                        pf_log.Text = string.Empty;
                    }
                    else
                    {
                        pf_log.Text = row.Cells["txt_PF_Log"].Value.ToString();
                    }
                    if (string.IsNullOrEmpty(row.Cells["txt_Screening_Volumes"].Value.ToString()))
                    {
                        screening_volumes.Text = string.Empty;
                    }
                    else
                    {
                        screening_volumes.Text = row.Cells["txt_Screening_Volumes"].Value.ToString();
                    }
                }
                //insert.Enabled = false;
                //update.Enabled = true;
            }
            else
            {
                requestid.Focus();
                //insert.Enabled = true;
                //update.Enabled = false;
            }
        }

        private void role_SelectedIndexChanged(object sender, EventArgs e)
        {
            hideunhide_approveddates();
        }

        private void mainpage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_Page obj_mainpage = new Main_Page();
            obj_mainpage.Show();
        }

        private void inflow_processed_date_ValueChanged(object sender, EventArgs e)
        {
            inflow_processed_date.CustomFormat = "dd-MMMM-yyyy";
        }

        private void inflow_processed_date_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Space || e.KeyCode == Keys.Back)
            {
                inflow_processed_date.CustomFormat = " ";
            }
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

        private void approved_by_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Space || e.KeyCode == Keys.Back)
            {
                approved_by.SelectedIndex = -1;
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            reset_overall();
        }

        private void pf_risk_category_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Space || e.KeyCode == Keys.Back)
            {
                pf_risk_category.SelectedIndex = -1;
            }
        }

        private void public_private_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void pf_provided_director_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void new_client_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Space || e.KeyCode == Keys.Back)
            {
                new_client.SelectedIndex = -1;
            }
        }

        private void qc_done_by_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Space || e.KeyCode == Keys.Back)
            {
                qc_done_by.SelectedIndex = -1;
            }
        }

        private void categories_qc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Space || e.KeyCode == Keys.Back)
            {
                categories_qc.SelectedIndex = -1;
            }
        }

        private void sub_categories_qc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Space || e.KeyCode == Keys.Back)
            {
                sub_categories_qc.SelectedIndex = -1;
            }
        }

        private void party_location_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Space || e.KeyCode == Keys.Back)
            {
                party_location.SelectedIndex = -1;
            }
        }

        private void query_raised_by_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Space || e.KeyCode == Keys.Back)
            {
                query_raised_by.SelectedIndex = -1;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://app.powerbi.com/groups/81c3ab7d-0a2a-46f2-b54f-38eb239011a1/reports/930a495d-9c0b-4039-a7b8-b0a12fe94dc8/ReportSection31a41de679b2bcefa277?experience=power-bi");
            }
            catch (Exception ab)
            {
                MessageBox.Show("Unable to open link that was clicked. Following are the error generated details" + ab.ToString());
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void searchby_orgid_TextChanged(object sender, EventArgs e)
        {
            datagridview_display_overall();
        }

        private void searchby_partyname_TextChanged(object sender, EventArgs e)
        {
            datagridview_display_overall();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://a20-cb-dbse01p/Reports/report/DRD%20MI%20Mumbai/DRD%20Reports/rpt_SSRS_PassFort_CVT_TATDaily_DotNet");
            }
            catch (Exception ab)
            {
                MessageBox.Show("Unable to open link that was clicked. Following are the error generated details" + ab.ToString());
            }   
        }

        private void partyname_TextChanged(object sender, EventArgs e)
        {
            partyname.Select(0, 0);
        }

        private void requestor_email_address_TextChanged(object sender, EventArgs e)
        {
            requestor_email_address.Select(0, 0);
        }

        private void pf_log_TextChanged(object sender, EventArgs e)
        {
            //pf_log.Select(0, 0);
        }

        private void pf_log_TabIndexChanged(object sender, EventArgs e)
        {
            //pf_log.Select(0, 0);
        }

        private void requery_raised_date_ValueChanged(object sender, EventArgs e)
        {
            requery_raised_date.CustomFormat = "dd-MMMM-yyyy";
        }

        private void requery_raised_date_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Space || e.KeyCode == Keys.Back)
            {
                requery_raised_date.CustomFormat = " ";
            }
        }

        private void query_category_requery_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(query_category_requery.Text))
            {
                autopopulate_queriedfor_requery_list();
            }
        }
    }
}
