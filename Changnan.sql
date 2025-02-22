USE [master]
GO
/****** Object:  Database [QLBHMT]    Script Date: 10/25/2024 10:56:50 PM ******/
CREATE DATABASE [QLBHMT]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLBHMT', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER01\MSSQL\DATA\QLBHMT.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLBHMT_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER01\MSSQL\DATA\QLBHMT_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [QLBHMT] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLBHMT].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLBHMT] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLBHMT] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLBHMT] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLBHMT] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLBHMT] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLBHMT] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLBHMT] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLBHMT] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLBHMT] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLBHMT] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLBHMT] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLBHMT] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLBHMT] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLBHMT] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLBHMT] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QLBHMT] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLBHMT] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLBHMT] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLBHMT] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLBHMT] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLBHMT] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLBHMT] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLBHMT] SET RECOVERY FULL 
GO
ALTER DATABASE [QLBHMT] SET  MULTI_USER 
GO
ALTER DATABASE [QLBHMT] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLBHMT] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLBHMT] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLBHMT] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLBHMT] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QLBHMT] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'QLBHMT', N'ON'
GO
ALTER DATABASE [QLBHMT] SET QUERY_STORE = ON
GO
ALTER DATABASE [QLBHMT] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [QLBHMT]
GO
/****** Object:  Table [dbo].[tblNhanVien]    Script Date: 10/25/2024 10:56:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblNhanVien](
	[sMaNV] [varchar](30) NOT NULL,
	[sHoTenNV] [nvarchar](50) NULL,
	[sSDT] [varchar](10) NULL,
	[dNgaySinh] [date] NULL,
	[bGioiTinh] [bit] NULL,
	[dNgayVaoLam] [date] NULL,
	[fLuongCB] [float] NULL,
	[fPhuCap] [float] NULL,
	[fHSL] [float] NULL,
	[sMaPB] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[sMaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblPhongBan]    Script Date: 10/25/2024 10:56:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPhongBan](
	[sMaPB] [varchar](30) NOT NULL,
	[sTenPB] [nvarchar](50) NULL,
	[sTruongPhong] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[sMaPB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tblNhanVien] ([sMaNV], [sHoTenNV], [sSDT], [dNgaySinh], [bGioiTinh], [dNgayVaoLam], [fLuongCB], [fPhuCap], [fHSL], [sMaPB]) VALUES (N'NV001', N'Nguyễn Văn A', N'0123456789', CAST(N'1990-01-01' AS Date), 1, CAST(N'2020-05-01' AS Date), 56, 65, 2.5, N'PB001')
INSERT [dbo].[tblNhanVien] ([sMaNV], [sHoTenNV], [sSDT], [dNgaySinh], [bGioiTinh], [dNgayVaoLam], [fLuongCB], [fPhuCap], [fHSL], [sMaPB]) VALUES (N'NV002', N'Trần Thị B', N'0987654321', CAST(N'1992-02-02' AS Date), 0, CAST(N'2021-06-01' AS Date), 6000000, 1200000, 2.7, N'PB002')
INSERT [dbo].[tblNhanVien] ([sMaNV], [sHoTenNV], [sSDT], [dNgaySinh], [bGioiTinh], [dNgayVaoLam], [fLuongCB], [fPhuCap], [fHSL], [sMaPB]) VALUES (N'NV003', N'Lê Văn C', N'0912345678', CAST(N'1985-03-03' AS Date), 1, CAST(N'2019-07-01' AS Date), 5500000, 1100000, 2.6, N'PB003')
INSERT [dbo].[tblNhanVien] ([sMaNV], [sHoTenNV], [sSDT], [dNgaySinh], [bGioiTinh], [dNgayVaoLam], [fLuongCB], [fPhuCap], [fHSL], [sMaPB]) VALUES (N'NV004', N'Phạm Thị D', N'0909876543', CAST(N'1988-04-04' AS Date), 0, CAST(N'2020-08-01' AS Date), 6500000, 1300000, 2.8, N'PB004')
INSERT [dbo].[tblNhanVien] ([sMaNV], [sHoTenNV], [sSDT], [dNgaySinh], [bGioiTinh], [dNgayVaoLam], [fLuongCB], [fPhuCap], [fHSL], [sMaPB]) VALUES (N'NV005', N'Nguyễn Văn E', N'0922334455', CAST(N'1991-05-05' AS Date), 1, CAST(N'2021-09-01' AS Date), 54, 54, 54, N'PB005')
INSERT [dbo].[tblNhanVien] ([sMaNV], [sHoTenNV], [sSDT], [dNgaySinh], [bGioiTinh], [dNgayVaoLam], [fLuongCB], [fPhuCap], [fHSL], [sMaPB]) VALUES (N'NV006', N'Trần Thị F', N'0933445566', CAST(N'1993-06-06' AS Date), 0, CAST(N'2022-10-01' AS Date), 7200000, 1500000, 3, N'PB006')
INSERT [dbo].[tblNhanVien] ([sMaNV], [sHoTenNV], [sSDT], [dNgaySinh], [bGioiTinh], [dNgayVaoLam], [fLuongCB], [fPhuCap], [fHSL], [sMaPB]) VALUES (N'NV007', N'Lê Văn G', N'0944556677', CAST(N'1994-07-07' AS Date), 1, CAST(N'2022-11-01' AS Date), 7400000, 1600000, 3.1, N'PB007')
INSERT [dbo].[tblNhanVien] ([sMaNV], [sHoTenNV], [sSDT], [dNgaySinh], [bGioiTinh], [dNgayVaoLam], [fLuongCB], [fPhuCap], [fHSL], [sMaPB]) VALUES (N'NV008', N'Phạm Thị H', N'0955667788', CAST(N'1995-08-08' AS Date), 0, CAST(N'2023-12-01' AS Date), 7600000, 1700000, 3.2, N'PB008')
INSERT [dbo].[tblNhanVien] ([sMaNV], [sHoTenNV], [sSDT], [dNgaySinh], [bGioiTinh], [dNgayVaoLam], [fLuongCB], [fPhuCap], [fHSL], [sMaPB]) VALUES (N'NV009', N'Nguyễn Văn I', N'0966778899', CAST(N'1996-09-09' AS Date), 1, CAST(N'2023-01-01' AS Date), 7800000, 1800000, 3.3, N'PB009')
INSERT [dbo].[tblNhanVien] ([sMaNV], [sHoTenNV], [sSDT], [dNgaySinh], [bGioiTinh], [dNgayVaoLam], [fLuongCB], [fPhuCap], [fHSL], [sMaPB]) VALUES (N'NV010', N'Trần Thị J', N'0977889900', CAST(N'1997-10-10' AS Date), 0, CAST(N'2024-02-01' AS Date), 8000000, 1900000, 3.4, N'PB010')
GO
INSERT [dbo].[tblPhongBan] ([sMaPB], [sTenPB], [sTruongPhong]) VALUES (N'PB001', N'Phòng Kinh Doanh', N'Trưởng phòng A')
INSERT [dbo].[tblPhongBan] ([sMaPB], [sTenPB], [sTruongPhong]) VALUES (N'PB002', N'Phòng Nhân Sự', N'Trưởng phòng B')
INSERT [dbo].[tblPhongBan] ([sMaPB], [sTenPB], [sTruongPhong]) VALUES (N'PB003', N'Phòng Kỹ Thuật', N'Trưởng phòng C')
INSERT [dbo].[tblPhongBan] ([sMaPB], [sTenPB], [sTruongPhong]) VALUES (N'PB004', N'Phòng Tài Chính', N'Trưởng phòng D')
INSERT [dbo].[tblPhongBan] ([sMaPB], [sTenPB], [sTruongPhong]) VALUES (N'PB005', N'Phòng Marketing', N'Trưởng phòng E')
INSERT [dbo].[tblPhongBan] ([sMaPB], [sTenPB], [sTruongPhong]) VALUES (N'PB006', N'Phòng Hỗ Trợ Khách Hàng', N'Trưởng phòng F')
INSERT [dbo].[tblPhongBan] ([sMaPB], [sTenPB], [sTruongPhong]) VALUES (N'PB007', N'Phòng Công Nghệ Thông Tin', N'Trưởng phòng G')
INSERT [dbo].[tblPhongBan] ([sMaPB], [sTenPB], [sTruongPhong]) VALUES (N'PB008', N'Phòng Sản Xuất', N'Trưởng phòng H')
INSERT [dbo].[tblPhongBan] ([sMaPB], [sTenPB], [sTruongPhong]) VALUES (N'PB009', N'Phòng Nghiên Cứu Phát Triển', N'Trưởng phòng I')
INSERT [dbo].[tblPhongBan] ([sMaPB], [sTenPB], [sTruongPhong]) VALUES (N'PB010', N'Phòng Quản Lý Chất Lượng', N'Trưởng phòng J')
GO
ALTER TABLE [dbo].[tblNhanVien]  WITH CHECK ADD  CONSTRAINT [FK_sMaPB] FOREIGN KEY([sMaPB])
REFERENCES [dbo].[tblPhongBan] ([sMaPB])
GO
ALTER TABLE [dbo].[tblNhanVien] CHECK CONSTRAINT [FK_sMaPB]
GO
/****** Object:  StoredProcedure [dbo].[PROC_DeleteAccountData]    Script Date: 10/25/2024 10:56:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PROC_DeleteAccountData]
	@sUsername varchar(15)
AS
BEGIN
	DELETE FROM tblAccountData WHERE sUsername = @sUsername;
END

GO
/****** Object:  StoredProcedure [dbo].[PROC_DeleteCT_HD]    Script Date: 10/25/2024 10:56:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Stored procedure for deleting a record from the tblCT_HD table
CREATE PROCEDURE [dbo].[PROC_DeleteCT_HD]
(
    @sMaHoaDon varchar(30),
    @sMaHang varchar(30)
)
AS
BEGIN
    DELETE FROM tblCT_HD
    WHERE sMaHoaDon = @sMaHoaDon AND sMaHang = @sMaHang;
END

GO
/****** Object:  StoredProcedure [dbo].[PROC_DeleteHoaDon]    Script Date: 10/25/2024 10:56:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Stored procedure for deleting a record from the tblHoaDon table
CREATE PROCEDURE [dbo].[PROC_DeleteHoaDon]
(
    @sMaHoaDon varchar(30)
)
AS
BEGIN
    DELETE FROM tblHoaDon
    WHERE sMaHoaDon = @sMaHoaDon;
END

GO
/****** Object:  StoredProcedure [dbo].[PROC_DeleteKhachHang]    Script Date: 10/25/2024 10:56:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PROC_DeleteKhachHang](@smakh varchar(30))
AS DELETE FROM tblKhachHang WHERE @smakh = sMaKH

GO
/****** Object:  StoredProcedure [dbo].[PROC_DeleteMatHang]    Script Date: 10/25/2024 10:56:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Stored procedure for deleting a record from the tblMatHang table
CREATE PROCEDURE [dbo].[PROC_DeleteMatHang]
(
    @sMaHang varchar(30)
)
AS
BEGIN
    DELETE FROM tblMatHang
    WHERE sMaHang = @sMaHang;
END

GO
/****** Object:  StoredProcedure [dbo].[PROC_DeleteNhaCungCap]    Script Date: 10/25/2024 10:56:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Stored procedure for deleting a record from the tblNhaCungCap table
CREATE PROCEDURE [dbo].[PROC_DeleteNhaCungCap]
(
    @sMaNCC varchar(30)
)
AS
BEGIN
    DELETE FROM tblNhaCungCap
    WHERE sMaNCC = @sMaNCC;
END

GO
/****** Object:  StoredProcedure [dbo].[PROC_DeleteNhanVien]    Script Date: 10/25/2024 10:56:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PROC_DeleteNhanVien]
	@sMaNV varchar(30)
AS
BEGIN
	DELETE FROM tblNhanVien WHERE sMaNV = @sMaNV;
END

GO
/****** Object:  StoredProcedure [dbo].[PROC_InsertAccountData]    Script Date: 10/25/2024 10:56:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[PROC_InsertAccountData]
	@sUsername varchar(15),
	@sPassword varchar(16)
AS
BEGIN
	INSERT INTO tblAccountData (sUsername, sPassword)
	VALUES (@sUsername, @sPassword);
END

GO
/****** Object:  StoredProcedure [dbo].[PROC_InsertCT_HD]    Script Date: 10/25/2024 10:56:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Stored procedure for inserting a record into the tblCT_HD table
CREATE PROCEDURE [dbo].[PROC_InsertCT_HD]
(
    @sMaHoaDon varchar(30),
    @sMaHang varchar(30),
    @iSL int,
    @fDonGia float,
    @fThanhTien float
)
AS
BEGIN
    INSERT INTO tblCT_HD (sMaHoaDon, sMaHang, iSL, fDonGia, fThanhTien)
    VALUES (@sMaHoaDon, @sMaHang, @iSL, @fDonGia, @fThanhTien);
END

GO
/****** Object:  StoredProcedure [dbo].[PROC_InsertHoaDon]    Script Date: 10/25/2024 10:56:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Stored procedure for inserting a record into the tblHoaDon table
CREATE   PROCEDURE [dbo].[PROC_InsertHoaDon]
(
    @sMaHoaDon varchar(30),
    @sMaNV varchar(30),
    @sMaKH varchar(30),
    @dNgayDatHang date,
    @dNgayGiaoHang date,
    @sDiaChiGiaoHang varchar(100),
	@Ghichu nvarchar(255)
)
AS
BEGIN
    INSERT INTO tblHoaDon (sMaHoaDon, sMaNV, sMaKH, dNgayDatHang, dNgayGiaoHang, sDiaChiGiaoHang, Ghichu)
    VALUES (@sMaHoaDon, @sMaNV, @sMaKH, @dNgayDatHang, @dNgayGiaoHang, @sDiaChiGiaoHang, @Ghichu);
END

GO
/****** Object:  StoredProcedure [dbo].[PROC_InsertKhachHang]    Script Date: 10/25/2024 10:56:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PROC_InsertKhachHang]
(
    @sMaKH varchar(30),
    @sHoTenKH nvarchar(50),
    @sDiaChi nvarchar(100),
    @bGioiTinh bit,
    @sSDT varchar(10)
)
AS
BEGIN
    INSERT INTO tblKhachHang(sMaKH, sHoTenKH, sDiaChi, bGioiTinh, sSDT)
    VALUES(@sMaKH, @sHoTenKH, @sDiaChi, @bGioiTinh, @sSDT)
END

GO
/****** Object:  StoredProcedure [dbo].[PROC_InsertMatHang]    Script Date: 10/25/2024 10:56:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Stored procedure for inserting a record into the tblMatHang table
CREATE PROCEDURE [dbo].[PROC_InsertMatHang]
(
    @sMaHang varchar(30),
    @sMaNCC varchar(30),
    @sTenHang nvarchar(100),
    @iSL int,
    @fDonGia float,
    @sMoTa varchar(200)
)
AS
BEGIN
    INSERT INTO tblMatHang (sMaHang, sMaNCC, sTenHang, iSL, fDonGia, sMoTa)
    VALUES (@sMaHang, @sMaNCC, @sTenHang, @iSL, @fDonGia, @sMoTa);
END

GO
/****** Object:  StoredProcedure [dbo].[PROC_InsertNhaCungCap]    Script Date: 10/25/2024 10:56:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Stored procedure for inserting a record into the tblNhaCungCap table
CREATE PROCEDURE [dbo].[PROC_InsertNhaCungCap]
(
    @sMaNCC varchar(30),
    @sTenNCC varchar(50)
)
AS
BEGIN
    INSERT INTO tblNhaCungCap (sMaNCC, sTenNCC)
    VALUES (@sMaNCC, @sTenNCC);
END

GO
/****** Object:  StoredProcedure [dbo].[PROC_InsertNhanVien]    Script Date: 10/25/2024 10:56:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PROC_InsertNhanVien]
	@sMaNV varchar(30),
	@sHoTenNV nvarchar(50),
	@sSDT varchar(10),
	@dNgaySinh date,
	@bGioiTinh bit,
	@dNgayVaoLam date,
	@fLuongCB float,
	@fPhuCap float,
	@fHSL float
AS
BEGIN
	INSERT INTO tblNhanVien (sMaNV, sHoTenNV, sSDT, dNgaySinh, bGioiTinh, dNgayVaoLam, fLuongCB, fPhuCap, fHSL)
	VALUES (@sMaNV, @sHoTenNV, @sSDT, @dNgaySinh, @bGioiTinh, @dNgayVaoLam, @fLuongCB, @fPhuCap, @fHSL);
END

GO
/****** Object:  StoredProcedure [dbo].[PROC_SearchNhanVien]    Script Date: 10/25/2024 10:56:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PROC_SearchNhanVien]
    @sMaNV NVARCHAR(50) = NULL,
    @sHoTenNV NVARCHAR(100) = NULL,
    @sSDT NVARCHAR(20) = NULL,
    @fLuongCB FLOAT = NULL,
    @fPhuCap FLOAT = NULL,
    @fHSL FLOAT = NULL,
    @bGioiTinh INT = NULL
AS
BEGIN
    SET NOCOUNT ON;

    SELECT *
    FROM tblNhanVien
    WHERE 
        (@sMaNV IS NULL OR sMaNV LIKE '%' + @sMaNV + '%') AND
        (@sHoTenNV IS NULL OR sHoTenNV LIKE '%' + @sHoTenNV + '%') AND
        (@sSDT IS NULL OR sSDT LIKE '%' + @sSDT + '%') AND
        (@fLuongCB IS NULL OR fLuongCB = @fLuongCB) AND
        (@fPhuCap IS NULL OR fPhuCap = @fPhuCap) AND
        (@fHSL IS NULL OR fHSL = @fHSL) AND
        (@bGioiTinh IS NULL OR bGioiTinh = @bGioiTinh);
END;
GO
/****** Object:  StoredProcedure [dbo].[PROC_SelectAllFromAccountData]    Script Date: 10/25/2024 10:56:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PROC_SelectAllFromAccountData]
AS
BEGIN
	SELECT * FROM tblAccountData;
END

GO
/****** Object:  StoredProcedure [dbo].[PROC_SelectAllFromCT_HD]    Script Date: 10/25/2024 10:56:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PROC_SelectAllFromCT_HD]
AS
BEGIN
	SELECT * FROM tblCT_HD;
END

GO
/****** Object:  StoredProcedure [dbo].[PROC_SelectAllFromHoaDon]    Script Date: 10/25/2024 10:56:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PROC_SelectAllFromHoaDon]
AS
BEGIN
	SELECT * FROM tblHoaDon;
END

GO
/****** Object:  StoredProcedure [dbo].[PROC_SelectAllFromKhachHang]    Script Date: 10/25/2024 10:56:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PROC_SelectAllFromKhachHang]
AS
BEGIN
	SELECT * FROM tblKhachHang;
END

GO
/****** Object:  StoredProcedure [dbo].[PROC_SelectAllFromMatHang]    Script Date: 10/25/2024 10:56:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PROC_SelectAllFromMatHang]
AS
BEGIN
	SELECT * FROM tblMatHang;
END

GO
/****** Object:  StoredProcedure [dbo].[PROC_SelectAllFromNhaCungCap]    Script Date: 10/25/2024 10:56:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PROC_SelectAllFromNhaCungCap]
AS
BEGIN
	SELECT * FROM tblNhaCungCap;
END

GO
/****** Object:  StoredProcedure [dbo].[PROC_SelectAllFromNhanVien]    Script Date: 10/25/2024 10:56:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PROC_SelectAllFromNhanVien]
AS
BEGIN
	SELECT * FROM tblNhanVien;
END

GO
/****** Object:  StoredProcedure [dbo].[PROC_SelectNhaCungCapByMaNCC]    Script Date: 10/25/2024 10:56:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PROC_SelectNhaCungCapByMaNCC]
    @sMaNCC varchar(30)
AS
BEGIN
    SELECT *
    FROM tblNhaCungCap
    WHERE sMaNCC = @sMaNCC
END

 

GO
/****** Object:  StoredProcedure [dbo].[PROC_UpdateAccountData]    Script Date: 10/25/2024 10:56:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PROC_UpdateAccountData]
	@sUsername varchar(15),
	@sPassword varchar(16)
AS
BEGIN
	UPDATE tblAccountData
	SET sPassword = @sPassword
	WHERE sUsername = @sUsername;
END

GO
/****** Object:  StoredProcedure [dbo].[PROC_UpdateCT_HD]    Script Date: 10/25/2024 10:56:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Stored procedure for updating a record in the tblCT_HD table
CREATE PROCEDURE [dbo].[PROC_UpdateCT_HD]
(
    @sMaHoaDon varchar(30),
    @sMaHang varchar(30),
    @iSL int,
    @fDonGia float,
    @fThanhTien float
)
AS
BEGIN
    UPDATE tblCT_HD
    SET iSL = @iSL,
        fDonGia = @fDonGia,
        fThanhTien = @fThanhTien
    WHERE sMaHoaDon = @sMaHoaDon AND sMaHang = @sMaHang;
END

GO
/****** Object:  StoredProcedure [dbo].[PROC_UpdateHoaDon]    Script Date: 10/25/2024 10:56:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Stored procedure for updating a record in the tblHoaDon table
CREATE PROCEDURE [dbo].[PROC_UpdateHoaDon]
(
    @sMaHoaDon varchar(30),
    @sMaNV varchar(30),
    @sMaKH varchar(30),
    @dNgayDatHang date,
    @dNgayGiaoHang date,
    @sDiaChiGiaoHang varchar(100)
)
AS
BEGIN
    UPDATE tblHoaDon
    SET sMaNV = @sMaNV,
        sMaKH = @sMaKH,
        dNgayDatHang = @dNgayDatHang,
        dNgayGiaoHang = @dNgayGiaoHang,
        sDiaChiGiaoHang = @sDiaChiGiaoHang
    WHERE sMaHoaDon = @sMaHoaDon;
END

GO
/****** Object:  StoredProcedure [dbo].[PROC_UpdateKhachHang]    Script Date: 10/25/2024 10:56:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PROC_UpdateKhachHang]
(
    @sMaKH varchar(30),
    @sHoTenKH nvarchar(50),
    @sDiaChi nvarchar(100),
    @bGioiTinh bit,
    @sSDT varchar(10)
)
AS
BEGIN
    UPDATE tblKhachHang
    SET 
        sHoTenKH = @sHoTenKH,
        sDiaChi = @sDiaChi,
        bGioiTinh = @bGioiTinh,
        sSDT = @sSDT
    WHERE sMaKH = @sMaKH;
END

GO
/****** Object:  StoredProcedure [dbo].[PROC_UpdateMatHang]    Script Date: 10/25/2024 10:56:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Stored procedure for updating a record in the tblMatHang table
CREATE PROCEDURE [dbo].[PROC_UpdateMatHang]
(
    @sMaHang varchar(30),
    @sMaNCC varchar(30),
    @sTenHang nvarchar(100),
    @iSL int,
    @fDonGia float,
    @sMoTa varchar(200)
)
AS
BEGIN
    UPDATE tblMatHang
    SET sMaNCC = @sMaNCC,
        sTenHang = @sTenHang,
        iSL = @iSL,
        fDonGia = @fDonGia,
        sMoTa = @sMoTa
    WHERE sMaHang = @sMaHang;
END

GO
/****** Object:  StoredProcedure [dbo].[PROC_UpdateNhaCungCap]    Script Date: 10/25/2024 10:56:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Stored procedure for updating a record in the tblNhaCungCap table
CREATE PROCEDURE [dbo].[PROC_UpdateNhaCungCap]
(
    @sMaNCC varchar(30),
    @sTenNCC varchar(50)
)
AS
BEGIN
    UPDATE tblNhaCungCap
    SET sTenNCC = @sTenNCC
    WHERE sMaNCC = @sMaNCC;
END

GO
/****** Object:  StoredProcedure [dbo].[PROC_UpdateNhanVien]    Script Date: 10/25/2024 10:56:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PROC_UpdateNhanVien]
    @sMaNV NVARCHAR(50),
    @sHoTenNV NVARCHAR(100),
    @sSDT NVARCHAR(15),
    @dNgaySinh DATE,
    @bGioiTinh BIT,
    @dNgayVaoLam DATE,
    @fLuongCB FLOAT,
    @fPhuCap FLOAT,
    @fHSL FLOAT
AS
BEGIN
    SET NOCOUNT ON;

    -- Kiểm tra nếu nhân viên tồn tại
    IF NOT EXISTS (SELECT 1 FROM tblNhanVien WHERE sMaNV = @sMaNV)
    BEGIN
        RAISERROR('Employee ID not found. Please check the Employee ID.', 16, 1);
        RETURN; -- Kết thúc proc nếu nhân viên không tồn tại
    END

    -- Cập nhật thông tin nhân viên
    UPDATE tblNhanVien
    SET
        sHoTenNV = @sHoTenNV,
        sSDT = @sSDT,
        dNgaySinh = @dNgaySinh,
        bGioiTinh = @bGioiTinh,
        dNgayVaoLam = @dNgayVaoLam,
        fLuongCB = @fLuongCB,
        fPhuCap = @fPhuCap,
        fHSL = @fHSL
    WHERE
        sMaNV = @sMaNV;

    -- Kiểm tra số dòng đã cập nhật
    IF @@ROWCOUNT = 0
    BEGIN
        RAISERROR('No rows updated. Please check the Employee ID.', 16, 1);
    END
END
GO
/****** Object:  StoredProcedure [dbo].[SELECT_ForHoaDon]    Script Date: 10/25/2024 10:56:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROC [dbo].[SELECT_ForHoaDon]
AS
BEGIN
	SELECT hd.*, cthd.*, nv.sMaNV, kh.sMaKH
    FROM tblHoaDon hd
    INNER JOIN tblCT_HD cthd ON hd.sMaHoaDon = cthd.sMaHoaDon
    INNER JOIN tblNhanVien nv ON hd.sMaNV = nv.sMaNV
    INNER JOIN tblKhachHang kh ON hd.sMaKH = kh.sMaKH
END

GO
/****** Object:  StoredProcedure [dbo].[SELECT_ForHoaDon2]    Script Date: 10/25/2024 10:56:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROC [dbo].[SELECT_ForHoaDon2]
AS
BEGIN
	SELECT hd.*, cthd.*, nv.sMaNV, kh.sMaKH
    FROM tblHoaDon hd
    INNER JOIN tblCT_HD cthd ON hd.sMaHoaDon = cthd.sMaHoaDon
    INNER JOIN tblNhanVien nv ON hd.sMaNV = nv.sMaNV
    INNER JOIN tblKhachHang kh ON hd.sMaKH = kh.sMaKH
END

GO
/****** Object:  StoredProcedure [dbo].[SELECT_ForMatHang]    Script Date: 10/25/2024 10:56:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROC [dbo].[SELECT_ForMatHang]
AS
BEGIN
	SELECT mh.*, ncc.sTenNCC
	FROM tblMatHang mh
	INNER JOIN tblNhaCungCap ncc ON mh.sMaNCC = ncc.sMaNCC 
END

EXEC SELECT_ForHoaDon

GO
/****** Object:  StoredProcedure [dbo].[SELECT_FullHoaDon]    Script Date: 10/25/2024 10:56:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SELECT_FullHoaDon]
AS
BEGIN
	SELECT hd.*, cthd.*, nv.sTenNV, kh.sTenKH
	FROM tblHoaDonBanHang hd
	INNER JOIN tblCTHoaDonBanHang cthd ON hd.sMaHDban = cthd.sMaHDban
	INNER JOIN tblNhanVien nv ON hd.iMaNV = nv.iMaNV
	INNER JOIN tblKhachHang kh ON hd.iMaKH = kh.iMaKH
END
GO
USE [master]
GO
ALTER DATABASE [QLBHMT] SET  READ_WRITE 
GO
