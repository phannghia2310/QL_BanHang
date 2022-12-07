USE [QLBanHangDB]
GO

ALTER TABLE [ChiTietHoaDon] NOCHECK CONSTRAINT [fk_ChiTietHoaDon_HangHoa];
ALTER TABLE [ChiTietHoaDon] NOCHECK CONSTRAINT [fk_ChiTietHoaDon_HoaDonBanHang];
ALTER TABLE [ChiTietPhieuNhap] NOCHECK CONSTRAINT [fk_ChiTetPhieuNhap_PhieuNhap];
ALTER TABLE [ChiTietPhieuNhap] NOCHECK CONSTRAINT [fk_ChiTietPhieuNhap_HangHoa];
ALTER TABLE [HangHoa] NOCHECK CONSTRAINT [fk_HangHoa_HangSX];
ALTER TABLE [HangHoa] NOCHECK CONSTRAINT [fk_HangHoa_NhomHang];
ALTER TABLE [HoaDonBanHang] NOCHECK CONSTRAINT [fk_HoaDonBanHang_KhachHang];
ALTER TABLE [HoaDonBanHang] NOCHECK CONSTRAINT [fk_HoaDonBanHang_NhanVien];
ALTER TABLE [NhanVien] NOCHECK CONSTRAINT [fk_NhanVien_ChucVu];
ALTER TABLE [NhanVien] NOCHECK CONSTRAINT [fk_NhanVien_QuanLy];
ALTER TABLE [NhomHang] NOCHECK CONSTRAINT [fk_NhomHang_NganhHang];
ALTER TABLE [PhieuNhap] NOCHECK CONSTRAINT [fk_PhieuNhap_NhaCungCap];
ALTER TABLE [PhieuNhap] NOCHECK CONSTRAINT [fk_PhieuNhap_NhanVien];
ALTER TABLE [QuyenDangNhap] NOCHECK CONSTRAINT [fk_QuyenDangNhap_ChucVu];
ALTER TABLE [QuyenDangNhap] NOCHECK CONSTRAINT [fk_QuyenDangNhap_NhanVien];

--Du lieu bang ChucVu
INSERT INTO [ChucVu] ([MaCV],[TenCV])
VALUES
	('01', N'Giám đốc'),
	('02', N'Quản lý nhập hàng'),
	('03', N'Nhân viên nhập hàng'),
	('04', N'Quản lý xuất hàng'),
	('05', N'Nhân viên xuất hàng'),
	('06', N'Quản lý bán hàng'),
	('07', N'Nhân viên bán hàng')
GO
--Du lieu bang NhanVien
INSERT INTO [NhanVien] ([MaNV],[MaCV],[MaQL],[TenNV],[GioiTinh],[NgaySinh],[DiaChi],[SDT])
VALUES
	('NV0001', '01', null, N'Nguyễn Thành Ðạt', N'Nam', '1983-03-17 00:00:00.000', N'TP. Hồ Chí Minh', '0943609958'),
	('NV0002', '02', 'NV0001', N'Nguyễn Minh Hiếu', N'Nam', '1987-05-26 00:00:00.000', N'TP. Hồ Chi Minh', '0918161328'),
	('NV0003', '03', 'NV0002', N'Phạm Hiếu Nghĩa', N'Nam', '1993-04-03 00:00:00.000', N'TP. Hồ Chi Minh', '0914309340'),
	('NV0004', '03', 'NV0002', N'Hoàng Thế Doanh', N'Nam', '1996-05-25 00:00:00.000', N'TP. Hồ Chi Minh', '0916441869'),
	('NV0005', '04', 'NV0001', N'Hoàng Tùng Quang', N'Nam', '1986-04-03 00:00:00.000', N'TP. Hồ Chi Minh', '0845144605'),
	('NV0006', '05', 'NV0005', N'Võ Phương Anh', N'Nữ', '1996-01-08 00:00:00.000', N'TP. Hồ Chi Minh', '0953136490'),
	('NV0007', '05', 'NV0005', N'Đỗ Cường Thịnh', N'Nam', '1998-03-08 00:00:00.000', N'TP. Hồ Chi Minh', '0818502404'),
	('NV0008', '06', 'NV0001', N'Nguyễn Thi Thi', N'Nữ', '1986-04-03 00:00:00.000', N'TP. Hồ Chi Minh', '0900905367'),
	('NV0009', '07', 'NV0008', N'Trần Quế Thu', N'Nữ', '1998-05-18 00:00:00.000', N'TP. Hồ Chi Minh', '0976797202'),
	('NV0010', '07', 'NV0008', N'Huỳnh Ánh Tuyết', N'Nữ', '1997-10-31 00:00:00.000', N'TP. Hồ Chi Minh', '0887921819')
