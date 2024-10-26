using QuanLyBanHangMayTinh.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHangMayTinh
{
    public partial class MainMenu : Form
    {
        string color_blurple = "#7289DA";
        string color_blurple_dark = "#5566a0";
        string color_fullWhite = "#FFFFFF";
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            setDefault();
        }

        public void setDefault()
        {
            this.CenterToScreen();
            panel_Decoration.BackColor = ColorTranslator.FromHtml(color_blurple);
            
            Login form_Login = new Login(this)
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
            };
            this.panel_Container.Controls.Clear();
            this.panel_Container.Controls.Add(form_Login);
            form_Login.Show();
        }

        public void OpenChild_panelContainer(Form ChildForm)
        {
            this.panel_Container.Controls.Clear();
            this.panel_Container.Controls.Add(ChildForm);
            ChildForm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Form menuAdminForm = Application.OpenForms["MenuAdmin"];

            Form menuKhachHangForm = Application.OpenForms["MenuKhachHang"];
            if (menuKhachHangForm != null && menuKhachHangForm.IsHandleCreated && menuKhachHangForm.Visible)
            {
                
            }
            else if (menuAdminForm != null && menuAdminForm.IsHandleCreated && menuAdminForm.Visible)
            {
                
            }
            else
            {
                this.Show();
            }
        }
    }
}
