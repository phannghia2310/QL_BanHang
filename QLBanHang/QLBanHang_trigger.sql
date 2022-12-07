USE [QuanLyBanHang]
GO

--FUNCTION
---Tính tuổi của nhân viên
CREATE FUNCTION fnc_TinhTuoi(@ngay date)
RETURNS int
AS
BEGIN
	DECLARE @KetQua int
	SET @KetQua = YEAR(GETDATE()) - YEAR(@ngay)
	RETURN @KetQua
END
GO

--STORED PROCEDURE
---Thủ tục hiển thị thông tin cấp trên trực tiếp của một nhân viên
CREATE PROC sp_ThongTin_QuanLy_TrucTiep
	@MaNV int
AS
BEGIN
	SELECT * FROM NhanVien WHERE MANV = (SELECT MaQL FROM NhanVien WHERE MaNV = @MaNV)
END
GO

---Thủ tục lấy ra tất cả các nhân viên cấp trên của một nhân viên nào đó
CREATE PROC sp_TatCa_CapTren
	@MaNV char(10)
AS
BEGIN
		WITH Generation(MaNV) AS (
			SELECT MaQL FROM NhanVien WHERE MaNV = @MaNV
			UNION ALL -- First recursive member returns male ancestors of the previous generation.
			SELECT NhanVien.MaQL FROM Generation, NhanVien WHERE Generation.MaNV = NhanVien.MaNV
		)
		SELECT NhanVien.MaNV, TenNV, MaQL
		FROM Generation, NhanVien WHERE Generation.MaNV = NhanVien.MaNV;
END
GO


--TRIGGER
--- Trigger kiểm tra để không có nhân viên nào tự quản lý chính mình
CREATE TRIGGER tr_NhanVien_Khac_QuanLy ON NhanVien
AFTER INSERT
AS
IF EXISTS (SELECT * FROM inserted WHERE MaQL = MaNV)
BEGIN
	ROLLBACK TRANSACTION
		RAISERROR('MaQL <> MaNV !!', 16, 1)
	RETURN
END
GO

--- Trigger Kiểm tra Chỉ có một Quản lý cao nhất
CREATE TRIGGER tr_DuyNhat_QuanLy_CaoNhat ON NhanVien
FOR INSERT, UPDATE
AS
IF EXISTS (SELECT * FROM inserted WHERE MaQL IS NULL)
		AND ((SELECT count(*) FROM NhanVien WHERE NhanVien.MaQL IS NULL) >= 2)
BEGIN
	ROLLBACK TRANSACTION
		RAISERROR('Exit Header',16,1)
	RETURN
END
GO


--- Trigger kiểm tra cấp trên có tồn tại hay không, nếu không tồn tại thì không cho chèn
CREATE TRIGGER tr_TonTai_CapTren ON NhanVien
FOR INSERT, UPDATE
AS
IF NOT EXISTS(SELECT * FROM NhanVien, inserted
				WHERE NhanVien.MaNV = inserted.MaNV OR inserted.MaQL IS NULL)
BEGIN
	ROLLBACK TRANSACTION
		RAISERROR('Không tồn tại cấp trên này!',16, 1)
	RETURN
END
GO

--- Trigger Xóa hóa đơn bán hàng
CREATE TRIGGER tr_Xoa_HoaDonBanHang ON HoaDonBanHang
FOR DELETE
AS
BEGIN
	DELETE FROM ChiTietHoaDon WHERE ChiTietHoaDon.MaHD in (SELECT MaHD FROM deleted)
	DELETE FROM HoaDonBanHang WHERE HoaDonBanHang.MaHD in (SELECT MaHD FROM deleted)
END
GO

--- Trigger Xóa Phiếu nhập
CREATE TRIGGER tr_Xoa_PhieuNhap ON PhieuNhap
FOR DELETE
AS
BEGIN
	DELETE FROM ChiTietPhieuNhap WHERE ChiTietPhieuNhap.MaPN in (SELECT MaPN FROM deleted)
	DELETE FROM PhieuNhap WHERE PhieuNhap.MaPN in (SELECT MaPN FROM deleted)
END
GO

--- Trigger Xóa Phiếu xuất
CREATE TRIGGER tr_Xoa_PhieuXuat ON PhieuXuat
FOR DELETE
AS
BEGIN
	DELETE FROM ChiTietPhieuXuat WHERE ChiTietPhieuXuat.MaPX in (SELECT MaPX FROM deleted)
	DELETE FROM PhieuXuat WHERE PhieuXuat.MaPX in (SELECT MaPX FROM deleted)
END
GO



--nhóm Phát
--1. PhieuNhap
USE [QuanLyBanHang]
GO

