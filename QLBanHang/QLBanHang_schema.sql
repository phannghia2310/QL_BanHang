IF NOT EXISTS (SELECT * FROM sys.databases WHERE name='QLBanHangDB')
	BEGIN
		CREATE DATABASE [QLBanHangDB]
	END
GO
USE [QLBanHangDB]
GO

--Bang ChucVu
CREATE TABLE [ChucVu] (
	[MaCV] char(10) NOT NULL,
	[TenCV] nvarchar(50) NULL,
	CONSTRAINT pk_ChucVu PRIMARY KEY ([MaCV])
);

--Bang NhanVien
CREATE TABLE [NhanVien] (
	[MaNV] char(10) NOT NULL,
	[MaCV] char(10) NULL,
	[MaQL] char(10) NULL,
	[TenNV] nvarchar(50) NULL,
	[GioiTinh] nvarchar(5) NULL,
	[NgaySinh] datetime NULL,
	[DiaChi] nvarchar(100) NULL,
	[SDT] char(10) NULL,
	CONSTRAINT pk_NhanVien PRIMARY KEY ([MaNV])
);

ALTER TABLE [NhanVien]
ADD CONSTRAINT fk_NhanVien_ChucVu FOREIGN KEY ([MaCV]) REFERENCES [ChucVu] ([MaCV])
GO
ALTER TABLE [NhanVien]
ADD CONSTRAINT fk_NhanVien_QuanLy FOREIGN KEY ([MaQL]) REFERENCES [NhanVien] ([MaNV])
GO

--Bang QuyenDangNhap
CREATE TABLE [QuyenDangNhap] (
	[TenDangNhap] nvarchar(50) NOT NULL,
	[MaNV] char(10) NULL,
	[MaCV] char(10) NULL,
	[MatKhau] nvarchar(50) NULL,
	CONSTRAINT pk_QuyenDangNhap PRIMARY KEY ([TenDangNhap])
);

ALTER TABLE [QuyenDangNhap]
ADD CONSTRAINT fk_QuyenDangNhap_NhanVien FOREIGN KEY ([MaNV]) REFERENCES [NhanVien] ([MaNV])
GO
ALTER TABLE [QuyenDangNhap]
ADD CONSTRAINT fk_QuyenDangNhap_ChucVu FOREIGN KEY ([MaCV]) REFERENCES [ChucVu] ([MaCV])
GO

--Bang NhaCungCap
CREATE TABLE [NhaCungCap] (
	[MaNCC] char(10) NOT NULL,
	[TenNCC] nvarchar(50) NULL,
	[DiaChi] nvarchar(100) NULL,
	[SDT] char(10) NULL,
	[Fax] char(15) NULL,
	[Email] nvarchar(50) NULL,
	CONSTRAINT pk_NhaCungCap PRIMARY KEY ([MaNCC])
);

--Bang KhachHang
CREATE TABLE [KhachHang] (
	[MaKH] char(10) NOT NULL,
	[TenKH] nvarchar(50) NULL,
	[GioiTinh] nvarchar(5) NULL,
	[DiaChi] nvarchar(100) NULL,
	[SDT] char(10) NULL,
	CONSTRAINT pk_KhachHang PRIMARY KEY ([MaKH])
);

--Bang HangX
CREATE TABLE [HangSX] (
	[MaHangSX] char(10) NOT NULL,
	[TenHangSX] nvarchar(50) NULL,
	CONSTRAINT pk_HangSX PRIMARY KEY ([MaHangSX])
);

--Bang NganhHang
CREATE TABLE [NganhHang] (
	[MaNganhHang] char(10) NOT NULL,
	[TenNganhHang] nvarchar(50) NULL,
	CONSTRAINT pk_NganhHang PRIMARY KEY ([MaNganhHang])
);

--Bang NhomHang
CREATE TABLE [NhomHang] (
	[MaNhomHang] char(10) NOT NULL,
	[MaNganhHang] char(10) NULL,
	[TenNhomHang] nvarchar(50) NULL,
	CONSTRAINT pk_NhomHang PRIMARY KEY ([MaNhomHang])
);

ALTER TABLE [NhomHang]
ADD CONSTRAINT fk_NhomHang_NganhHang FOREIGN KEY ([MaNganhHang]) REFERENCES [NganhHang] ([MaNganhHang])
GO

