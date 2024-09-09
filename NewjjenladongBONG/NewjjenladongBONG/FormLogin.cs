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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        

        private void BTLOGIN_Click(object sender, EventArgs e)
        {
            string sql = string.Format("SELECT * FROM TBL_Owner WHERE UserLogin ='{0}' AND PassLogin ='{1}'", TBUSERNAME.Text, TBPASSWORD.Text);
            SqlDataAdapter da = new SqlDataAdapter(sql, Formmain.DATA);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 1) 
            {
                string name = dt.Rows[0]["UserLogin"].ToString();
                MessageBox.Show("ยินดีต้อนรับ คุณ" + name, "Login สำเร็จ");
                Formmain.Loginstat = "1";
                this.Close();
            }
            else
            {
                MessageBox.Show("User หรือ Password ผิด", "Erorr");
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void CBPW_CheckedChanged(object sender, EventArgs e)
        {
            if (CBPW.Checked == true)
            {
                TBPASSWORD.PasswordChar = '\0';
            }
            else
            {
                TBPASSWORD.PasswordChar = '*';
            }

        }

        private void TBUSERNAME_TextChanged(object sender, EventArgs e)
        {

        }
       
    
        
    
    
        
    

    }
}

