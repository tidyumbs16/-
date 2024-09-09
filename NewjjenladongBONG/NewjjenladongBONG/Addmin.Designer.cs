namespace NewjjenladongBONG
{
    partial class Addmin
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
            this.BTRESET = new System.Windows.Forms.Button();
            this.BTGENID = new System.Windows.Forms.Button();
            this.LBID = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TBSR = new System.Windows.Forms.TextBox();
            this.BTSR = new System.Windows.Forms.Button();
            this.BTDEL = new System.Windows.Forms.Button();
            this.BTEDIT = new System.Windows.Forms.Button();
            this.BTADD = new System.Windows.Forms.Button();
            this.TBPassword = new System.Windows.Forms.TextBox();
            this.TBNAME = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DTGV_CT = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DTGV_CT)).BeginInit();
            this.SuspendLayout();
            // 
            // BTRESET
            // 
            this.BTRESET.Location = new System.Drawing.Point(407, 306);
            this.BTRESET.Name = "BTRESET";
            this.BTRESET.Size = new System.Drawing.Size(81, 55);
            this.BTRESET.TabIndex = 50;
            this.BTRESET.Text = "ยกเลิก";
            this.BTRESET.UseVisualStyleBackColor = true;
            this.BTRESET.Click += new System.EventHandler(this.BTRESET_Click);
            // 
            // BTGENID
            // 
            this.BTGENID.Location = new System.Drawing.Point(501, 45);
            this.BTGENID.Name = "BTGENID";
            this.BTGENID.Size = new System.Drawing.Size(70, 36);
            this.BTGENID.TabIndex = 49;
            this.BTGENID.Text = "สร้างเลขสมาชิก";
            this.BTGENID.UseVisualStyleBackColor = true;
            this.BTGENID.Click += new System.EventHandler(this.BTGENID_Click);
            // 
            // LBID
            // 
            this.LBID.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.LBID.Location = new System.Drawing.Point(440, 45);
            this.LBID.Name = "LBID";
            this.LBID.Size = new System.Drawing.Size(55, 36);
            this.LBID.TabIndex = 48;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(124, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 20);
            this.label9.TabIndex = 47;
            this.label9.Text = "ค้นหา";
            // 
            // TBSR
            // 
            this.TBSR.Location = new System.Drawing.Point(173, 113);
            this.TBSR.Multiline = true;
            this.TBSR.Name = "TBSR";
            this.TBSR.Size = new System.Drawing.Size(198, 27);
            this.TBSR.TabIndex = 46;
            // 
            // BTSR
            // 
            this.BTSR.Location = new System.Drawing.Point(377, 113);
            this.BTSR.Name = "BTSR";
            this.BTSR.Size = new System.Drawing.Size(77, 27);
            this.BTSR.TabIndex = 45;
            this.BTSR.Text = "ค้นหา";
            this.BTSR.UseVisualStyleBackColor = true;
            this.BTSR.Click += new System.EventHandler(this.BTSR_Click);
            // 
            // BTDEL
            // 
            this.BTDEL.Location = new System.Drawing.Point(303, 306);
            this.BTDEL.Name = "BTDEL";
            this.BTDEL.Size = new System.Drawing.Size(81, 55);
            this.BTDEL.TabIndex = 44;
            this.BTDEL.Text = "ลบข้อมูล";
            this.BTDEL.UseVisualStyleBackColor = true;
            this.BTDEL.Click += new System.EventHandler(this.BTDEL_Click);
            // 
            // BTEDIT
            // 
            this.BTEDIT.Location = new System.Drawing.Point(195, 306);
            this.BTEDIT.Name = "BTEDIT";
            this.BTEDIT.Size = new System.Drawing.Size(81, 55);
            this.BTEDIT.TabIndex = 43;
            this.BTEDIT.Text = "แก้ไขข้อมูล";
            this.BTEDIT.UseVisualStyleBackColor = true;
            this.BTEDIT.Click += new System.EventHandler(this.BTEDIT_Click);
            // 
            // BTADD
            // 
            this.BTADD.Location = new System.Drawing.Point(84, 306);
            this.BTADD.Name = "BTADD";
            this.BTADD.Size = new System.Drawing.Size(81, 55);
            this.BTADD.TabIndex = 42;
            this.BTADD.Text = "เพิ่มข้อมูล";
            this.BTADD.UseVisualStyleBackColor = true;
            this.BTADD.Click += new System.EventHandler(this.BTADD_Click);
            // 
            // TBPassword
            // 
            this.TBPassword.Location = new System.Drawing.Point(407, 12);
            this.TBPassword.Multiline = true;
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.Size = new System.Drawing.Size(164, 27);
            this.TBPassword.TabIndex = 36;
            // 
            // TBNAME
            // 
            this.TBNAME.Location = new System.Drawing.Point(161, 12);
            this.TBNAME.Multiline = true;
            this.TBNAME.Name = "TBNAME";
            this.TBNAME.Size = new System.Drawing.Size(164, 27);
            this.TBNAME.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(351, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 24);
            this.label3.TabIndex = 29;
            this.label3.Text = "Pass";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 24);
            this.label2.TabIndex = 28;
            this.label2.Text = "UseAdmin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(359, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "IDAdmin";
            // 
            // DTGV_CT
            // 
            this.DTGV_CT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGV_CT.Location = new System.Drawing.Point(113, 161);
            this.DTGV_CT.Name = "DTGV_CT";
            this.DTGV_CT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DTGV_CT.Size = new System.Drawing.Size(331, 124);
            this.DTGV_CT.TabIndex = 26;
            this.DTGV_CT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTGV_CT_CellClick);
            this.DTGV_CT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTGV_CT_CellContentClick);
            this.DTGV_CT.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTGV_CT_CellDoubleClick);
            // 
            // Addmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 391);
            this.Controls.Add(this.BTRESET);
            this.Controls.Add(this.BTGENID);
            this.Controls.Add(this.LBID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TBSR);
            this.Controls.Add(this.BTSR);
            this.Controls.Add(this.BTDEL);
            this.Controls.Add(this.BTEDIT);
            this.Controls.Add(this.BTADD);
            this.Controls.Add(this.TBPassword);
            this.Controls.Add(this.TBNAME);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DTGV_CT);
            this.Name = "Addmin";
            this.Text = "Addmin";
            this.Load += new System.EventHandler(this.Addmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTGV_CT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTRESET;
        private System.Windows.Forms.Button BTGENID;
        private System.Windows.Forms.Label LBID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TBSR;
        private System.Windows.Forms.Button BTSR;
        private System.Windows.Forms.Button BTDEL;
        private System.Windows.Forms.Button BTEDIT;
        private System.Windows.Forms.Button BTADD;
        private System.Windows.Forms.TextBox TBPassword;
        private System.Windows.Forms.TextBox TBNAME;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DTGV_CT;
    }
}