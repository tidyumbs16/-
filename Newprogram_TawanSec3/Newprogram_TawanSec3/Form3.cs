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
            string sql = "SELECT * FROM VW_CT";
            SqlDataAdapter da = new SqlDataAdapter(sql, Form1.DATA);
            da.Fill(ds, "ViewCT");
            DTGV_CT.DataSource = ds.Tables["ViewCT"];



            string sql2 = "SELECT * FROM TBL_SEX";
            string sql3 = "SELECT * FROM TBL_Member";


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



            BTEDT.Enabled = false;
        }

        private void BTMEMBER_Click(object sender, EventArgs e)
        {
            string id1 = "SELECT TOP1 * FROM table_TblCT ORDER BY idCTM DESC";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(id1, Form1.DATA);
            da.Fill(dt);
            int Topid = Convert.ToInt32(dt.Rows[0]["idCTM"]) + 1;
            LBID.Text = Topid.ToString();
            BTSR.Enabled = false;

        }
        
        private void UpdateData()
        {
            string sql = "SELECT * FROM  table_TblCT ";
            SqlDataAdapter da = new SqlDataAdapter(sql, Form1.DATA);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Update(ds, "CT");
            string sql1 = "SELECT FROM VW_CT";
            da = new SqlDataAdapter(sql, Form1.DATA);
            da.Fill(ds, "ViewCT");
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
        }


        
     
        
        private void BTADD_Click(object sender, EventArgs e)
        {
        
            string sql = "SELECT * FROM table_TblCT";
            SqlDataAdapter da = new SqlDataAdapter(sql, Form1.DATA);
            da.Fill(ds, "CT");
            DataRow[] drs = ds.Tables["CT"].Select("idCTM=' " + LBID.Text + "");
            if (drs.Length == 0)
            {
                DataSet ds2 = new DataSet();
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
 
 string sql1 = "SELECT FROM VW_CT";
 SqlDataAdapter da2 = new SqlDataAdapter(sql, Form1.DATA);
 da2.Fill(ds2, "ViewCT");

            }
            else
            {
                MessageBox.Show("เลข ID ซํ้า", "ERROR");

            }
           
            DTGV_CT.DataSource = ds.Tables["ViewCT"]; //*Update Data ลงตาราง *//

        }
    }
}
