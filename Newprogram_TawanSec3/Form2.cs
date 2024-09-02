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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void BTLOG_Click(object sender, EventArgs e)
        {
            string sql = string.Format("SELECT * FROM TBL_ADDMIN WHERE UserName = '{0}' AND Password = '{1}'", TBuser.Text, TB2Password.Text);
            SqlDataAdapter da = new SqlDataAdapter(sql, Form1.DATA);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                string name = dt.Rows[0]["UserName"].ToString();
                MessageBox.Show("ยินดีต้อนรับ คูณ" + name, "LOGINSUCSESS");
                Form1.loginstat = "1";
                this.Close();
            }
            else
            {
                MessageBox.Show("USER OR PASSWORD ผิด", "ERORR");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                TB2Password.PasswordChar = '\0';
            }
            else
            {
                TB2Password.PasswordChar = '*';
            }
        }
    }
}

