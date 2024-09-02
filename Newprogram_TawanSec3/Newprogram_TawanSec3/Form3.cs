using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Newprogram_TawanSec3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        
        DataSet ds = new DataSet();
        private void Form3_Load(object sender, EventArgs e)
        {
            string sql = "SELECT* FROM VW_CT";
            SqlDataAdapter da = new SqlDataAdapter(sql, Form1.DATA);
            da.Fill(ds, "ViewCT");
            DTGV_CT.DataSource = ds.Tables["ViewCT"];



            string sql2 = "SELECT* FROM TBL_SEX";
            string sql3 = "SELECT* FROM TBL_Member";


            da = new SqlDataAdapter(sql, Form1.DATA);
            da.Fill(ds, "TypeSEX");
            CBSEX.DisplayMember = "NameSEX";
            CBSEX.ValueMember = "TypeSEX";
            CBSEX.DataSource = ds.Tables["TypeSEX"];



            da = new SqlDataAdapter(sql3, Form1.DATA);
            da.Fill(ds, "TypeMember");
            CBMEMBER.DisplayMember = "NameMember";
            CBMEMBER.ValueMember = "TypeMember";
            CBMEMBER.DataSource = ds.Tables["TypeMember"];


            BTDLE.Enabled = true;
            BTEDT.Enabled = false;

            string sql4 = "SELECT* FROM table_TblCT";
            da = new SqlDataAdapter(sql4, Form1.DATA);
            da.Fill(ds, "CT");
        }

        private void BTMEMBER_Click(object sender, EventArgs e)
        {
            string id1 = "SELECT TOP 1 * FROM table_TblCT ORDER BY idCTM DESC";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(id1, Form1.DATA);
            da.Fill(dt);
            int Topid = Convert.ToInt32(dt.Rows[0]["idCTM"]) + 1;
            LBID.Text = Topid.ToString();
            BTSR.Enabled = false;

        }
        
        private void UpdateData()
        {
            string sql = "SELECT* FROM  table_TblCT ";
            SqlDataAdapter da = new SqlDataAdapter(sql, Form1.DATA);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Update(ds, "CT");
            string sql1 = "SELECT FROM VW_CT";
            da = new SqlDataAdapter(sql, Form1.DATA);
            da.Fill(ds, "ViewCT");
        }

      
        private void UpdateView()
        {
            ds.Tables.Remove("ViewCT");
            string sql1 = " SELECT* FROM VW_CT";
            SqlDataAdapter da = new SqlDataAdapter(sql1, Form1.DATA);
            da.Fill(ds, "ViewCT");
            
            DTGV_CT.DataSource = ds.Tables["ViewCT"];
        }
        
        
        
        private void BTRESET_Click(object sender, EventArgs e)
        {
            LBID.Text = "";
            TBNAME.Text = "";
            TBSNAME.Text = "";
            TBTEL.Text = "";
            CBSEX.SelectedIndex = 0;
            CBMEMBER.SelectedIndex = 0;
            DTBD.ResetText();
            BTSR.Enabled = true;
            BTADD.Enabled = true;
        }



        
        private void BTADD_Click(object sender, EventArgs e)
        {
            DataSet ds2 = new DataSet();
            string sql = "SELECT* FROM table_TblCT";
            SqlDataAdapter da = new SqlDataAdapter(sql, Form1.DATA);
            da.Fill(ds, "CT");
            DataRow[] drs = ds.Tables["CT"].Select("idCTM='" + LBID.Text + "'");
            if (drs.Length == 0)
            {
               
                DataRow dr = ds.Tables["CT"].NewRow();
                dr["idCTM"] = LBID.Text;
                dr["idMember"] = LBID.Text;
                dr["NameCTM"] = TBNAME.Text;
                dr["SNameCTM"] = TBSNAME.Text;
                dr["Address"] = TBADDRESS.Text;
                dr["TelCTM"] = TBTEL.Text;
                dr["BDCTM"] = DTBD.Text;
                dr["TypeSEX"] = CBSEX.SelectedValue;
                dr["TypeMember"] = CBMEMBER.SelectedValue;
                ds.Tables["CT"].Rows.Add(dr); //*เอาข้อมูลลงตาราง*//
 UpdateData();
 
           }
            else
            {
                MessageBox.Show("เลข ID ซํ้า", "ERROR");

            }

            UpdateView();
        }

        private void BTDLE_Click(object sender, EventArgs e)
        {
            DialogResult di = MessageBox.Show("ค้องการลบข้อมูลหรือไม่ YES/NO", "ลบข้อมูล", MessageBoxButtons.YesNo);
            if (di == DialogResult.Yes)
            {
                DataRow dr = ds.Tables["CT"].Rows[eindex];
                dr.Delete();
                

                UpdateData();
                ds.Tables["CT"].AcceptChanges();
                UpdateView();
MessageBox.Show("ลบข้อมูลเสร็จสิ้น");
            }
        }

        int eindex;
        private void DTGV_CT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            eindex = e.RowIndex;
            BTDLE.Enabled = true;
        }

        private void DTGV_CT_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           DataRow dr = ds.Tables["CT"].Rows[e.RowIndex];
           eindex = e.RowIndex; //*ส่งค่าตําแหน่งไป*//
           LBID.Text = dr["idMember"].ToString();
           TBNAME.Text = dr["NameCTM"].ToString();
           TBSNAME.Text = dr["SNameCTM"].ToString();
           TBADDRESS.Text = dr["Address"].ToString();
           TBTEL.Text = dr["TelCTM"].ToString();
           DTBD.Text = dr["BDCTM"].ToString();
           CBSEX.SelectedValue = dr["TypeSEX"].ToString();
           CBMEMBER.SelectedValue = dr["TypeMember"].ToString();
           UpdateData();
           UpdateView();
            
           BTDLE.Enabled = false;
           BTADD.Enabled = false;
           BTEDT.Enabled = true;
        }

        private void BTEDT_Click(object sender, EventArgs e)
        {
            DataRow dr = ds.Tables["CT"].Rows[eindex];
            dr["idMember"] = LBID.Text;
            dr["NameCTM"] = TBNAME.Text;
            dr["SNameCTM"] = TBSNAME.Text;
            dr["Address"] = TBADDRESS.Text;
            dr["TelCTM"] = TBTEL.Text;
            dr["BDCTM"] = DTBD.Text;
            dr["TypeSEX"] = CBSEX.SelectedValue;
            dr["TypeMember"] = CBMEMBER.SelectedValue;
            UpdateData();
            UpdateView();
            LBID.Text = "";
            TBSNAME.Text = "";
            TBSNAME.Text = "";
            TBADDRESS.Text = "";
            TBTEL.Text = "";
            CBSEX.SelectedValue = 0;
            CBMEMBER.SelectedValue = 0;
            DTBD.ResetText();
            BTEDT.Enabled = false;
            BTADD.Enabled = true;
            BTDLE.Enabled = true;
            
        }

        private void BTSR_Click(object sender, EventArgs e)
        {
            if (ds.Tables.Contains("SR"))
            {
                ds.Tables.Remove("SR");
            }
            string sql = "SELECT* FROM VW_CT WHERE idMember LIKE '%" + TBSR.Text + "%' OR NameCTM '%" + TBSR.Text + "%'";
            SqlDataAdapter da = new SqlDataAdapter(sql, Form1.DATA);
            da.Fill(ds, "SR");
            DTGV_CT.DataSource = ds.Tables["SR"];
        }
    }
}
