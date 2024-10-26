using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHangMayTinh.Forms
{
    public partial class SignUp : Form
    {
        private MainMenu mainMenuForm;
        static string stringConnect = ConfigurationManager.ConnectionStrings["QLBHMT_SERVER"].ConnectionString;
        bool usernameCheck = true, passwordCheck = true, reenterpasswordCheck = true;

        public SignUp(MainMenu mainMenu)
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml(color_fullWhite);
            this.mainMenuForm = mainMenu;
            this.KeyPreview = true;
        }

        string color_blurple = "#7289DA";
        string color_blurple_dark = "#5566a0";
        string color_fullWhite = "#FFFFFF";
        private Form currentChildForm;

        private void SignUp_Load(object sender, EventArgs e)
        {
            setDefault();
        }

        public void setDefault()
        {
            this.CenterToScreen();
            true_info.ForeColor = Color.Transparent;
            btn_SignUp.FlatStyle = FlatStyle.Flat;
            btn_SignUp.BackColor = ColorTranslator.FromHtml(color_blurple);

            btn_Back.ImageList = animation_btnBack;
            btn_Back.ImageIndex = 0;
            btn_Back.FlatAppearance.BorderColor = ColorTranslator.FromHtml(color_fullWhite);

            wrong_username.ForeColor = Color.Transparent;
            wrong_password.ForeColor = Color.Transparent;
            wrong_reenter.ForeColor = Color.Transparent;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
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

        private void panel4_Paint(object sender, PaintEventArgs e)
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
        private void button1_MouseHover(object sender, EventArgs e)
        {
            btn_Back.ImageIndex = 1;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            btn_Back.ImageIndex = 0;
        }

        private void CheckAll()
        {   
            if (usernameCheck)
            {
                wrong_username.ForeColor = Color.Transparent;
            }
            if (passwordCheck)
            {
                wrong_password.ForeColor = Color.Transparent;
            }
            if (reenterpasswordCheck)
            {
                wrong_reenter.ForeColor = Color.Transparent;
            }
        }

        private void Update_Tick(object sender, EventArgs e)
        {
            CheckAll();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            btn_Back.ImageIndex = 2;
            Login form_Login = new Login(this.mainMenuForm)
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
            };
            mainMenuForm.OpenChild_panelContainer(form_Login);
        }

        private void SignUp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckSignUp();
                e.SuppressKeyPress = true;
            }
        }

        private void CheckSignUp()
        {
            try
            {
                string username = txtBox_username.Text,
                password = txtBox_password.Text,
                reenterpassword = txtBox_reenterpassword.Text;
                using (SqlConnection sqlConnection = new SqlConnection(stringConnect))
                {
                    using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                    {
                        sqlCommand.CommandText = "PROC_SelectAllFromAccountData";
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                        {
                            using (DataTable tblAccountData = new DataTable("tblAccountData"))
                            {
                                adapter.Fill(tblAccountData);
                                using (DataSet dataSet = new DataSet())
                                {
                                    dataSet.Tables.Add(tblAccountData);

                                    usernameCheck = true; passwordCheck = true; reenterpasswordCheck = true;

                                    if (username.Length < 5)
                                    {
                                        usernameCheck = false;
                                        wrong_username.Text = "Username must contains at least 5 characters";
                                        wrong_username.ForeColor = Color.IndianRed;
                                    }
                                    if (username.Length > 15)
                                    {
                                        usernameCheck = false;
                                        wrong_username.Text = "Username cannot exceed 15 characters";
                                        wrong_username.ForeColor = Color.IndianRed;
                                    }
                                    foreach (DataRow row in tblAccountData.Rows)
                                    {
                                        if (username == row["sUsername"].ToString())
                                        {
                                            usernameCheck = false;
                                            wrong_username.Text = "Username has been taken";
                                            wrong_username.ForeColor = Color.IndianRed;
                                        }
                                    }
                                    if (password.Length < 6)
                                    {
                                        wrong_password.Text = "Password must contains at least 6 characters";
                                        passwordCheck = false;
                                        wrong_password.ForeColor = Color.IndianRed;
                                    }
                                    if (password.Length > 16)
                                    {
                                        wrong_password.Text = "Password cannot exceed 16 characters";
                                        passwordCheck = false;
                                        wrong_password.ForeColor = Color.IndianRed;
                                    }
                                    if (reenterpassword != password)
                                    {
                                        reenterpasswordCheck = false;
                                        wrong_reenter.ForeColor = Color.IndianRed;
                                    }

                                    if (!usernameCheck || !passwordCheck || !reenterpasswordCheck)
                                    {
                                        true_info.ForeColor = Color.Transparent;
                                    }

                                    if (usernameCheck && passwordCheck && reenterpasswordCheck)
                                    {
                                        DataRow newRow = tblAccountData.NewRow();
                                        newRow["sUsername"] = username;
                                        newRow["sPassword"] = password;
                                        tblAccountData.Rows.Add(newRow);
                                        //Insert
                                        sqlCommand.CommandText = "PROC_InsertAccountData";
                                        sqlCommand.CommandType = CommandType.StoredProcedure;
                                        sqlCommand.Parameters.Clear();
                                        sqlCommand.Parameters.AddWithValue("@susername", username);
                                        sqlCommand.Parameters.AddWithValue("@spassword", password);

                                        adapter.InsertCommand = sqlCommand;
                                        adapter.Update(dataSet, "tblAccountData");

                                        true_info.ForeColor = Color.Lime;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            CheckSignUp();
        }
    }
}
