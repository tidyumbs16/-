namespace NewjjenladongBONG
{
    partial class Formmain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ฐานขอมาลToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ผดแลระบบToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.อาหารToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.เครองดมToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ของหวานToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.สมาชกToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ฐานขอมาลToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1308, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ฐานขอมาลToolStripMenuItem
            // 
            this.ฐานขอมาลToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ผดแลระบบToolStripMenuItem,
            this.อาหารToolStripMenuItem,
            this.เครองดมToolStripMenuItem,
            this.ของหวานToolStripMenuItem,
            this.สมาชกToolStripMenuItem});
            this.ฐานขอมาลToolStripMenuItem.Name = "ฐานขอมาลToolStripMenuItem";
            this.ฐานขอมาลToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.ฐานขอมาลToolStripMenuItem.Text = "ฐานข้อมูล";
            // 
            // ผดแลระบบToolStripMenuItem
            // 
            this.ผดแลระบบToolStripMenuItem.Name = "ผดแลระบบToolStripMenuItem";
            this.ผดแลระบบToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.ผดแลระบบToolStripMenuItem.Text = "ผู้ดูแลระบบ";
            this.ผดแลระบบToolStripMenuItem.Click += new System.EventHandler(this.ผดแลระบบToolStripMenuItem_Click);
            // 
            // อาหารToolStripMenuItem
            // 
            this.อาหารToolStripMenuItem.Name = "อาหารToolStripMenuItem";
            this.อาหารToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.อาหารToolStripMenuItem.Text = "อาหาร";
            // 
            // เครองดมToolStripMenuItem
            // 
            this.เครองดมToolStripMenuItem.Name = "เครองดมToolStripMenuItem";
            this.เครองดมToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.เครองดมToolStripMenuItem.Text = "เครื่องดื่ม";
            // 
            // ของหวานToolStripMenuItem
            // 
            this.ของหวานToolStripMenuItem.Name = "ของหวานToolStripMenuItem";
            this.ของหวานToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.ของหวานToolStripMenuItem.Text = "ของหวาน";
            this.ของหวานToolStripMenuItem.Click += new System.EventHandler(this.ของหวานToolStripMenuItem_Click);
            // 
            // สมาชกToolStripMenuItem
            // 
            this.สมาชกToolStripMenuItem.Name = "สมาชกToolStripMenuItem";
            this.สมาชกToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.สมาชกToolStripMenuItem.Text = "สมาชิก";
            this.สมาชกToolStripMenuItem.Click += new System.EventHandler(this.สมาชกToolStripMenuItem_Click);
            // 
            // Formmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1308, 672);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Formmain";
            this.Text = "โปรแกรมจัดการร้านอาหาร";
            this.Load += new System.EventHandler(this.Formmain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ฐานขอมาลToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ผดแลระบบToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem อาหารToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem เครองดมToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ของหวานToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem สมาชกToolStripMenuItem;
    }
}

