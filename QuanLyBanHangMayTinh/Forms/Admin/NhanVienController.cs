using System;
using System.Collections.Generic;
using System.Configuration; // Thêm namespace này để sử dụng ConfigurationManager
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyBanHangMayTinh.Forms.Admin
{
    internal class NhanVienController
    {
        private string connectionString;

        public NhanVienController()
        {
            // Lấy chuỗi kết nối từ file cấu hình
            connectionString = ConfigurationManager.ConnectionStrings["QLBHMT_SERVER"].ConnectionString;
        }

        // Phương thức để lấy danh sách nhân viên từ cơ sở dữ liệu
        public List<NhanVien> GetAllNhanVien()
        {
            List<NhanVien> nhanVienList = new List<NhanVien>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM tblNhanVien"; // Truy vấn lấy tất cả nhân viên
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        NhanVien nhanVien = new NhanVien
                        {
                            MaNV = reader["sMaNV"].ToString(),
                            HoTenNV = reader["sHoTenNV"].ToString(),
                            SDT = reader["sSDT"].ToString(),
                            NgaySinh = reader["dNgaySinh"] as DateTime?,
                            GioiTinh = reader["bGioiTinh"] != DBNull.Value && (bool)reader["bGioiTinh"],
                            NgayVaoLam = reader["dNgayVaoLam"] as DateTime?,
                            LuongCB = reader["fLuongCB"] != DBNull.Value ? Convert.ToSingle(reader["fLuongCB"]) : (float?)null,
                            PhuCap = reader["fPhuCap"] != DBNull.Value ? Convert.ToSingle(reader["fPhuCap"]) : (float?)null,
                            HSL = reader["fHSL"] != DBNull.Value ? Convert.ToSingle(reader["fHSL"]) : (float?)null,
                            MaPB = reader["sMaPB"].ToString()
                        };
                        nhanVienList.Add(nhanVien);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
                }
            }

            return nhanVienList;
        }


        public bool InsertNhanVien(NhanVien nhanVien)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = "PROC_InsertNhanVien";
                        command.CommandType = CommandType.StoredProcedure;

                        // Thêm các tham số cho thủ tục
                        command.Parameters.AddWithValue("@sMaNV", nhanVien.MaNV);
                        command.Parameters.AddWithValue("@sHoTenNV", nhanVien.HoTenNV);
                        command.Parameters.AddWithValue("@sSDT", nhanVien.SDT);
                        command.Parameters.AddWithValue("@dNgaySinh", nhanVien.NgaySinh);
                        command.Parameters.AddWithValue("@bGioiTinh", nhanVien.GioiTinh);
                        command.Parameters.AddWithValue("@dNgayVaoLam", nhanVien.NgayVaoLam);
                        command.Parameters.AddWithValue("@fLuongCB", nhanVien.LuongCB);
                        command.Parameters.AddWithValue("@fPhuCap", nhanVien.PhuCap);
                        command.Parameters.AddWithValue("@fHSL", nhanVien.HSL);

                        connection.Open();
                        command.ExecuteNonQuery(); // Thực hiện chèn dữ liệu

                        return true;
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627) // Lỗi trùng khóa chính
                {
                    MessageBox.Show("This employee ID already exists. Please enter a unique employee ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return false;
            }
        }

        public bool DeleteNhanVien(string maNV)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("PROC_DeleteNhanVien", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@sMaNV", maNV);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        return rowsAffected > 0; // Trả về true nếu xóa thành công
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547) // Ràng buộc khóa ngoại bị vi phạm
                {
                    MessageBox.Show("Error: This record cannot be deleted because it is referenced by other records.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool UpdateNhanVien(NhanVien nhanVien)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("PROC_UpdateNhanVien", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@sMaNV", nhanVien.MaNV);
                        command.Parameters.AddWithValue("@sHoTenNV", nhanVien.HoTenNV);
                        command.Parameters.AddWithValue("@sSDT", nhanVien.SDT);
                        command.Parameters.AddWithValue("@dNgaySinh", nhanVien.NgaySinh);
                        command.Parameters.AddWithValue("@bGioiTinh", nhanVien.GioiTinh);
                        command.Parameters.AddWithValue("@dNgayVaoLam", nhanVien.NgayVaoLam);
                        command.Parameters.AddWithValue("@fLuongCB", nhanVien.LuongCB);
                        command.Parameters.AddWithValue("@fPhuCap", nhanVien.PhuCap);
                        command.Parameters.AddWithValue("@fHSL", nhanVien.HSL);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        return rowsAffected > 0; // Trả về true nếu cập nhật thành công
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }
        public DataTable SearchNhanVien(string maNV, string hoTenNV, string sdt, float? luongCB, float? phuCap, float? hsl, int? genderCode)
        {
            DataTable resultTable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("PROC_SearchNhanVien", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@sMaNV", string.IsNullOrEmpty(maNV) ? (object)DBNull.Value : maNV);
                        command.Parameters.AddWithValue("@sHoTenNV", string.IsNullOrEmpty(hoTenNV) ? (object)DBNull.Value : hoTenNV);
                        command.Parameters.AddWithValue("@sSDT", string.IsNullOrEmpty(sdt) ? (object)DBNull.Value : sdt);
                        command.Parameters.AddWithValue("@fLuongCB", luongCB.HasValue ? (object)luongCB.Value : DBNull.Value);
                        command.Parameters.AddWithValue("@fPhuCap", phuCap.HasValue ? (object)phuCap.Value : DBNull.Value);
                        command.Parameters.AddWithValue("@fHSL", hsl.HasValue ? (object)hsl.Value : DBNull.Value);
                        command.Parameters.AddWithValue("@bGioiTinh", genderCode.HasValue ? (object)genderCode.Value : DBNull.Value);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(resultTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return resultTable;
        }
    }
}