--Bang HangHoa
CREATE TABLE [HangHoa] (
	[MaHang] char(20) NOT NULL,
	[MaNhomHang] char(10) NULL,
	[MaHangSX] char(10) NULL,
	[TenHang] nvarchar(50) NULL,
	[DVT] nvarchar(20) NULL,
	[DonGia] int NULL,
	[VAT] int NULL,
	CONSTRAINT pk_HangHoa PRIMARY KEY ([MaHang])
);

ALTER TABLE [HangHoa]
ADD CONSTRAINT fk_HangHoa_HangSX FOREIGN KEY ([MaHangSX]) REFERENCES [HangSX] ([MaHangSX])
GO
ALTER TABLE [HangHoa]
ADD CONSTRAINT fk_HangHoa_NhomHang FOREIGN KEY ([MaNhomHang]) REFERENCES [NhomHang] ([MaNhomHang])
GO

--Bang PhieuNhap
CREATE TABLE [PhieuNhap] (
	[MaPN] char(10) NOT NULL,
	[MaNCC] char(10) NULL,
	[MaNV] char(10) NULL,
	[NgayNhap] datetime NULL,
	[TongTienNhap] int NULL,
	CONSTRAINT pk_PhieuNhap PRIMARY KEY ([MaPN])
);

ALTER TABLE [PhieuNhap]
ADD CONSTRAINT fk_PhieuNhap_NhaCungCap FOREIGN KEY ([MaNCC]) REFERENCES [NhaCungCap] ([MaNCC])
GO
ALTER TABLE [PhieuNhap]
ADD CONSTRAINT fk_PhieuNhap_NhanVien FOREIGN KEY ([MaNV]) REFERENCES [NhanVien] ([MaNV])
GO

--Bang ChiTietPhieuNhap
CREATE TABLE [ChiTietPhieuNhap] (
	[MaPN] char(10) NOT NULL,
	[MaHang] char(20) NOT NULL,
	[GiaNhap] int NULL,
	[SoLuong] int NULL,
	[ChietKhau] int NULL,
	[ThanhTien] int NULL,
	CONSTRAINT pk_ChiTietPhieuNhap PRIMARY KEY ([MaPN],[MaHang])
);

ALTER TABLE [ChiTietPhieuNhap]
ADD CONSTRAINT fk_ChiTetPhieuNhap_PhieuNhap FOREIGN KEY ([MaPN]) REFERENCES [PhieuNhap] ([MaPN])
GO
ALTER TABLE [ChiTietPhieuNhap]
ADD CONSTRAINT fk_ChiTietPhieuNhap_HangHoa FOREIGN KEY ([MaHang]) REFERENCES [HangHoa] ([MaHang])
GO

--Bang HoaDonBanHang
CREATE TABLE [HoaDonBanHang] (
	[MaHD] char(10) NOT NULL,
	[MaKH] char(10) NULL,
	[MaNV] char(10) NULL,
	[NgayBan] datetime NULL,
	[TongTienHD] int NULL,
	CONSTRAINT pk_HoaDonBanHang PRIMARY KEY ([MaHD])
);

ALTER TABLE [HoaDonBanHang]
ADD CONSTRAINT fk_HoaDonBanHang_KhachHang FOREIGN KEY ([MaKH]) REFERENCES [KhachHang] ([MaKH])
GO
ALTER TABLE [HoaDonBanHang]
ADD CONSTRAINT fk_HoaDonBanHang_NhanVien FOREIGN KEY ([MaNV]) REFERENCES [NhanVien] ([MaNV])
GO

--Bang ChiTietHoaDon
CREATE TABLE [ChiTietHoaDon] (
	[MaHD] char(10) NOT NULL,
	[MaHang] char(20) NOT NULL,
	[GiaBan] int NULL,
	[SoLuong] int NULL,
	[VAT] int NULL,
	[ThanhTien] int NULL,
	CONSTRAINT pk_ChiTietHoaDon PRIMARY KEY ([MaHD],[MaHang])
);

ALTER TABLE [ChiTIetHoaDon]
ADD CONSTRAINT fk_ChiTietHoaDon_HoaDonBanHang FOREIGN KEY ([MaHD]) REFERENCES [HoaDonBanHang] ([MaHD])
GO
ALTER TABLE [ChiTietHoaDon]
ADD CONSTRAINT fk_ChiTietHoaDon_HangHoa FOREIGN KEY ([MaHang]) REFERENCES [HangHoa] ([MaHang])
GO

