namespace NewjjenladongBONG
{
    partial class FormLogin
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
            this.label2 = new System.Windows.Forms.Label();
            this.TBUSERNAME = new System.Windows.Forms.TextBox();
            this.TBPASSWORD = new System.Windows.Forms.TextBox();
            this.BTLOGIN = new System.Windows.Forms.Button();
            this.CBPW = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(142, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // TBUSERNAME
            // 
            this.TBUSERNAME.Location = new System.Drawing.Point(146, 120);
            this.TBUSERNAME.Name = "TBUSERNAME";
            this.TBUSERNAME.Size = new System.Drawing.Size(100, 20);
            this.TBUSERNAME.TabIndex = 2;
            this.TBUSERNAME.TextChanged += new System.EventHandler(this.TBUSERNAME_TextChanged);
            // 
            // TBPASSWORD
            // 
            this.TBPASSWORD.Location = new System.Drawing.Point(146, 192);
            this.TBPASSWORD.Name = "TBPASSWORD";
            this.TBPASSWORD.PasswordChar = '*';
            this.TBPASSWORD.Size = new System.Drawing.Size(100, 20);
            this.TBPASSWORD.TabIndex = 3;
            // 
            // BTLOGIN
            // 
            this.BTLOGIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTLOGIN.Location = new System.Drawing.Point(146, 241);
            this.BTLOGIN.Name = "BTLOGIN";
            this.BTLOGIN.Size = new System.Drawing.Size(75, 35);
            this.BTLOGIN.TabIndex = 4;
            this.BTLOGIN.Text = "Login";
            this.BTLOGIN.UseVisualStyleBackColor = true;
            this.BTLOGIN.Click += new System.EventHandler(this.BTLOGIN_Click);
            // 
            // CBPW
            // 
            this.CBPW.AutoSize = true;
            this.CBPW.Location = new System.Drawing.Point(146, 218);
            this.CBPW.Name = "CBPW";
            this.CBPW.Size = new System.Drawing.Size(99, 17);
            this.CBPW.TabIndex = 5;
            this.CBPW.Text = "ShowPassword";
            this.CBPW.UseMnemonic = false;
            this.CBPW.UseVisualStyleBackColor = true;
            this.CBPW.CheckedChanged += new System.EventHandler(this.CBPW_CheckedChanged);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 411);
            this.Controls.Add(this.CBPW);
            this.Controls.Add(this.BTLOGIN);
            this.Controls.Add(this.TBPASSWORD);
            this.Controls.Add(this.TBUSERNAME);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBUSERNAME;
        private System.Windows.Forms.TextBox TBPASSWORD;
        private System.Windows.Forms.Button BTLOGIN;
        private System.Windows.Forms.CheckBox CBPW;
    }
}