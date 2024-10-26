namespace QuanLyBanHangMayTinh.Forms
{
    partial class Login
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
            this.btn_signup = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.panel_password = new System.Windows.Forms.Panel();
            this.txtBox_password = new System.Windows.Forms.TextBox();
            this.panel_username = new System.Windows.Forms.Panel();
            this.txtBox_username = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.wrong_info = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_maximize = new System.Windows.Forms.Button();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_password.SuspendLayout();
            this.panel_username.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_signup
            // 
            this.btn_signup.BackColor = System.Drawing.Color.Transparent;
            this.btn_signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signup.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_signup.Location = new System.Drawing.Point(333, 543);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Size = new System.Drawing.Size(62, 37);
            this.btn_signup.TabIndex = 20;
            this.btn_signup.Text = "Sign Up";
            this.btn_signup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_signup.Click += new System.EventHandler(this.btn_signup_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.LightGray;
            this.label7.Location = new System.Drawing.Point(165, 543);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 37);
            this.label7.TabIndex = 19;
            this.label7.Text = "Don\'t have account yet?";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Login.Location = new System.Drawing.Point(96, 396);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(348, 54);
            this.btn_Login.TabIndex = 18;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            this.btn_Login.MouseEnter += new System.EventHandler(this.btn_Login_MouseEnter);
            this.btn_Login.MouseLeave += new System.EventHandler(this.btn_Login_MouseLeave);
            // 
            // panel_password
            // 
            this.panel_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_password.Controls.Add(this.txtBox_password);
            this.panel_password.Location = new System.Drawing.Point(96, 283);
            this.panel_password.Name = "panel_password";
            this.panel_password.Size = new System.Drawing.Size(348, 40);
            this.panel_password.TabIndex = 17;
            this.panel_password.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_password_Paint);
            // 
            // txtBox_password
            // 
            this.txtBox_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtBox_password.Location = new System.Drawing.Point(5, 7);
            this.txtBox_password.Name = "txtBox_password";
            this.txtBox_password.PasswordChar = '•';
            this.txtBox_password.Size = new System.Drawing.Size(337, 22);
            this.txtBox_password.TabIndex = 7;
            // 
            // panel_username
            // 
            this.panel_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_username.Controls.Add(this.txtBox_username);
            this.panel_username.Location = new System.Drawing.Point(96, 205);
            this.panel_username.Name = "panel_username";
            this.panel_username.Size = new System.Drawing.Size(348, 39);
            this.panel_username.TabIndex = 16;
            this.panel_username.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_username_Paint);
            // 
            // txtBox_username
            // 
            this.txtBox_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtBox_username.Location = new System.Drawing.Point(3, 6);
            this.txtBox_username.Name = "txtBox_username";
            this.txtBox_username.Size = new System.Drawing.Size(340, 22);
            this.txtBox_username.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(92, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 29);
            this.label6.TabIndex = 15;
            this.label6.Text = "Password";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(92, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 37);
            this.label5.TabIndex = 14;
            this.label5.Text = "Username";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(68, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(403, 46);
            this.label2.TabIndex = 13;
            this.label2.Text = "Welcome, I\'m Space Y....";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // wrong_info
            // 
            this.wrong_info.BackColor = System.Drawing.Color.Transparent;
            this.wrong_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.wrong_info.ForeColor = System.Drawing.Color.IndianRed;
            this.wrong_info.Location = new System.Drawing.Point(81, 355);
            this.wrong_info.Name = "wrong_info";
            this.wrong_info.Size = new System.Drawing.Size(390, 29);
            this.wrong_info.TabIndex = 21;
            this.wrong_info.Text = "The username or password you have entered is invalid.";
            this.wrong_info.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_exit
            // 
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btn_exit.ForeColor = System.Drawing.Color.Red;
            this.btn_exit.Location = new System.Drawing.Point(522, 9);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(30, 34);
            this.btn_exit.TabIndex = 22;
            this.btn_exit.Text = "x";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // btn_maximize
            // 
            this.btn_maximize.FlatAppearance.BorderSize = 0;
            this.btn_maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_maximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_maximize.ForeColor = System.Drawing.Color.Lime;
            this.btn_maximize.Location = new System.Drawing.Point(486, 9);
            this.btn_maximize.Name = "btn_maximize";
            this.btn_maximize.Size = new System.Drawing.Size(30, 34);
            this.btn_maximize.TabIndex = 23;
            this.btn_maximize.Text = "+";
            this.btn_maximize.UseVisualStyleBackColor = true;
            this.btn_maximize.Click += new System.EventHandler(this.maximize_Click);
            // 
            // btn_minimize
            // 
            this.btn_minimize.FlatAppearance.BorderSize = 0;
            this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minimize.ForeColor = System.Drawing.Color.Gold;
            this.btn_minimize.Location = new System.Drawing.Point(450, 9);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(30, 34);
            this.btn_minimize.TabIndex = 24;
            this.btn_minimize.Text = "-";
            this.btn_minimize.UseVisualStyleBackColor = true;
            this.btn_minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::QuanLyBanHangMayTinh.Properties.Resources.astronaut;
            this.pictureBox4.Location = new System.Drawing.Point(450, 514);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(91, 90);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 28;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::QuanLyBanHangMayTinh.Properties.Resources.star;
            this.pictureBox3.Location = new System.Drawing.Point(516, 61);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 27;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QuanLyBanHangMayTinh.Properties.Resources.launch;
            this.pictureBox2.Location = new System.Drawing.Point(12, 529);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 59);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyBanHangMayTinh.Properties.Resources.nanotechnology;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(564, 600);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_minimize);
            this.Controls.Add(this.btn_maximize);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.wrong_info);
            this.Controls.Add(this.btn_signup);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.panel_password);
            this.Controls.Add(this.panel_username);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_KeyDown);
            this.panel_password.ResumeLayout(false);
            this.panel_password.PerformLayout();
            this.panel_username.ResumeLayout(false);
            this.panel_username.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label btn_signup;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Panel panel_password;
        private System.Windows.Forms.TextBox txtBox_password;
        private System.Windows.Forms.Panel panel_username;
        private System.Windows.Forms.TextBox txtBox_username;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label wrong_info;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_maximize;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}