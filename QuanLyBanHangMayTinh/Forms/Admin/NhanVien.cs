    using System;

    namespace QuanLyBanHangMayTinh.Forms.Admin
    {
        internal class NhanVien
        {
            public string MaNV { get; set; }          // Mã nhân viên
            public string HoTenNV { get; set; }       // Họ tên nhân viên
            public string SDT { get; set; }           // Số điện thoại
            public DateTime? NgaySinh { get; set; }   // Ngày sinh
            public bool GioiTinh { get; set; }        // Giới tính (true: Nam, false: Nữ)
            public DateTime? NgayVaoLam { get; set; } // Ngày vào làm
            public float? LuongCB { get; set; }       // Lương cơ bản
            public float? PhuCap { get; set; }        // Phụ cấp
            public float? HSL { get; set; }           // Hệ số lương
            public string MaPB { get; set; }          // Mã phòng ban
        }
    }
