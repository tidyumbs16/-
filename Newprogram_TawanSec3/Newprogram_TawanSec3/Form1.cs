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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string DATA = "Data Source =.;Database= TawanData3; Trusted_Connection=True;"; 
        public static string loginstat = " ";
        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 FLG2 = new Form2();
            FLG2.ShowDialog();
            if (loginstat == "")
            {
                Application.Exit();
            } 
        }
        private void CloseForm(Form fop)
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
            Form3 FCT = new Form3();
            CloseForm(FCT);
        }
    }
}

