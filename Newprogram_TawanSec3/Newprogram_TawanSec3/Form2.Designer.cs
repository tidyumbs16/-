namespace Newprogram_TawanSec3
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.TBpassword = new System.Windows.Forms.Label();
            this.TBuser = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.BTLOG = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserName";
            // 
            // TBpassword
            // 
            this.TBpassword.AutoSize = true;
            this.TBpassword.Location = new System.Drawing.Point(89, 212);
            this.TBpassword.Name = "TBpassword";
            this.TBpassword.Size = new System.Drawing.Size(56, 13);
            this.TBpassword.TabIndex = 1;
            this.TBpassword.Text = "PassWord";
            // 
            // TBuser
            // 
            this.TBuser.Location = new System.Drawing.Point(52, 105);
            this.TBuser.Multiline = true;
            this.TBuser.Name = "TBuser";
            this.TBuser.Size = new System.Drawing.Size(140, 25);
            this.TBuser.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(52, 228);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(140, 28);
            this.textBox2.TabIndex = 3;
            // 
            // BTLOG
            // 
            this.BTLOG.BackColor = System.Drawing.SystemColors.Highlight;
            this.BTLOG.Location = new System.Drawing.Point(66, 329);
            this.BTLOG.Name = "BTLOG";
            this.BTLOG.Size = new System.Drawing.Size(102, 34);
            this.BTLOG.TabIndex = 4;
            this.BTLOG.Text = "LOGIN";
            this.BTLOG.UseVisualStyleBackColor = false;
            this.BTLOG.Click += new System.EventHandler(this.BTLOG_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(70, 289);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "แสดงPassword";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(251, 603);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.BTLOG);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.TBuser);
            this.Controls.Add(this.TBpassword);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TBpassword;
        private System.Windows.Forms.TextBox TBuser;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button BTLOG;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}