GO

--Du lieu bang QuyenDangNhap
INSERT INTO [QuyenDangNhap] ([TenDangNhap],[MaNV],[MaCV],[MatKhau])
VALUES
	(N'boss','NV0001','01', N'12345'),
	(N'qlnhaphang','NV0002','02', N'12345'),
	(N'nvnhaphang','NV0003','03', N'12345'),
	(N'qlxuathang','NV0005','04', N'12345'),
	(N'nvxuathang','NV0006','05', N'12345'),
	(N'qlbanhang','NV0008','06', N'12345'),
	(N'nvbanhang','NV0009','07', N'12345')
GO

--Du lieu bang NhaCungCap
INSERT INTO [NhaCungCap] ([MaNCC],[TenNCC],[DiaChi],[SDT],[Fax],[Email])
VALUES
	('NCC0001', N'Công ty Điện tử SamSung Vina', N'102 Nguyễn Du; 64-66 Trần Hưng Đạo, Quận 1', '0910081919', '(09) 10081919', N'samungvina@gmail.com'),
	('NCC0002', N'Công ty TNHH Kỷ Nguyên Mới', N'Hà Nội', '0494647279', '(04) 94647279', N'kynguyenmoi@gmail.com'),
	('NCC0003', N'Công ty TNHH Ninh An', N'Hà Nội', '0467421289', '(04) 67421289', N'ninhan@gmail.com'),
	('NCC0004', N'Công ty Panasonic', N'Hà Nội', '0459693351', '(04) 59693351', N'panasonic@gmail.com'),
	('NCC0005', N'Công ty Philips Việt Nam', N'Tầng 16, Tòa nhà Ladeco, 266 Đội Cấn, Quận Ba Đình', '0426405685', '(04) 26405685', N'phiilipsvietnam@gmail.com'),
	('NCC0006', N'CÔNG TY TNHH SONY ELECTRONICS VIỆT NAM', N'248A Nơ Trang Long, Phường 12, Quận Bình Thạnh, Tp. Hồ Chí Minh', '0900965273', '(09) 00965273', N'sonyelectronics@gmail.com'),
	('NCC0007', N'Công ty LG Electronics', N'Tầng 35, tòa nhà Keangnam Landmark Tower, Phạm Hùng, Hà nội', '0472876134', '(04) 72876134', N'lgelectronis@gmail.com'),
	('NCC0008', N'Công ty Toshiba Việt Nam', N'KHU CÔNG NGHIỆP THĂNG LONG-ĐÔNG ANH-HÀ NÔI', '0492556034', '(04) 92556034', N'toshibavietnam@gmail.com')
GO

--Du lieu bang KhachHang
INSERT INTO [KhachHang] ([MaKH],[TenKH],[GioiTinh],[DiaChi], [SDT])
VALUES
	('KH0001',N'Trần Uyển Nhi',N'Nữ',N'TP. Hồ Chí Minh','0933911446'),	
	('KH0002',N'Trần Minh Châu',N'Nữ',N'TP. Hồ Chí Minh','0935322275'),	
	('KH0003',N'Đặng Ngân Thanh',N'Nữ',N'TP. Hồ Chí Minh','0965770754'),	
	('KH0004',N'Trần Ngọc Bảo',N'Nam',N'TP. Hồ Chí Minh','0918570219'),	
	('KH0005',N'Trần Công Danh',N'Nam',N'TP. Hồ Chí Minh','0947132164'),	
	('KH0006',N'Hoàng Tú Bình',N'Nữ',N'TP. Hồ Chí Minh','0983491023'),	
	('KH0007',N'Nguyễn Thanh Thu',N'Nữ',N'TP. Hồ Chí Minh','0952378866'),	
	('KH0008',N'Nguyễn Hiệp Hòa',N'Nam',N'TP. Hồ Chí Minh','0924789750'),	
	('KH0009',N'Phan Hữu Minh',N'Nam',N'TP. Hồ Chí Minh','0951361129'),	
	('KH0010',N'Lê Tiến Hiệp',N'Nam',N'TP. Hồ Chí Minh','0909020413')
