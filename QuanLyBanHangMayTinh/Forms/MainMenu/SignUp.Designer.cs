namespace QuanLyBanHangMayTinh.Forms
{
    partial class SignUp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.btn_SignUp = new System.Windows.Forms.Button();
            this.panel_password = new System.Windows.Forms.Panel();
            this.txtBox_password = new System.Windows.Forms.TextBox();
            this.panel_username = new System.Windows.Forms.Panel();
            this.txtBox_username = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_reenter = new System.Windows.Forms.Panel();
            this.txtBox_reenterpassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.animation_btnBack = new System.Windows.Forms.ImageList(this.components);
            this.wrong_reenter = new System.Windows.Forms.Label();
            this.wrong_password = new System.Windows.Forms.Label();
            this.wrong_username = new System.Windows.Forms.Label();
            this.Update = new System.Windows.Forms.Timer(this.components);
            this.true_info = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel_password.SuspendLayout();
            this.panel_username.SuspendLayout();
            this.panel_reenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_SignUp
            // 
            this.btn_SignUp.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_SignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SignUp.Font = new System.Drawing.Font("Google Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SignUp.ForeColor = System.Drawing.Color.White;
            this.btn_SignUp.Location = new System.Drawing.Point(329, 520);
            this.btn_SignUp.Name = "btn_SignUp";
            this.btn_SignUp.Size = new System.Drawing.Size(205, 54);
            this.btn_SignUp.TabIndex = 16;
            this.btn_SignUp.Text = "Sign up";
            this.btn_SignUp.UseVisualStyleBackColor = false;
            this.btn_SignUp.Click += new System.EventHandler(this.btn_SignUp_Click);
            // 
            // panel_password
            // 
            this.panel_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_password.Controls.Add(this.txtBox_password);
            this.panel_password.Location = new System.Drawing.Point(104, 295);
            this.panel_password.Name = "panel_password";
            this.panel_password.Size = new System.Drawing.Size(348, 40);
            this.panel_password.TabIndex = 15;
            // 
            // txtBox_password
            // 
            this.txtBox_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_password.Font = new System.Drawing.Font("Google Sans", 14.25F);
            this.txtBox_password.Location = new System.Drawing.Point(5, 7);
            this.txtBox_password.Name = "txtBox_password";
            this.txtBox_password.PasswordChar = '•';
            this.txtBox_password.Size = new System.Drawing.Size(337, 24);
            this.txtBox_password.TabIndex = 7;
            // 
            // panel_username
            // 
            this.panel_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_username.Controls.Add(this.txtBox_username);
            this.panel_username.Location = new System.Drawing.Point(104, 190);
            this.panel_username.Name = "panel_username";
            this.panel_username.Size = new System.Drawing.Size(348, 39);
            this.panel_username.TabIndex = 14;
            // 
            // txtBox_username
            // 
            this.txtBox_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_username.Font = new System.Drawing.Font("Google Sans", 14.25F);
            this.txtBox_username.Location = new System.Drawing.Point(3, 6);
            this.txtBox_username.Name = "txtBox_username";
            this.txtBox_username.Size = new System.Drawing.Size(340, 24);
            this.txtBox_username.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Google Sans", 13F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(100, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(243, 29);
            this.label6.TabIndex = 13;
            this.label6.Text = "Password (at least 6)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Google Sans", 13F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(100, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(243, 37);
            this.label5.TabIndex = 12;
            this.label5.Text = "Your username (at least 5)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Google Sans", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(98, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 46);
            this.label2.TabIndex = 11;
            this.label2.Text = "Create an account";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Google Sans", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(16, 520);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 54);
            this.label1.TabIndex = 17;
            this.label1.Text = "Join us to get you the best goods with perfect price.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel_reenter
            // 
            this.panel_reenter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_reenter.Controls.Add(this.txtBox_reenterpassword);
            this.panel_reenter.Location = new System.Drawing.Point(104, 400);
            this.panel_reenter.Name = "panel_reenter";
            this.panel_reenter.Size = new System.Drawing.Size(348, 40);
            this.panel_reenter.TabIndex = 19;
            // 
            // txtBox_reenterpassword
            // 
            this.txtBox_reenterpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_reenterpassword.Font = new System.Drawing.Font("Google Sans", 14.25F);
            this.txtBox_reenterpassword.Location = new System.Drawing.Point(5, 7);
            this.txtBox_reenterpassword.Name = "txtBox_reenterpassword";
            this.txtBox_reenterpassword.PasswordChar = '•';
            this.txtBox_reenterpassword.Size = new System.Drawing.Size(337, 24);
            this.txtBox_reenterpassword.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Google Sans", 13F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(100, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 29);
            this.label3.TabIndex = 18;
            this.label3.Text = "Re-enter password";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.Transparent;
            this.btn_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Location = new System.Drawing.Point(12, 12);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(24, 24);
            this.btn_Back.TabIndex = 20;
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            this.btn_Back.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.btn_Back.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // animation_btnBack
            // 
            this.animation_btnBack.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("animation_btnBack.ImageStream")));
            this.animation_btnBack.TransparentColor = System.Drawing.Color.Transparent;
            this.animation_btnBack.Images.SetKeyName(0, "arrowNotClicked.png");
            this.animation_btnBack.Images.SetKeyName(1, "arrowClicked.png");
            this.animation_btnBack.Images.SetKeyName(2, "arrow.png");
            // 
            // wrong_reenter
            // 
            this.wrong_reenter.BackColor = System.Drawing.Color.Transparent;
            this.wrong_reenter.Font = new System.Drawing.Font("Google Sans", 10F, System.Drawing.FontStyle.Bold);
            this.wrong_reenter.ForeColor = System.Drawing.Color.IndianRed;
            this.wrong_reenter.Location = new System.Drawing.Point(101, 446);
            this.wrong_reenter.Name = "wrong_reenter";
            this.wrong_reenter.Size = new System.Drawing.Size(351, 29);
            this.wrong_reenter.TabIndex = 22;
            this.wrong_reenter.Text = "Re-enter password is not match";
            this.wrong_reenter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // wrong_password
            // 
            this.wrong_password.BackColor = System.Drawing.Color.Transparent;
            this.wrong_password.Font = new System.Drawing.Font("Google Sans", 10F, System.Drawing.FontStyle.Bold);
            this.wrong_password.ForeColor = System.Drawing.Color.IndianRed;
            this.wrong_password.Location = new System.Drawing.Point(101, 339);
            this.wrong_password.Name = "wrong_password";
            this.wrong_password.Size = new System.Drawing.Size(319, 29);
            this.wrong_password.TabIndex = 23;
            this.wrong_password.Text = "Password must contains at least 6 characters";
            this.wrong_password.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // wrong_username
            // 
            this.wrong_username.BackColor = System.Drawing.Color.Transparent;
            this.wrong_username.Font = new System.Drawing.Font("Google Sans", 10F, System.Drawing.FontStyle.Bold);
            this.wrong_username.ForeColor = System.Drawing.Color.IndianRed;
            this.wrong_username.Location = new System.Drawing.Point(101, 235);
            this.wrong_username.Name = "wrong_username";
            this.wrong_username.Size = new System.Drawing.Size(346, 29);
            this.wrong_username.TabIndex = 24;
            this.wrong_username.Text = "Username is invalid or it is taken";
            this.wrong_username.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Update
            // 
            this.Update.Enabled = true;
            this.Update.Tick += new System.EventHandler(this.Update_Tick);
            // 
            // true_info
            // 
            this.true_info.BackColor = System.Drawing.Color.Transparent;
            this.true_info.Font = new System.Drawing.Font("Google Sans", 10F, System.Drawing.FontStyle.Bold);
            this.true_info.ForeColor = System.Drawing.Color.Lime;
            this.true_info.Location = new System.Drawing.Point(387, 488);
            this.true_info.Name = "true_info";
            this.true_info.Size = new System.Drawing.Size(147, 29);
            this.true_info.TabIndex = 25;
            this.true_info.Text = "Sign up successfully";
            this.true_info.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::QuanLyBanHangMayTinh.Properties.Resources.astronaut;
            this.pictureBox4.Location = new System.Drawing.Point(390, 580);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(91, 91);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 32;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::QuanLyBanHangMayTinh.Properties.Resources.star;
            this.pictureBox3.Location = new System.Drawing.Point(-17, 571);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 31;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QuanLyBanHangMayTinh.Properties.Resources.launch;
            this.pictureBox2.Location = new System.Drawing.Point(498, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 59);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 600);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.true_info);
            this.Controls.Add(this.wrong_username);
            this.Controls.Add(this.wrong_password);
            this.Controls.Add(this.wrong_reenter);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.panel_reenter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_SignUp);
            this.Controls.Add(this.panel_password);
            this.Controls.Add(this.panel_username);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SignUp_KeyDown);
            this.panel_password.ResumeLayout(false);
            this.panel_password.PerformLayout();
            this.panel_username.ResumeLayout(false);
            this.panel_username.PerformLayout();
            this.panel_reenter.ResumeLayout(false);
            this.panel_reenter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_SignUp;
        private System.Windows.Forms.Panel panel_password;
        private System.Windows.Forms.TextBox txtBox_password;
        private System.Windows.Forms.Panel panel_username;
        private System.Windows.Forms.TextBox txtBox_username;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_reenter;
        private System.Windows.Forms.TextBox txtBox_reenterpassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.ImageList animation_btnBack;
        private System.Windows.Forms.Label wrong_reenter;
        private System.Windows.Forms.Label wrong_password;
        private System.Windows.Forms.Label wrong_username;
        private System.Windows.Forms.Timer Update;
        private System.Windows.Forms.Label true_info;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}