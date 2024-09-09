using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NewjjenladongBONG
{
    public partial class FormCustomer : Form
    {
        public FormCustomer()
        {
            InitializeComponent();
        }
        ///////////
        DataSet ds = new DataSet();
        ///////////
       
        private void Updatedata()
        {
            string sql = "SELECT* FROM TBL_CT";
            SqlDataAdapter da = new SqlDataAdapter(sql, Formmain.DATA);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Update(ds, "CT");

            LBID.Text = "";
            TBNAME.Text = "";
            TBSNAME.Text = "";
            TBADDESS.Text = "";
            TBTEL.Text = "";
            CBSEX.SelectedIndex = 0;
            CBMEMBER.SelectedIndex = 0;
            DTBD.ResetText();
            BTSR.Enabled = true;

            string sql1 = "SELECT* FROM View_CT";
            da = new SqlDataAdapter(sql1, Formmain.DATA);
            da.Fill(ds, "ViewCT");
        }


        private void FormCustomer_Load(object sender, EventArgs e)
        {
            string sql = "SELECT* FROM View_CT";
            SqlDataAdapter da = new SqlDataAdapter(sql,Formmain.DATA);
            da.Fill(ds,"ViewCT");
            DTGV_CT.DataSource = ds.Tables["ViewCT"];
            string sql2 = "SELECT* FROM TBL_SEX";
            string sql3 = "SELECT* FROM TBL_Member";

            da = new SqlDataAdapter(sql2, Formmain.DATA);

            da.Fill(ds, "Typesex");
            CBSEX.DisplayMember = "NameSex";
            CBSEX.ValueMember = "TypeSex";
            CBSEX.DataSource = ds.Tables["Typesex"];

            da = new SqlDataAdapter(sql3, Formmain.DATA);

            da.Fill(ds, "TypeMember");
            CBMEMBER.DisplayMember = "NameMember";
            CBMEMBER.ValueMember = "TypeMember";
            CBMEMBER.DataSource = ds.Tables["TypeMember"];
            BTEDIT.Enabled = false;
            BTDEL.Enabled = true;

            string sql4 = "SELECT* FROM TBL_CT";
            da = new SqlDataAdapter(sql4, Formmain.DATA);
            da.Fill(ds, "CT"); // ---------- //

        }
        private void BTGENID_Click(object sender, EventArgs e)
        {
            string id1 = "SELECT TOP 1 * FROM TBL_CT ORDER BY IDCT DESC";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(id1, Formmain.DATA);
            da.Fill(dt);
            int Topid = Convert.ToInt32(dt.Rows[0]["IDCT"]) + 1;
            LBID.Text = Topid.ToString();
            BTDEL.Enabled = false;
            BTSR.Enabled = false;
        }
        private void BTRESET_Click(object sender, EventArgs e)
        {
            LBID.Text = "";
            TBNAME.Text = "";
            TBSNAME.Text = "";
            TBADDESS.Text = "";
            TBTEL.Text = "";
            CBSEX.SelectedIndex = 0;
            CBMEMBER.SelectedIndex = 0;
            DTBD.ResetText();
            BTSR.Enabled = true;
            BTADD.Enabled = true;
            BTDEL.Enabled = true;
            BTEDIT.Enabled = true;
        }

        private void UpdateView()
        {
            ds.Tables.Remove("ViewCT");
            string sql1 = "SELECT * FROM View_CT";
            SqlDataAdapter da = new SqlDataAdapter(sql1, Formmain.DATA);
            da.Fill(ds, "ViewCT");

            DTGV_CT.DataSource = ds.Tables["ViewCT"]; 

        }

        private void BTADD_Click(object sender, EventArgs e)
        {
            DataSet ds2 = new DataSet();
            string sql = "SELECT* FROM TBL_CT";
            SqlDataAdapter da = new SqlDataAdapter(sql, Formmain.DATA);
            da.Fill(ds, "CT");
            DataRow[] drs = ds.Tables["CT"].Select("IDCT = '" + LBID.Text + "'");
            if (drs.Length == 0)
            {
                DataRow dr = ds.Tables["CT"].NewRow();
                dr["IDCT"] = LBID.Text;
                dr["IDMEMBER"] = LBID.Text;
                dr["NameCT"] = TBNAME.Text;
                dr["SNameCT"] = TBSNAME.Text;
                dr["AddessCT"] = TBADDESS.Text;
                dr["TelCT"] = TBTEL.Text;
                dr["BDCT"] = DTBD.Text;
                dr["TypeSex"] = CBSEX.SelectedValue;
                dr["TypeMember"] = CBMEMBER.SelectedValue;
                ds.Tables["CT"].Rows.Add(dr);
                Updatedata();

                string sql1 = "SELECT * FROM View_CT";
                SqlDataAdapter da2 = new SqlDataAdapter(sql1, Formmain.DATA);
                da2.Fill(ds2, "ViewCT");
            }
            else
            {
                MessageBox.Show("เลข ID ซ้ำ", "ERORR");
            }
            UpdateView();

        }

        private void BTDEL_Click(object sender, EventArgs e)
        {

            DialogResult di = MessageBox.Show("ต้องการลบข้อมูลหรือไม่ Yes/No","ลบข้อมูล",MessageBoxButtons.YesNo);
            if (di == DialogResult.Yes)
            {
                DataRow dr = ds.Tables["CT"].Rows[eindex];
            dr.Delete();
           
            Updatedata();
                ds.Tables["CT"].AcceptChanges();
                UpdateView(); 
                MessageBox.Show("ลบข้อมูลเสร็จสิ้น");
            }
           
        }

        
        /// ///////////
       
        int eindex;
        
        /// //////////
       
        

        private void DTGV_CT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            eindex = e.RowIndex;
            BTDEL.Enabled = true;
        }

        private void DTGV_CT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            eindex = e.RowIndex;
            BTDEL.Enabled = true;
        }

        private void DTGV_CT_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataRow dr = ds.Tables["CT"].Rows[e.RowIndex];
            eindex = e.RowIndex;
            LBID.Text = dr["IDMEMBER"].ToString();
            TBNAME.Text = dr["NameCT"].ToString();
            TBSNAME.Text = dr["SNameCT"].ToString();
            TBADDESS.Text = dr["AddessCT"].ToString();
            TBTEL.Text = dr["TelCT"].ToString();
            DTBD.Text = dr["BDCT"].ToString();
            CBSEX.SelectedValue = dr["TypeSex"].ToString();
            CBMEMBER.SelectedValue = dr["TypeMember"].ToString();
            BTADD.Enabled = false;
            BTDEL.Enabled = false;
            BTEDIT.Enabled = true;
        }

        private void BTEDIT_Click(object sender, EventArgs e)
        {
            DataRow dr = ds.Tables["CT"].Rows[eindex];
            dr["IDMEMBER"] = LBID.Text;
            dr["NameCT"] = TBNAME.Text;
            dr["SNameCT"] = TBSNAME.Text;
            dr["AddessCT"] = TBADDESS.Text;
            dr["TelCT"] = TBTEL.Text;
            dr["BDCT"] = DTBD.Text;
            dr["TypeSex"] = CBSEX.SelectedValue;
            dr["TypeMember"] = CBMEMBER.SelectedValue;
            Updatedata();
            UpdateView();
            
            BTEDIT.Enabled = false;
            BTADD.Enabled = true;
            BTDEL.Enabled = false;

        }

        private void BTSR_Click(object sender, EventArgs e)
        {
            if (ds.Tables.Contains("SR"))
            {
                ds.Tables.Remove("SR");
            }
            string sql = "SELECT* FROM View_CT WHERE IDMEMBER LIKE '%"+TBSR.Text+"%' OR NameCT LIKE '%"+TBSR.Text+"%' OR TelCT LIKE '%"+TBSR.Text+"%'";
            SqlDataAdapter da = new SqlDataAdapter(sql, Formmain.DATA);
            da.Fill(ds, "SR");
            DTGV_CT.DataSource = ds.Tables["SR"];
        }

        private void TBNAME_TextChanged(object sender, EventArgs e)
        {

        }   
    }
}
