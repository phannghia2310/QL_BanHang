USE [QLBanHangDB]
GO

--Drop table
DROP TABLE [ChiTietHoaDon];
DROP TABLE [HoaDonBanHang];
DROP TABLE [ChiTietPhieuNhap];
DROP TABLE [PhieuNhap];
DROP TABLE [HangHoa];
DROP TABLE [NhomHang];
DROP TABLE [NganhHang];
DROP TABLE [HangSX];
DROP TABLE [KhachHang];
DROP TABLE [NhaCungCap];
DROP TABLE [QuyenDangNhap];
DROP TABLE [NhanVien];
DROP TABLE [ChucVu];

---Drop FUNCTION, STORED PROCEDURE, TRIGGER
DROP FUNCTION FNC_TinhTuoi;
DROP PROC sp_ThongTin_QuanLy_TrucTiep;
DROP PROC sp_TatCa_CapTren;
DROP TRIGGER trg_NhanVien_Khac_QuanLy;
DROP TRIGGER trg_DuyNhat_QuanLy_CaoNhat;
DROP TRIGGER trg_NhanVien_Tu_QuanLy_Minh;
DROP TRIGGER trg_TonTai_CapTren;
DROP TRIGGER trg_Xoa_HoaDonBanHang;
DROP TRIGGER trg_Xoa_PhieuNhap;