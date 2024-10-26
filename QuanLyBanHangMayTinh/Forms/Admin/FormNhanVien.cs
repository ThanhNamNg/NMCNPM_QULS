using QuanLyBanHangMayTinh.Forms.Admin;
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
    public partial class FormNhanVien : Form
    {
        string color_blurple = "#7289DA";
        string color_blurple_dark = "#5566a0";
        string color_fullWhite = "#FFFFFF";
        static string stringConnect = ConfigurationManager.ConnectionStrings["QLBHMT_SERVER"].ConnectionString;
     
        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            SetDefault();
            LoadDataToDGV1();
        }

        private void LoadDataToDGV1(string filter = null)
        {
            try
            {
                NhanVienController nhanVienController = new NhanVienController();
                List<NhanVien> nhanVienList = nhanVienController.GetAllNhanVien();
                dgv_tblNhanVien.DataSource = nhanVienList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        private void SetDefault()
        {
            btn_Reset.BackColor = ColorTranslator.FromHtml(color_blurple);
            btn_Insert.BackColor = ColorTranslator.FromHtml(color_blurple);
            btn_Delete.BackColor = ColorTranslator.FromHtml(color_blurple);
            btn_Update.BackColor = ColorTranslator.FromHtml(color_blurple);
            btn_Search.BackColor = ColorTranslator.FromHtml(color_blurple);
        }

     

        private void btn_Insert_Click(object sender, EventArgs e)// moi
        {
            try
            {
                // Thu thập dữ liệu từ các ô nhập liệu trên form
                string employeeID = txtBox_employeeID.Text,
                    employeeName = txtBox_employeeName.Text,
                    employeePN = txtBox_employeePN.Text;
                bool isMale = rdBtn_Male.Checked;
                DateTime birthDate = datePicker_Birth.Value;
                DateTime startDate = datePicker_StartDate.Value;

                float luongCB, phuCap, hsl;
                if (!float.TryParse(txtBox_employeeDefault.Text, out luongCB) ||
                    !float.TryParse(txtBox_employeeCoefficent.Text, out hsl) ||
                    !float.TryParse(txtBox_employeeAllowance.Text, out phuCap))
                {
                    MessageBox.Show("Please enter valid numeric values for LuongCB, HSL, and PhuCap.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Tạo đối tượng NhanVien và gán các thuộc tính
                NhanVien nhanVien = new NhanVien
                {
                    MaNV = employeeID,
                    HoTenNV = employeeName,
                    SDT = employeePN,
                    NgaySinh = birthDate,
                    GioiTinh = isMale,
                    NgayVaoLam = startDate,
                    LuongCB = luongCB,
                    PhuCap = phuCap,
                    HSL = hsl
                };

                // Gọi controller để chèn nhân viên vào cơ sở dữ liệu
                NhanVienController controller = new NhanVienController();
                bool isInserted = controller.InsertNhanVien(nhanVien);

                if (isInserted)
                {
                    MessageBox.Show("Successfully added");
                    LoadDataToDGV1(); // Cập nhật lại DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e) //moi
        {
            string sMaNV = txtBox_employeeID.Text;

            if (string.IsNullOrEmpty(sMaNV))
            {
                MessageBox.Show("Please enter an employee ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dialog = MessageBox.Show("Are you sure you want to delete this employee " + sMaNV + "?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                NhanVienController controller = new NhanVienController();
                bool isDeleted = controller.DeleteNhanVien(sMaNV);

                if (isDeleted)
                {
                    MessageBox.Show("Successfully deleted");
                    LoadDataToDGV1(); // Cập nhật lại DataGridView sau khi xóa
                }
                else
                {
                    MessageBox.Show("Error: Unable to delete the record.");
                }
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            // Tạo đối tượng NhanVien
            NhanVien nhanVien = new NhanVien
            {
                MaNV = txtBox_employeeID.Text,
                HoTenNV = txtBox_employeeName.Text,
                SDT = txtBox_employeePN.Text,
                NgaySinh = datePicker_Birth.Value.Date,
                GioiTinh = rdBtn_Male.Checked,
                NgayVaoLam = datePicker_StartDate.Value.Date
            };

            if (string.IsNullOrEmpty(nhanVien.MaNV))
            {
                MessageBox.Show("Please enter an employee ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra giá trị số cho các trường lương, phụ cấp và hệ số lương
            if (!float.TryParse(txtBox_employeeDefault.Text, out float luongCB))
            {
                MessageBox.Show("Please enter a valid numeric value for LuongCB.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            nhanVien.LuongCB = luongCB;

            if (!float.TryParse(txtBox_employeeCoefficent.Text, out float hsl))
            {
                MessageBox.Show("Please enter a valid numeric value for HSL.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            nhanVien.HSL = hsl;

            if (!float.TryParse(txtBox_employeeAllowance.Text, out float phuCap))
            {
                MessageBox.Show("Please enter a valid numeric value for PhuCap.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            nhanVien.PhuCap = phuCap;

            // Gọi phương thức cập nhật
            NhanVienController controller = new NhanVienController();
            bool isUpdated = controller.UpdateNhanVien(nhanVien);

            // Kiểm tra kết quả cập nhật
            if (!isUpdated)
            {
                MessageBox.Show("Successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataToDGV1(); // Cập nhật lại DataGridView sau khi sửa
                return;
            }
            else
            {
                MessageBox.Show("Update failed. Please check the employee ID and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void btn_Search_Click(object sender, EventArgs e)
        {
            string employeeID = txtBox_employeeID.Text;
            string employeeName = txtBox_employeeName.Text;
            string employeePN = txtBox_employeePN.Text;
            int genderCode = rdBtn_Male.Checked ? 1 : 0;

            // Chuyển đổi giá trị về dạng nullable nếu không hợp lệ
            float? luongCB = float.TryParse(txtBox_employeeDefault.Text, out float parsedLuongCB) ? parsedLuongCB : (float?)null;
            float? phuCap = float.TryParse(txtBox_employeeAllowance.Text, out float parsedPhuCap) ? parsedPhuCap : (float?)null;
            float? hsl = float.TryParse(txtBox_employeeCoefficent.Text, out float parsedHSL) ? parsedHSL : (float?)null;

            // Gọi phương thức SearchNhanVien từ controller
            NhanVienController controller = new NhanVienController();
            DataTable result = controller.SearchNhanVien(employeeID, employeeName, employeePN, luongCB, phuCap, hsl, genderCode);

            // Hiển thị kết quả trong DataGridView
            dgv_tblNhanVien.DataSource = result;
        }

        private void dgv_tblNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra chỉ số hàng hợp lệ
            {
                DataGridViewRow row = dgv_tblNhanVien.Rows[e.RowIndex];

                // Sử dụng toán tử điều kiện để xử lý giá trị null
                txtBox_employeeID.Text = row.Cells["MaNV"].Value?.ToString() ?? string.Empty; // Nếu null, gán chuỗi rỗng
                txtBox_employeeName.Text = row.Cells["HoTenNV"].Value?.ToString() ?? string.Empty;
                txtBox_employeePN.Text = row.Cells["SDT"].Value?.ToString() ?? string.Empty;

                // Kiểm tra nếu giá trị không null trước khi chuyển đổi
                if (row.Cells["NgaySinh"].Value != null)
                {
                    datePicker_Birth.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
                }
                else
                {
                    datePicker_Birth.Value = DateTime.Today; // Hoặc gán giá trị mặc định khác
                }

                // Kiểm tra nếu giá trị không null trước khi gán cho radio button
                if (row.Cells["GioiTinh"].Value != null)
                {
                    rdBtn_Male.Checked = (bool)row.Cells["GioiTinh"].Value;
                    rdBtn_Female.Checked = !rdBtn_Male.Checked;
                }
                else
                {
                    rdBtn_Male.Checked = false; // Hoặc gán giá trị mặc định
                    rdBtn_Female.Checked = false;
                }

                // Kiểm tra nếu giá trị không null trước khi chuyển đổi
                if (row.Cells["NgayVaoLam"].Value != null)
                {
                    datePicker_StartDate.Value = Convert.ToDateTime(row.Cells["NgayVaoLam"].Value);
                }
                else
                {
                    datePicker_StartDate.Value = DateTime.Today; // Hoặc gán giá trị mặc định khác
                }

                txtBox_employeeDefault.Text = row.Cells["LuongCB"].Value?.ToString() ?? string.Empty;
                txtBox_employeeAllowance.Text = row.Cells["PhuCap"].Value?.ToString() ?? string.Empty;
                txtBox_employeeCoefficent.Text = row.Cells["HSL"].Value?.ToString() ?? string.Empty;
            }
        }


        private void btn_Reset_Click(object sender, EventArgs e)
        {
            // Clear textboxes and any other content
            txtBox_employeeID.Text = "";
            txtBox_employeeName.Text = "";
            txtBox_employeePN.Text = "";
            txtBox_employeeDefault.Text = "";
            txtBox_employeeCoefficent.Text = "";
            txtBox_employeeAllowance.Text = "";
            datePicker_Birth.Value = DateTime.Today;
            datePicker_StartDate.Value = DateTime.Today;
            rdBtn_Male.Checked = true;

            // Reload data
            LoadDataToDGV1("");
        }

      
    }
}