--Them CT_PhieuNhap
CREATE OR ALTER TRIGGER tr_Them_CT_PhieuNhap ON ChiTietPhieuNhap
AFTER INSERT
AS
BEGIN
	DECLARE @GiaNhap int, @SoLuong int, @ChietKhau int, @TongTien int
	SELECT @GiaNhap = GiaNhap, @SoLuong = SoLuong, @ChietKhau = ChietKhau
	FROM inserted 
	WHERE MaPN = inserted.MaPN

	SET @TongTien = ((@GiaNhap*@SoLuong)-(@GiaNhap*@SoLuong*(@ChietKhau/100)))
	
	UPDATE PhieuNhap
	SET TongTienNhap = TongTienNhap + @TongTien
	FROM PhieuNhap JOIN inserted ON PhieuNhap.MaPN = inserted.MaPN
END
GO

select * FROM PhieuNhap WHERE MaPN = 'PN0001';
--44046450
insert into ChiTietPhieuNhap values ('PN0001', 'UA40EH5300', 6604500, 4, 10);
--70464450
GO

--Sua CT_PhieuNhap
CREATE OR ALTER TRIGGER tr_Sua_CT_PhieuNhap ON ChiTietPhieuNhap
AFTER UPDATE
AS
BEGIN
	UPDATE PhieuNhap
	SET TongTienNhap = TongTienNhap - (SELECT ((GiaNhap*SoLuong)-(GiaNhap*SoLuong*(ChietKhau/100))) 
											FROM inserted WHERE MaPN = PhieuNhap.MaPN)
									+ (SELECT ((GiaNhap*SoLuong)-(GiaNhap*SoLuong*(ChietKhau/100))) 
											FROM deleted WHERE MaPN = PhieuNhap.MaPN)
	FROM PhieuNhap JOIN deleted ON PhieuNhap.MaPN = deleted.MaPN
END
GO

select * FROM PhieuNhap WHERE MaPN = 'PN0001';
--70464450
UPDATE ChiTietPhieuNhap
SET GiaNhap = 7000000
WHERE MaPN = 'PN0001' AND MaHang = 'UA40EH5300';
--68882450
GO

--Xoa CT_PhieuNhap
CREATE OR ALTER TRIGGER tr_Xoa_CT_PhieuNhap ON ChiTietPhieuNhap
FOR DELETE
AS
BEGIN
	UPDATE PhieuNhap
	SET TongTienNhap = TongTienNhap - (SELECT ((GiaNhap*SoLuong)-(GiaNhap*SoLuong*(ChietKhau/100))) FROM deleted WHERE MaPN = PhieuNhap.MaPN)
	FROM PhieuNhap JOIN deleted ON PhieuNhap.MaPN = deleted.MaPN
END
GO

select * FROM PhieuNhap WHERE MaPN = 'PN0001';
--68882450
DELETE FROM ChiTietPhieuNhap WHERE MaHang = 'UA40EH5300' AND MaPN = 'PN0001';
--40882450
-- câu hỏi Hunhf Ngọc Tài
--Tạo thêm bảng sanpham_updatate (masp, gia1, gia2, gia3). Viết trigger khi thêm mới hoặc
--cập nhật giá của bảng sản phẩm thì Gia1, gia2, gia3 sẽ lưu lại 3 lịch sử giá gần nhất
use [QuanLyBanHang]
go
create table sanpham_updatate
(
Mahang char(20) primary key,
MaNhomHang nvarchar(10),
DonGia1 money,
DonGia2 money,
DonGia3 money);
GO

drop table sanpham_updatate;
GO
create or alter trigger San_Pham
on HangHoa
after insert , update
as
begin
	declare @gia int , @masp char(20)
	select @gia = DonGia , @masp =MaHang
	from inserted
	if not exists (select * from HangHoa where DonGia=@gia and MaHang=@masp)
		begin
			insert into sanpham_updatate values (@masp,null,@gia, null,null);
		end
	else begin
			update sanpham_updatate
			set DonGia3=DonGia2 , DonGia2=DonGia1,DonGia1=@gia,Mahang=@masp
	end
end

insert into HangHoa values ('AS09TUQN-90000BTY','DieuHoa','14',N'Điều hòa Samsung AS09TUQN-90000BTY','Chiếc',6290000,5);

update HangHoa
set DonGia = 6000000
WHERE MaHang ='AS09TUQN-90000BTY';

select * from HangHoa;

GO
--nhom Vo Van Trong
--- Trigger kiểm tra cấp trên có tồn tại hay không, nếu không tồn tại thì không cho chèn
CREATE TRIGGER tr_TonTai_CapTren ON NhanVien
FOR INSERT, UPDATE
AS
IF EXISTS (SELECT * FROM NhanVien, inserted
			WHERE NhanVien.MaQL != inserted.MaQL OR inserted.MaQL IS NULL)
	BEGIN
		ROLLBACK TRANSACTION
			RAISERROR('Không tồn tại cấp trên này!',16, 1)
		RETURN
	END
GO

select * from NhanVien;

delete from NhanVien where MaNV = 'NV0037';

insert into NhanVien values ('NV0011', '05', 'NV0007', N'Nguyễn Thành Ðạt', 'Nam', '1983-03-17', N'TP. Hồ Chí Minh', '0943609958');

update NhanVien
SET MaQL = 'NV0007'
WHERE MaNV = 'NV0002';