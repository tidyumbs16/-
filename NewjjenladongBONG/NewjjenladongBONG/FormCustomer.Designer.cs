namespace NewjjenladongBONG
{
    partial class FormCustomer
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
            this.DTGV_CT = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TBNAME = new System.Windows.Forms.TextBox();
            this.TBSNAME = new System.Windows.Forms.TextBox();
            this.BTADD = new System.Windows.Forms.Button();
            this.BTEDIT = new System.Windows.Forms.Button();
            this.BTDEL = new System.Windows.Forms.Button();
            this.BTSR = new System.Windows.Forms.Button();
            this.TBSR = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.LBID = new System.Windows.Forms.Label();
            this.BTGENID = new System.Windows.Forms.Button();
            this.BTRESET = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CBMEMBER = new System.Windows.Forms.ComboBox();
            this.CBSEX = new System.Windows.Forms.ComboBox();
            this.TBTEL = new System.Windows.Forms.TextBox();
            this.DTBD = new System.Windows.Forms.DateTimePicker();
            this.TBADDESS = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DTGV_CT)).BeginInit();
            this.SuspendLayout();
            // 
            // DTGV_CT
            // 
            this.DTGV_CT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGV_CT.Location = new System.Drawing.Point(488, 61);
            this.DTGV_CT.Name = "DTGV_CT";
            this.DTGV_CT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DTGV_CT.Size = new System.Drawing.Size(829, 692);
            this.DTGV_CT.TabIndex = 0;
            this.DTGV_CT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTGV_CT_CellClick);
            this.DTGV_CT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTGV_CT_CellContentClick);
            this.DTGV_CT.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTGV_CT_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "เลขสมาชิก";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "ชื่อ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(212, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "นามสกุล";
            // 
            // TBNAME
            // 
            this.TBNAME.Location = new System.Drawing.Point(42, 61);
            this.TBNAME.Multiline = true;
            this.TBNAME.Name = "TBNAME";
            this.TBNAME.Size = new System.Drawing.Size(164, 27);
            this.TBNAME.TabIndex = 10;
            this.TBNAME.TextChanged += new System.EventHandler(this.TBNAME_TextChanged);
            // 
            // TBSNAME
            // 
            this.TBSNAME.Location = new System.Drawing.Point(288, 61);
            this.TBSNAME.Multiline = true;
            this.TBSNAME.Name = "TBSNAME";
            this.TBSNAME.Size = new System.Drawing.Size(164, 27);
            this.TBSNAME.TabIndex = 11;
            // 
            // BTADD
            // 
            this.BTADD.Location = new System.Drawing.Point(23, 364);
            this.BTADD.Name = "BTADD";
            this.BTADD.Size = new System.Drawing.Size(81, 55);
            this.BTADD.TabIndex = 17;
            this.BTADD.Text = "เพิ่มข้อมูล";
            this.BTADD.UseVisualStyleBackColor = true;
            this.BTADD.Click += new System.EventHandler(this.BTADD_Click);
            // 
            // BTEDIT
            // 
            this.BTEDIT.Location = new System.Drawing.Point(127, 364);
            this.BTEDIT.Name = "BTEDIT";
            this.BTEDIT.Size = new System.Drawing.Size(81, 55);
            this.BTEDIT.TabIndex = 18;
            this.BTEDIT.Text = "แก้ไขข้อมูล";
            this.BTEDIT.UseVisualStyleBackColor = true;
            this.BTEDIT.Click += new System.EventHandler(this.BTEDIT_Click);
            // 
            // BTDEL
            // 
            this.BTDEL.Location = new System.Drawing.Point(231, 364);
            this.BTDEL.Name = "BTDEL";
            this.BTDEL.Size = new System.Drawing.Size(81, 55);
            this.BTDEL.TabIndex = 19;
            this.BTDEL.Text = "ลบข้อมูล";
            this.BTDEL.UseVisualStyleBackColor = true;
            this.BTDEL.Click += new System.EventHandler(this.BTDEL_Click);
            // 
            // BTSR
            // 
            this.BTSR.Location = new System.Drawing.Point(743, 28);
            this.BTSR.Name = "BTSR";
            this.BTSR.Size = new System.Drawing.Size(77, 27);
            this.BTSR.TabIndex = 20;
            this.BTSR.Text = "ค้นหา";
            this.BTSR.UseVisualStyleBackColor = true;
            this.BTSR.Click += new System.EventHandler(this.BTSR_Click);
            // 
            // TBSR
            // 
            this.TBSR.Location = new System.Drawing.Point(539, 28);
            this.TBSR.Multiline = true;
            this.TBSR.Name = "TBSR";
            this.TBSR.Size = new System.Drawing.Size(198, 27);
            this.TBSR.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(490, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "ค้นหา";
            // 
            // LBID
            // 
            this.LBID.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.LBID.Location = new System.Drawing.Point(321, 16);
            this.LBID.Name = "LBID";
            this.LBID.Size = new System.Drawing.Size(55, 36);
            this.LBID.TabIndex = 23;
            // 
            // BTGENID
            // 
            this.BTGENID.Location = new System.Drawing.Point(382, 16);
            this.BTGENID.Name = "BTGENID";
            this.BTGENID.Size = new System.Drawing.Size(70, 36);
            this.BTGENID.TabIndex = 24;
            this.BTGENID.Text = "สร้างเลขสมาชิก";
            this.BTGENID.UseVisualStyleBackColor = true;
            this.BTGENID.Click += new System.EventHandler(this.BTGENID_Click);
            // 
            // BTRESET
            // 
            this.BTRESET.Location = new System.Drawing.Point(346, 364);
            this.BTRESET.Name = "BTRESET";
            this.BTRESET.Size = new System.Drawing.Size(81, 55);
            this.BTRESET.TabIndex = 25;
            this.BTRESET.Text = "ยกเลิก";
            this.BTRESET.UseVisualStyleBackColor = true;
            this.BTRESET.Click += new System.EventHandler(this.BTRESET_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "ที่อยู่";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(103, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "เพศ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(212, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "เบอร์โทร";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(225, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "วันเกิด";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "ระดับสมาชิก";
            // 
            // CBMEMBER
            // 
            this.CBMEMBER.FormattingEnabled = true;
            this.CBMEMBER.Location = new System.Drawing.Point(115, 309);
            this.CBMEMBER.Name = "CBMEMBER";
            this.CBMEMBER.Size = new System.Drawing.Size(93, 21);
            this.CBMEMBER.TabIndex = 16;
            // 
            // CBSEX
            // 
            this.CBSEX.FormattingEnabled = true;
            this.CBSEX.Location = new System.Drawing.Point(147, 102);
            this.CBSEX.Name = "CBSEX";
            this.CBSEX.Size = new System.Drawing.Size(63, 21);
            this.CBSEX.TabIndex = 13;
            // 
            // TBTEL
            // 
            this.TBTEL.Location = new System.Drawing.Point(288, 99);
            this.TBTEL.MaxLength = 10;
            this.TBTEL.Multiline = true;
            this.TBTEL.Name = "TBTEL";
            this.TBTEL.Size = new System.Drawing.Size(164, 25);
            this.TBTEL.TabIndex = 14;
            // 
            // DTBD
            // 
            this.DTBD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTBD.Location = new System.Drawing.Point(288, 141);
            this.DTBD.Name = "DTBD";
            this.DTBD.Size = new System.Drawing.Size(164, 20);
            this.DTBD.TabIndex = 15;
            // 
            // TBADDESS
            // 
            this.TBADDESS.Location = new System.Drawing.Point(25, 211);
            this.TBADDESS.Multiline = true;
            this.TBADDESS.Name = "TBADDESS";
            this.TBADDESS.Size = new System.Drawing.Size(417, 67);
            this.TBADDESS.TabIndex = 12;
            // 
            // FormCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 760);
            this.Controls.Add(this.BTRESET);
            this.Controls.Add(this.BTGENID);
            this.Controls.Add(this.LBID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TBSR);
            this.Controls.Add(this.BTSR);
            this.Controls.Add(this.BTDEL);
            this.Controls.Add(this.BTEDIT);
            this.Controls.Add(this.BTADD);
            this.Controls.Add(this.CBMEMBER);
            this.Controls.Add(this.DTBD);
            this.Controls.Add(this.TBTEL);
            this.Controls.Add(this.CBSEX);
            this.Controls.Add(this.TBADDESS);
            this.Controls.Add(this.TBSNAME);
            this.Controls.Add(this.TBNAME);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DTGV_CT);
            this.Name = "FormCustomer";
            this.Text = "FormCustomer";
            this.Load += new System.EventHandler(this.FormCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTGV_CT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DTGV_CT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBNAME;
        private System.Windows.Forms.TextBox TBSNAME;
        private System.Windows.Forms.Button BTADD;
        private System.Windows.Forms.Button BTEDIT;
        private System.Windows.Forms.Button BTDEL;
        private System.Windows.Forms.Button BTSR;
        private System.Windows.Forms.TextBox TBSR;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LBID;
        private System.Windows.Forms.Button BTGENID;
        private System.Windows.Forms.Button BTRESET;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CBMEMBER;
        private System.Windows.Forms.ComboBox CBSEX;
        private System.Windows.Forms.TextBox TBTEL;
        private System.Windows.Forms.DateTimePicker DTBD;
        private System.Windows.Forms.TextBox TBADDESS;
    }
}