namespace QuanLyBanHangMayTinh.Forms
{
    partial class FormNhanVien
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
            this.btn_Reset = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv_tblNhanVien = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtBox_employeePN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rdBtn_Female = new System.Windows.Forms.RadioButton();
            this.rdBtn_Male = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBox_employeeName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.panel_0 = new System.Windows.Forms.Panel();
            this.txtBox_employeeID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.datePicker_Birth = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.datePicker_StartDate = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBox_employeeDefault = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtBox_employeeCoefficent = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtBox_employeeAllowance = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_print = new System.Windows.Forms.Button();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tblNhanVien)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_0.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reset.Font = new System.Drawing.Font("Google Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.ForeColor = System.Drawing.Color.White;
            this.btn_Reset.Location = new System.Drawing.Point(29, 911);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(98, 39);
            this.btn_Reset.TabIndex = 47;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Google Sans", 22F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(360, 55);
            this.label6.TabIndex = 46;
            this.label6.Text = "Employee Management";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgv_tblNhanVien
            // 
            this.dgv_tblNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tblNhanVien.Location = new System.Drawing.Point(648, 45);
            this.dgv_tblNhanVien.Name = "dgv_tblNhanVien";
            this.dgv_tblNhanVien.Size = new System.Drawing.Size(788, 925);
            this.dgv_tblNhanVien.TabIndex = 45;
            this.dgv_tblNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tblNhanVien_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtBox_employeePN);
            this.panel3.Location = new System.Drawing.Point(29, 469);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 39);
            this.panel3.TabIndex = 44;
            // 
            // txtBox_employeePN
            // 
            this.txtBox_employeePN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_employeePN.Font = new System.Drawing.Font("Google Sans", 14.25F);
            this.txtBox_employeePN.Location = new System.Drawing.Point(5, 7);
            this.txtBox_employeePN.Name = "txtBox_employeePN";
            this.txtBox_employeePN.Size = new System.Drawing.Size(185, 24);
            this.txtBox_employeePN.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Google Sans", 13F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(27, 436);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 37);
            this.label3.TabIndex = 42;
            this.label3.Text = "Phone number";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rdBtn_Female
            // 
            this.rdBtn_Female.AutoSize = true;
            this.rdBtn_Female.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdBtn_Female.Font = new System.Drawing.Font("Google Sans", 13.25F, System.Drawing.FontStyle.Bold);
            this.rdBtn_Female.ForeColor = System.Drawing.Color.Gray;
            this.rdBtn_Female.Location = new System.Drawing.Point(370, 469);
            this.rdBtn_Female.Name = "rdBtn_Female";
            this.rdBtn_Female.Size = new System.Drawing.Size(89, 27);
            this.rdBtn_Female.TabIndex = 43;
            this.rdBtn_Female.TabStop = true;
            this.rdBtn_Female.Text = "Female";
            this.rdBtn_Female.UseVisualStyleBackColor = true;
            // 
            // rdBtn_Male
            // 
            this.rdBtn_Male.AutoSize = true;
            this.rdBtn_Male.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdBtn_Male.Font = new System.Drawing.Font("Google Sans", 13.25F, System.Drawing.FontStyle.Bold);
            this.rdBtn_Male.ForeColor = System.Drawing.Color.Gray;
            this.rdBtn_Male.Location = new System.Drawing.Point(252, 469);
            this.rdBtn_Male.Name = "rdBtn_Male";
            this.rdBtn_Male.Size = new System.Drawing.Size(69, 27);
            this.rdBtn_Male.TabIndex = 41;
            this.rdBtn_Male.TabStop = true;
            this.rdBtn_Male.Text = "Male";
            this.rdBtn_Male.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtBox_employeeName);
            this.panel1.Location = new System.Drawing.Point(31, 372);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 39);
            this.panel1.TabIndex = 36;
            // 
            // txtBox_employeeName
            // 
            this.txtBox_employeeName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_employeeName.Font = new System.Drawing.Font("Google Sans", 14.25F);
            this.txtBox_employeeName.Location = new System.Drawing.Point(3, 6);
            this.txtBox_employeeName.Name = "txtBox_employeeName";
            this.txtBox_employeeName.Size = new System.Drawing.Size(420, 24);
            this.txtBox_employeeName.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Google Sans", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(29, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 37);
            this.label1.TabIndex = 34;
            this.label1.Text = "Employee Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Google Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Location = new System.Drawing.Point(209, 152);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(145, 54);
            this.btn_Search.TabIndex = 38;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.Font = new System.Drawing.Font("Google Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.Color.White;
            this.btn_Update.Location = new System.Drawing.Point(33, 152);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(145, 54);
            this.btn_Update.TabIndex = 37;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("Google Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.Location = new System.Drawing.Point(209, 67);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(145, 54);
            this.btn_Delete.TabIndex = 35;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Insert
            // 
            this.btn_Insert.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Insert.Font = new System.Drawing.Font("Google Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Insert.ForeColor = System.Drawing.Color.White;
            this.btn_Insert.Location = new System.Drawing.Point(33, 67);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(145, 54);
            this.btn_Insert.TabIndex = 33;
            this.btn_Insert.Text = "Insert";
            this.btn_Insert.UseVisualStyleBackColor = false;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // panel_0
            // 
            this.panel_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_0.Controls.Add(this.txtBox_employeeID);
            this.panel_0.Location = new System.Drawing.Point(31, 275);
            this.panel_0.Name = "panel_0";
            this.panel_0.Size = new System.Drawing.Size(428, 39);
            this.panel_0.TabIndex = 32;
            // 
            // txtBox_employeeID
            // 
            this.txtBox_employeeID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_employeeID.Font = new System.Drawing.Font("Google Sans", 14.25F);
            this.txtBox_employeeID.Location = new System.Drawing.Point(3, 6);
            this.txtBox_employeeID.Name = "txtBox_employeeID";
            this.txtBox_employeeID.Size = new System.Drawing.Size(420, 24);
            this.txtBox_employeeID.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Google Sans", 13F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(29, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 37);
            this.label5.TabIndex = 31;
            this.label5.Text = "Employee ID";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // datePicker_Birth
            // 
            this.datePicker_Birth.Font = new System.Drawing.Font("Google Sans", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker_Birth.Location = new System.Drawing.Point(29, 526);
            this.datePicker_Birth.Name = "datePicker_Birth";
            this.datePicker_Birth.Size = new System.Drawing.Size(303, 29);
            this.datePicker_Birth.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Google Sans", 13F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(347, 524);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 37);
            this.label2.TabIndex = 49;
            this.label2.Text = "Date Of Birth";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Google Sans", 13F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(347, 572);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 37);
            this.label4.TabIndex = 51;
            this.label4.Text = "StartDate";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // datePicker_StartDate
            // 
            this.datePicker_StartDate.Font = new System.Drawing.Font("Google Sans", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker_StartDate.Location = new System.Drawing.Point(29, 574);
            this.datePicker_StartDate.Name = "datePicker_StartDate";
            this.datePicker_StartDate.Size = new System.Drawing.Size(303, 29);
            this.datePicker_StartDate.TabIndex = 50;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtBox_employeeDefault);
            this.panel2.Location = new System.Drawing.Point(29, 648);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 39);
            this.panel2.TabIndex = 46;
            // 
            // txtBox_employeeDefault
            // 
            this.txtBox_employeeDefault.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_employeeDefault.Font = new System.Drawing.Font("Google Sans", 14.25F);
            this.txtBox_employeeDefault.Location = new System.Drawing.Point(5, 7);
            this.txtBox_employeeDefault.Name = "txtBox_employeeDefault";
            this.txtBox_employeeDefault.Size = new System.Drawing.Size(185, 24);
            this.txtBox_employeeDefault.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Google Sans", 13F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(27, 615);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 37);
            this.label7.TabIndex = 45;
            this.label7.Text = "Default Salary";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.txtBox_employeeCoefficent);
            this.panel4.Location = new System.Drawing.Point(29, 733);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 39);
            this.panel4.TabIndex = 48;
            // 
            // txtBox_employeeCoefficent
            // 
            this.txtBox_employeeCoefficent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_employeeCoefficent.Font = new System.Drawing.Font("Google Sans", 14.25F);
            this.txtBox_employeeCoefficent.Location = new System.Drawing.Point(5, 7);
            this.txtBox_employeeCoefficent.Name = "txtBox_employeeCoefficent";
            this.txtBox_employeeCoefficent.Size = new System.Drawing.Size(185, 24);
            this.txtBox_employeeCoefficent.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Google Sans", 13F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(27, 700);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 37);
            this.label8.TabIndex = 47;
            this.label8.Text = "Coefficient";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.txtBox_employeeAllowance);
            this.panel5.Location = new System.Drawing.Point(29, 826);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 39);
            this.panel5.TabIndex = 50;
            // 
            // txtBox_employeeAllowance
            // 
            this.txtBox_employeeAllowance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_employeeAllowance.Font = new System.Drawing.Font("Google Sans", 14.25F);
            this.txtBox_employeeAllowance.Location = new System.Drawing.Point(5, 7);
            this.txtBox_employeeAllowance.Name = "txtBox_employeeAllowance";
            this.txtBox_employeeAllowance.Size = new System.Drawing.Size(185, 24);
            this.txtBox_employeeAllowance.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Google Sans", 13F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(27, 793);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(177, 37);
            this.label9.TabIndex = 49;
            this.label9.Text = "Allowance";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_print
            // 
            this.btn_print.BackColor = System.Drawing.Color.White;
            this.btn_print.FlatAppearance.BorderSize = 0;
            this.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_print.Font = new System.Drawing.Font("Google Sans", 14F, System.Drawing.FontStyle.Bold);
            this.btn_print.Location = new System.Drawing.Point(686, 6);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(66, 36);
            this.btn_print.TabIndex = 82;
            this.btn_print.Text = "Print";
            this.btn_print.UseVisualStyleBackColor = false;

            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::QuanLyBanHangMayTinh.Properties.Resources.printer__1_;
            this.pictureBox10.Location = new System.Drawing.Point(648, 6);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(32, 33);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 81;
            this.pictureBox10.TabStop = false;
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1457, 1000);
            this.ControlBox = false;
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.datePicker_StartDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datePicker_Birth);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgv_tblNhanVien);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rdBtn_Female);
            this.Controls.Add(this.rdBtn_Male);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.panel_0);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNhanVien";
            this.Text = "FormNhanVien";
            this.Load += new System.EventHandler(this.FormNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tblNhanVien)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_0.ResumeLayout(false);
            this.panel_0.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv_tblNhanVien;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtBox_employeePN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdBtn_Female;
        private System.Windows.Forms.RadioButton rdBtn_Male;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBox_employeeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Panel panel_0;
        private System.Windows.Forms.TextBox txtBox_employeeID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker datePicker_Birth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker datePicker_StartDate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtBox_employeeDefault;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtBox_employeeCoefficent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtBox_employeeAllowance;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.PictureBox pictureBox10;
    }
}