GO

--Du lieu bang HangSX
INSERT INTO [HangSX] ([MaHangSX],[TenHangSX])
VALUES
	('01','SamSung'),
	('02','LG'),
	('03','ToShiBa'),
	('04','Electrolux'),
	('05','Sony'),
	('06','Dell'),
	('07','Panasonic'),
	('08','Canon'),
	('10','Acer'),
	('11','Apple'),
	('12','HP'),
	('13','Nokia'),
	('14','Sharp'),
	('15','Sanyo'),
	('16','Philips'),
	('17','Asus')
GO

--Du lieu bang NganhHang
INSERT INTO [NganhHang] ([MaNganhHang],[TenNganhHang])
VALUES
	('01',N'Điện tử'),
	('02',N'Điện lạnh'),
	('03',N'Viễn thông'),
	('04',N'Gia dụng'),
	('05',N'Nội thất')
GO

--Du lieu bang NhomHang
INSERT INTO [NhomHang] ([MaNhomHang],[MaNganhHang],[TenNhomHang])
VALUES
	('Bep1','04',N'Bếp gas'),  
	('Bep2','04',N'Bếp điện từ'),  
	('Catsseste','01',N'Catsseste'),  
	('DanAmThanh','01',N'Dàn âm thanh'),      
	('Dau1','01',N'Đầu DVD'),  
	('Dau2','01',N'Đầu kỹ thuật số'),  
	('DienThoai','03',N'Điện thoại di động'),  
	('DienThoai1','03',N'Điện thoại để bàn'),  
	('DieuHoa','02',N'Điều hòa'),      
	('LinhKien','01',N'Linh kiện và phụ kiện'),   
	('Lo1','04',N'Lò vi sóng'),  
	('Lo2','04',N'Lò Nướng'),      
	('Loa','01',N'Loa'),  
	('ManHinh','01',N'Màn hình máy tính'),  
	('MayAnh','01',N'Máy ảnh'),  
	('MaydaCN','03',N'Máy đa chức năng'),      
	('MayFax','03',N'Máy fax'),  
	('MayGiat','02',N'Máy giặt'),      
	('MayIn','01',N'Máy in'),  
	('MayNhac','01',N'Máy nghe nhạc'),  
	('MayPhat','02',N'Máy phát điện'),  
	('MayQuay','01',N'Máy quay'),      
	('MayRua','02',N'Máy rửa chén'),      
	('MaySay','02',N'Máy sấy'),  
	('MayTinh1','01',N'Máy tính xách tay'),  
	('MayTinh2','01',N'Máy tính để bàn'),  
	('MayTinh3','01',N'Máy tính tay'),      
	('MayTinh4','03',N'Máy tính bảng'),  
	('MayXay','04',N'Máy xay sinh tố'),  
	('Tivi1','01',N'Tivi LED'),      
	('Tivi2','01',N'Tivi LCD'),      
	('Tivi3','01',N'Tivi CRT'),      
	('Tivi4','01',N'Tivi PLASMA'),  
	('TuDong','02',N'Tủ đông'),  
	('TuLanh','02',N'Tủ lạnh'),  
	('TuMat','02',N'Tủ mát')
GO

