namespace NewjjenladongBONG
{
    partial class FormFood
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
            this.label2 = new System.Windows.Forms.Label();
            this.DTGV_CT = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DTGV_CT)).BeginInit();
            this.SuspendLayout();
            // 
            // BTRESET
            // 
            this.BTRESET.Location = new System.Drawing.Point(327, 429);
            this.BTRESET.Name = "BTRESET";
            this.BTRESET.Size = new System.Drawing.Size(81, 55);
            this.BTRESET.TabIndex = 65;
            this.BTRESET.Text = "ยกเลิก";
            this.BTRESET.UseVisualStyleBackColor = true;
            // 
            // BTGENID
            // 
            this.BTGENID.Location = new System.Drawing.Point(219, 82);
            this.BTGENID.Name = "BTGENID";
            this.BTGENID.Size = new System.Drawing.Size(70, 36);
            this.BTGENID.TabIndex = 64;
            this.BTGENID.Text = "สร้างเลข";
            this.BTGENID.UseVisualStyleBackColor = true;
            // 
            // LBID
            // 
            this.LBID.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.LBID.Location = new System.Drawing.Point(128, 86);
            this.LBID.Name = "LBID";
            this.LBID.Size = new System.Drawing.Size(55, 36);
            this.LBID.TabIndex = 63;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(106, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 20);
            this.label9.TabIndex = 62;
            this.label9.Text = "ชื่อ";
            // 
            // TBSR
            // 
            this.TBSR.Location = new System.Drawing.Point(155, 187);
            this.TBSR.Multiline = true;
            this.TBSR.Name = "TBSR";
            this.TBSR.Size = new System.Drawing.Size(198, 27);
            this.TBSR.TabIndex = 61;
            // 
            // BTSR
            // 
            this.BTSR.Location = new System.Drawing.Point(847, 74);
            this.BTSR.Name = "BTSR";
            this.BTSR.Size = new System.Drawing.Size(77, 27);
            this.BTSR.TabIndex = 60;
            this.BTSR.Text = "ค้นหา";
            this.BTSR.UseVisualStyleBackColor = true;
            // 
            // BTDEL
            // 
            this.BTDEL.Location = new System.Drawing.Point(231, 429);
            this.BTDEL.Name = "BTDEL";
            this.BTDEL.Size = new System.Drawing.Size(81, 55);
            this.BTDEL.TabIndex = 59;
            this.BTDEL.Text = "ลบข้อมูล";
            this.BTDEL.UseVisualStyleBackColor = true;
            // 
            // BTEDIT
            // 
            this.BTEDIT.Location = new System.Drawing.Point(131, 429);
            this.BTEDIT.Name = "BTEDIT";
            this.BTEDIT.Size = new System.Drawing.Size(81, 55);
            this.BTEDIT.TabIndex = 58;
            this.BTEDIT.Text = "แก้ไขข้อมูล";
            this.BTEDIT.UseVisualStyleBackColor = true;
            // 
            // BTADD
            // 
            this.BTADD.Location = new System.Drawing.Point(31, 429);
            this.BTADD.Name = "BTADD";
            this.BTADD.Size = new System.Drawing.Size(81, 55);
            this.BTADD.TabIndex = 57;
            this.BTADD.Text = "เพิ่มข้อมูล";
            this.BTADD.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 24);
            this.label2.TabIndex = 53;
            this.label2.Text = "เลขสมาชิก";
            // 
            // DTGV_CT
            // 
            this.DTGV_CT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGV_CT.Location = new System.Drawing.Point(470, 156);
            this.DTGV_CT.Name = "DTGV_CT";
            this.DTGV_CT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DTGV_CT.Size = new System.Drawing.Size(552, 446);
            this.DTGV_CT.TabIndex = 51;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(155, 325);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 27);
            this.textBox1.TabIndex = 66;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(155, 260);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(198, 21);
            this.comboBox1.TabIndex = 67;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(603, 74);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(198, 27);
            this.textBox2.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 69;
            this.label1.Text = "ประเภท";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(106, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 70;
            this.label3.Text = "ราคา";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(518, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 71;
            this.label4.Text = "ค้นหา";
            // 
            // FormFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 707);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BTRESET);
            this.Controls.Add(this.BTGENID);
            this.Controls.Add(this.LBID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TBSR);
            this.Controls.Add(this.BTSR);
            this.Controls.Add(this.BTDEL);
            this.Controls.Add(this.BTEDIT);
            this.Controls.Add(this.BTADD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DTGV_CT);
            this.Name = "FormFood";
            this.Text = "FormFood";
            this.Load += new System.EventHandler(this.FormFood_Load);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DTGV_CT;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}