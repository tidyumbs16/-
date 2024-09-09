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
    public partial class Formmain : Form
    {
        public Formmain()
        {
            InitializeComponent();
        }

        public static string DATA = "Data Source=.; Database = DATA3; Trusted_Connection=True;"; 
        public static string Loginstat = "";
        


        private void Formmain_Load(object sender, EventArgs e)
        {
            FormLogin FLI = new FormLogin();
            FLI.ShowDialog();
            if(Loginstat == "")
            {
                Application.Exit();
            }
        }

        public static SqlConnection data { get; set; }



        private void CloseFrom(Form fop)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name != fop.Name)
                {
                    f.Close();
                }
                else
                    return;
            }
            fop.MdiParent = this;
            fop.WindowState = FormWindowState.Maximized;
            fop.Show();

        }
        private void สมาชกToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCustomer FCT = new FormCustomer();
            CloseFrom(FCT);
        }

        private void ของหวานToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ผดแลระบบToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormLoginaddmin FLI = new FormLoginaddmin();
               Addmin FAD = new Addmin();
               CloseFrom(FAD);
            
            
        }
    }

  }      
    