--Du lieu bang HangHoa
INSERT INTO [HangHoa] ([MaHang],[MaNhomHang],[MaHangSX],[TenHang],[DVT],[DonGia],[VAT])
VALUES
	('3330MT-D3U61PA','MayTinh2','12',N'Máy tính để bàn HP Pro 3330MT-D3U61PA',N'Chiếc',7740000,5),
	('3520-GGX2X3','MayTinh1','06',	N'Máy tính xách tay Dell Inspiron 3520-GGX2X3',N'Chiếc',12390000,5),
	('40LE835M','Tivi1','14',N'Tivi Led Samsung 40LE835M',N'Chiếc',14890000,5),
	('AS09TUQN-90000BTU','DieuHoa','14',N'Điều hòa Samsung AS09TUQN-90000BTU',N'Chiếc',6290000,5),
	('EMS3067X','Lo1','04',N'Lò vi sóng Electrolux EMS3067X',N'Chiếc',4450000,5),
	('EWF10751-7kg','MayGiat','04',N'Máy giặt Electrolux EWF10751-7kg',N'Chiếc',11289000,5),
	('GR-K21VUB-188','DieuHoa','03',N'Tủ lạnh Toshiba GR-K21VUB-188 lít',N'Chiếc',7380000,5),
	('HT904KA','DanAmThanh','02',N'Dàn âm thanh LG HT904KA',N'Chiếc',8390000,5),
	('HT-D455K','Tivi1','01',N'Dàn âm thanh SamSung HT-D455K',N'Chiếc',6490000,5),
	('KDL-40EX650','Tivi1','05',N'Tivi Sony KDL-40EX650',N'Chiếc',14900000,5),
	('L29B340','Tivi2','02',N'Tivi TCL LG L29B340',N'Chiếc',4290000,5),
	('NA-F70H2-7kg','MayGiat','07',N'Máy giặt Panasonic NA-F70H2-7kg',N'Chiếc',4290000,5),
	('S09EN1-9000BTU','DieuHoa','02',N'Điều hòa LG S09EN1-9000BTU',N'Chiếc',5990000,5),
	('S400CA-CA004H','MayTinh1','17',N'Máy tính xách tay Asus S400CA-CA004H',N'Chiếc',14990000,5),
	('SJ188S-SL-180','TuLanh','14',N'Tủ lạnh Sharp SJ188S-SL-180',N'Chiếc',5290000,5),
	('UA40EH5300','Tivi1','01',N'Tivi Led Samsung UA40EH5300',N'Chiếc',10900000,5)
GO

--Du lieu bang PhieuNhap
INSERT INTO [PhieuNhap] ([MaPN],[MaNCC],[MaNV],[NgayNhap],[TongTienNhap])
VALUES
	('PN0001', 'NCC0001', 'NV0003', '2022-05-31 00:00:00.000', 44802450),
	('PN0002', 'NCC0002', 'NV0004', '2022-01-06 00:00:00.000', 43885800),
	('PN0003', 'NCC0003', 'NV0003', '2022-02-16 00:00:00.000', 56662200),
	('PN0004', 'NCC0001', 'NV0004', '2022-02-25 00:00:00.000', 72103500),
	('PN0005', 'NCC0004', 'NV0004', '2022-03-16 00:00:00.000', 20270250),
	('PN0006', 'NCC0002', 'NV0003', '2022-06-24 00:00:00.000', 39992400),
	('PN0007', 'NCC0007', 'NV0003', '2022-05-09 00:00:00.000', 20270250),
	('PN0008', 'NCC0005', 'NV0004', '2022-04-22 00:00:00.000', 25231500),
	('PN0009', 'NCC0008', 'NV0003', '2022-07-29 00:00:00.000', 34993350)
GO

