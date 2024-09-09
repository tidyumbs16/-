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
    public partial class Addmin : Form
    {
        
        public Addmin()
        {
            InitializeComponent();
        }
        public static string DATA = "Data Source=.; Database = DATA3; Trusted_Connection=True;"; 
    public static string Login = "";
        ///////////
        DataSet ds = new DataSet();
        ///////////
        
        private void LoadData()
        {
            string sql = "SELECT * FROM View_Owner";
            using (SqlDataAdapter da = new SqlDataAdapter(sql, Formmain.DATA))
            {
                ds.Tables.Clear();
                da.Fill(ds, "View_Owner");
                DTGV_CT.DataSource = ds.Tables["View_Owner"];
            }
            string sqlAdmin = "SELECT * FROM TBLAdmin";
            using  (SqlDataAdapter da = new SqlDataAdapter(sql, Formmain.DATA))
            {
                da.Fill(ds, "Ad");
            }
            
        }
        private void UpdateView()
        {
          
            ds.Tables.Remove("ViewOwner");
            string sql1 = "SELECT * FROM TBL_Owner";
            SqlDataAdapter da = new SqlDataAdapter(sql1, Formmain.DATA);
            da.Fill(ds, "ViewOwner");

            DTGV_CT.DataSource = ds.Tables["ViewOwner"];

        }
        private void Updatedata()
        {
            string sql = "SELECT* FROM TBL_Owner";
            SqlDataAdapter da = new SqlDataAdapter(sql, Formmain.DATA);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Update(ds, "ViewOwner");

            LBID.Text = "";
            TBNAME.Text = "";
            TBPassword.Text = "";

            BTSR.Enabled = true;

            string sql1 = "SELECT* FROM TBL_Owner";
            da = new SqlDataAdapter(sql1, Formmain.DATA);
            da.Fill(ds, "ViewOwner");

        }

        private void Addmin_Load(object sender, EventArgs e)
        {
            FormLoginaddmin FLI = new FormLoginaddmin();
            FLI.ShowDialog();
            if (Login == "")
            {
                Application.Exit();
            }

            string sql = "SELECT* FROM TBL_Owner";
            SqlDataAdapter da = new SqlDataAdapter(sql, Formmain.DATA);
            da.Fill(ds, "ViewOwner");
            DTGV_CT.DataSource = ds.Tables["ViewOwner"];
   



            string sql4 = "SELECT* FROM TBL_Owner";
            da = new SqlDataAdapter(sql4, Formmain.DATA);
            da.Fill(ds, "CT"); // ---------- //

            BTADD.Enabled = false;
            BTEDIT.Enabled = false;
            BTDEL.Enabled = false;
            
        }

        private void BTADD_Click(object sender, EventArgs e)
        {
            DataSet ds2 = new DataSet();
            string sql = "SELECT* FROM TBL_Owner";
            SqlDataAdapter da = new SqlDataAdapter(sql, Formmain.DATA);
            da.Fill(ds, "ViewOwner");
            DataRow[] drs = ds.Tables["ViewOwner"].Select("IDowner = '" + LBID.Text + "'");
            if (drs.Length == 0)
            {
                DataRow dr = ds.Tables["ViewOwner"].NewRow();
                dr["IDowner"] = LBID.Text;
                dr["UserLogin"] = TBNAME.Text;
                dr["PassLogin"] = TBPassword.Text;
                ds.Tables["ViewOwner"].Rows.Add(dr);
                Updatedata();
            }
            else
            {
                MessageBox.Show("เลข ID ซ้ำ", "ERORR");
            }
            UpdateView();
            BTADD.Enabled = false;
        }

        private void BTGENID_Click(object sender, EventArgs e)
        {
            string id1 = "SELECT TOP 1 * FROM TBL_Owner ORDER BY IDowner DESC";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(id1, Formmain.DATA);
            da.Fill(dt);
            int Topid = Convert.ToInt32(dt.Rows[0]["IDowner"]) + 1;
            LBID.Text = Topid.ToString();

            BTADD.Enabled = true;
        }

        
       

        private void BTEDIT_Click(object sender, EventArgs e)
        {
            if (eindex < 0 || eindex >= ds.Tables["ViewOwner"].Rows.Count) return;

            DialogResult dl = MessageBox.Show("ต้องการแก้ไขไหม?", "ยืนยันการแก้ไขข้อมุล", MessageBoxButtons.YesNo);
            if (dl == DialogResult.Yes)
            {
                DataRow dr = ds.Tables["ViewOwner"].Rows[eindex];
                dr["IDowner"] = LBID.Text;
                dr["UserLogin"] = TBNAME.Text;
                dr["PassLogin"] = TBPassword.Text;
                Updatedata();
                UpdateView();
                MessageBox.Show("แก้ไขข้อมูลเสร็จสิ้น", "ยืนยันการแก้ไข");

              
            }
            BTEDIT.Enabled = false;
            BTDEL.Enabled = false;
        }



       



        private void DTGV_CT_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataRow dr = ds.Tables["ViewOwner"].Rows[eindex];
            eindex = e.RowIndex;
            LBID.Text = dr["IDowner"].ToString();
            TBNAME.Text = dr["UserLogin"].ToString();
            TBPassword.Text = dr["PassLogin"].ToString();
            BTDEL.Enabled = true;
            BTEDIT.Enabled = true;

        }
        int eindex;
        private void DTGV_CT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            eindex = e.RowIndex;
        }

        private void BTDEL_Click(object sender, EventArgs e)
        {
             if (eindex < 0 || eindex >= ds.Tables["ViewOwner"].Rows.Count) return;

            DialogResult dl = MessageBox.Show("ต้องการแก้ไขไหม?", "ยืนยันการแก้ไขข้อมุล", MessageBoxButtons.YesNo);
            if (dl == DialogResult.Yes)
            {
                DataRow dr = ds.Tables["ViewOwner"].Rows[eindex];
                dr.Delete();
                Updatedata();
                UpdateView();
                MessageBox.Show("ลบข้อมูลเสร็จสิ้น", "ยืนยันการลบ");
            }
            BTEDIT.Enabled = false;
            BTDEL.Enabled = false;
        }

        private void BTRESET_Click(object sender, EventArgs e)
        {
   
            LBID.Text = "";
            TBNAME.Text = "";
            TBPassword.Text = "";
            TBSR.Text = "";
      
        }

        private void BTSR_Click(object sender, EventArgs e)
        {
            if (ds.Tables.Contains("ViewOwner"))
            {
                ds.Tables.Remove("ViewOwner");
            }
            string sql = "SELECT* FROM View_Owner WHERE IDowner LIKE @searchText OR UserLogin LIKE @searchText ";
            using (SqlDataAdapter da = new SqlDataAdapter(sql, Formmain.DATA))
            {
                da.SelectCommand.Parameters.AddWithValue("@searchText", "%" + TBSR.Text + "%");
                da.Fill(ds, "ViewOwner");
                DTGV_CT.DataSource = ds.Tables["ViewOwner"];
            }
        }

        private void DTGV_CT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       




    }
}