namespace QuanLyBanHangMayTinh
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.panel_Container = new System.Windows.Forms.Panel();
            this.panel_Decoration = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel_Decoration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Container
            // 
            this.panel_Container.BackColor = System.Drawing.Color.White;
            this.panel_Container.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_Container.Location = new System.Drawing.Point(336, 0);
            this.panel_Container.Name = "panel_Container";
            this.panel_Container.Size = new System.Drawing.Size(564, 600);
            this.panel_Container.TabIndex = 0;
            // 
            // panel_Decoration
            // 
            this.panel_Decoration.BackColor = System.Drawing.Color.Gray;
            this.panel_Decoration.Controls.Add(this.label2);
            this.panel_Decoration.Controls.Add(this.Logo);
            this.panel_Decoration.Controls.Add(this.label4);
            this.panel_Decoration.Controls.Add(this.label3);
            this.panel_Decoration.Controls.Add(this.label1);
            this.panel_Decoration.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Decoration.Location = new System.Drawing.Point(0, 0);
            this.panel_Decoration.Name = "panel_Decoration";
            this.panel_Decoration.Size = new System.Drawing.Size(337, 600);
            this.panel_Decoration.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(3, 572);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Version 0.1";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Logo
            // 
            this.Logo.Image = global::QuanLyBanHangMayTinh.Properties.Resources.Logo1;
            this.Logo.Location = new System.Drawing.Point(39, 134);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(223, 156);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 3;
            this.Logo.TabStop = false;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(15, 447);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(312, 78);
            this.label4.TabIndex = 2;
            this.label4.Text = "Discover the world\'s best technology and perfect services for you.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(317, 84);
            this.label3.TabIndex = 1;
            this.label3.Text = "Founder Mr. Thanh Nam";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "SpaceY";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.ControlBox = false;
            this.Controls.Add(this.panel_Container);
            this.Controls.Add(this.panel_Decoration);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(900, 600);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "MainMenu";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel_Decoration.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Decoration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_Container;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}