--Du lieu bang ChiTietPhieuNhap
INSERT INTO [ChiTietPhieuNhap] ([MaPN],[MaHang],[GiaNhap],[SoLuong],[ChietKhau],[ThanhTien])
VALUES
	('PN0001', 'AS09TUQN-90000BTU', 6604500, 4,10,23776200),
	('PN0001', 'EMS3067X',4672500,5,10,21026250),
	('PN0002', '3330MT-D3U61PA', 8127000, 6,10,43885800),
	('PN0003', 'S400CA-CA004H', 15739500, 4,10,56662200),
	('PN0004', 'UA40EH5300', 11445000, 7,10,72103500),
	('PN0005', 'NA-F70H2-7kg', 4504500, 5,10,20270250),
	('PN0006', 'SJ188S-SL-180', 5554500, 8,10,39992400),
	('PN0007', 'L29B340', 4504500, 5,10,20270250),
	('PN0008', 'EMS3067X', 4672500, 6,10,25231500),
	('PN0009', 'GR-K21VUB-188', 5554500, 7,10,34993350)
GO

--Du lieu bang HoaDonBanHang
INSERT INTO [HoaDonBanHang] ([MaHD],[MaKH],[MaNV],[NgayBan],[TongTienHD])
VALUES
	('HD0001', 'KH0001', 'NV0009', '2022-10-05 00:00:00.000', 9553950),
	('HD0002', 'Kh0002', 'NV0009', '2022-10-07 00:00:00.000', 20882400),
	('HD0003', 'KH0003', 'NV0010', '2022-10-02 00:00:00.000', 11319000),
	('HD0004', 'KH0001', 'NV0009', '2022-09-26 00:00:00.000', 24633000),
	('HD0005', 'KH0004', 'NV0010', '2022-09-29 00:00:00.000', 7654500)
GO

--Du lieu bang ChiTietHoaDon
INSERT INTO [ChiTietHoaDon] ([MaHD] ,[MaHang],[GiaBan],[SoLuong],[VAT],[ThanhTien])
VALUES
	('HD0001', '3330MT-D3U61PA', 9099000, 1,5,9553950),
	('HD0002', 'GR-K21VUB-188', 6299000, 2,5,13227900),
	('HD0003', 'NA-F70H2-7kg', 5390000, 2,5,11319000),
	('HD0004', 'SJ188S-SL-180', 5390000, 3,5,16978500),
	('HD0002', 'AS09TUQN-90000BTU', 7290000, 1,5,7654500),
	('HD0005', 'AS09TUQN-90000BTU', 7290000, 1,5,7654500),
	('HD0004', 'AS09TUQN-90000BTU', 7290000, 1,5,7654500)
GO

ALTER TABLE [ChiTietHoaDon] CHECK CONSTRAINT [fk_ChiTietHoaDon_HangHoa];
ALTER TABLE [ChiTietHoaDon] CHECK CONSTRAINT [fk_ChiTietHoaDon_HoaDonBanHang];
ALTER TABLE [ChiTietPhieuNhap] CHECK CONSTRAINT [fk_ChiTetPhieuNhap_PhieuNhap];
ALTER TABLE [ChiTietPhieuNhap] CHECK CONSTRAINT [fk_ChiTietPhieuNhap_HangHoa];
ALTER TABLE [HangHoa] CHECK CONSTRAINT [fk_HangHoa_HangSX];
ALTER TABLE [HangHoa] CHECK CONSTRAINT [fk_HangHoa_NhomHang];
ALTER TABLE [HoaDonBanHang] CHECK CONSTRAINT [fk_HoaDonBanHang_KhachHang];
ALTER TABLE [HoaDonBanHang] CHECK CONSTRAINT [fk_HoaDonBanHang_NhanVien];
ALTER TABLE [NhanVien] CHECK CONSTRAINT [fk_NhanVien_ChucVu];
ALTER TABLE [NhanVien] CHECK CONSTRAINT [fk_NhanVien_QuanLy];
ALTER TABLE [NhomHang] CHECK CONSTRAINT [fk_NhomHang_NganhHang];
ALTER TABLE [PhieuNhap] CHECK CONSTRAINT [fk_PhieuNhap_NhaCungCap];
ALTER TABLE [PhieuNhap] CHECK CONSTRAINT [fk_PhieuNhap_NhanVien];
ALTER TABLE [QuyenDangNhap] CHECK CONSTRAINT [fk_QuyenDangNhap_ChucVu];
ALTER TABLE [QuyenDangNhap] CHECK CONSTRAINT [fk_QuyenDangNhap_NhanVien];