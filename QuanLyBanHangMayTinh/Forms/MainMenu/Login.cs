using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHangMayTinh.Forms
{
    public partial class Login : Form
    {
        string color_blurple = "#7289DA";
        string color_blurple_dark = "#5566a0";
        string color_fullWhite = "#FFFFFF";
        private MainMenu mainMenuForm;
        static string stringConnect = ConfigurationManager.ConnectionStrings["QLBHMT_SERVER"].ConnectionString;
        bool isLogin = true;

        public Login(MainMenu mainMenu)
        {
            InitializeComponent();
            this.mainMenuForm = mainMenu;
            this.KeyPreview = true;
        }
        private void Login_Load(object sender, EventArgs e)
        {
            setDefault();
        }

        public void setDefault()
        {
            this.CenterToScreen();
            btn_Login.FlatStyle = FlatStyle.Flat;
            btn_Login.BackColor = ColorTranslator.FromHtml(color_blurple);

            btn_signup.ForeColor = ColorTranslator.FromHtml(color_blurple);

            wrong_info.ForeColor = Color.Transparent;
        }


        private void panel_username_Paint(object sender, PaintEventArgs e)
        {
            if (panel_username.BorderStyle == BorderStyle.FixedSingle)
            {
                int thickness = 1;//it's up to you
                int halfThickness = thickness / 2;
                using (Pen p = new Pen(Color.Black, thickness))
                {
                    e.Graphics.DrawRectangle(p, new Rectangle(halfThickness,
                                                              halfThickness,
                                                              panel_username.ClientSize.Width - thickness,
                                                              panel_username.ClientSize.Height - thickness));
                }
            }
        }

        private void panel_password_Paint(object sender, PaintEventArgs e)
        {
            if (panel_password.BorderStyle == BorderStyle.FixedSingle)
            {
                int thickness = 1;//it's up to you
                int halfThickness = thickness / 2;
                using (Pen p = new Pen(Color.Black, thickness))
                {
                    e.Graphics.DrawRectangle(p, new Rectangle(halfThickness,
                                                              halfThickness,
                                                              panel_password.ClientSize.Width - thickness,
                                                              panel_password.ClientSize.Height - thickness));
                }
            }
        }

        private void btn_Login_MouseLeave(object sender, EventArgs e)
        {
            btn_Login.BackColor = ColorTranslator.FromHtml(color_blurple);
        }

        private void btn_Login_MouseEnter(object sender, EventArgs e)
        {
            btn_Login.BackColor = ColorTranslator.FromHtml(color_blurple_dark);
        }

       

        private void btn_Login_Click(object sender, EventArgs e)
        {
            MenuAdmin menuAdmin = new MenuAdmin();
            menuAdmin.Show();
            mainMenuForm.Hide();

        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            SignUp form_signUp = new SignUp(this.mainMenuForm)
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
            };
            mainMenuForm.OpenChild_panelContainer(form_signUp);
        }
        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
       
                e.SuppressKeyPress = true;
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maximize_Click(object sender, EventArgs e)
        {
            if (mainMenuForm.WindowState == FormWindowState.Normal)
            {
                mainMenuForm.WindowState = FormWindowState.Maximized;
            } else
            {
                mainMenuForm.WindowState = FormWindowState.Normal;
            }
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            mainMenuForm.WindowState = FormWindowState.Minimized;
        }
    }
}
