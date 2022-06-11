use QUANLIGARA
go
insert into HIEUXE(HieuXe) values
('Innova'),
('Honda'),
('Hyundai'),
('Lamborghini'),
('Toyota'),
('Ferrari'),
('Wolkswagen')

INSERT INTO PHUTUNG(MaVTPT, TenVTPT, SoLuongTon, DonGia) VALUES
('PT1',N'Búp sen thắng sau','79','700000'),
('PT2',N'Ắc quy','73','1970000'),
('PT3',N'Ba đờ sốc trước','96','1170000'),
('PT4',N'Lọc nhớt động cơ','66','120000'),
('PT5',N'Lọc nhớt nhiên liệu','84','170000'),
('PT6',N'Bộ giảm chấn','50','3750000')

insert into TIENCONG(MaTienCong, NoiDung, TienCong) values
('TC0',N'Công thay dầu máy xe ô tô','50000'),
('TC1',N'Công thay lọc dầu xe ô tô','50000'),
('TC2',N'Công thay dầu máy, lọc dầu xe ô tô','80000'),
('TC3',N'Thay lọc xăng xe ô tô','100000'),
('TC4',N'Thay lọc xăng thả thùng','200000'),
('TC5',N'Thay lọc nhiên liệu xe ô tô','50000')


insert into XE(Bienso, Hieuxe, TenChuXe, DiaChi, DienThoai, NgayTiepNhan, TienNo) values
('72F-48539','Innova',N'Lày A Cẩu',N'Quận Bình Thạnh, TP.HCM','982527982','2022-05-05 00:00:00','7800000'),
('88G-91668','Innova',N'Bùi Mạnh Quốc Huy',N'Quận Bình Thạnh, TP.HCM','973776072','2022-05-05 00:00:00','530000'),
('21A-22382','Innova',N'Lê Thị Mai',N'Quận Bình Thạnh, TP.HCM','917749254','2022-05-05 00:00:00','2000000'),
('77H-86543','Innova',N'Trần Kim Ngọc',N'Quận Gò Vấp, TP.HCM','904770053','2022-05-05 00:00:00','1950000')

insert into QUYDINH(SoXeSuaChuaToiDa, TiLeLai) VALUES (100, 1.05)
insert into NHANVIEN VALUES('Tuan', '123', N'Lâm Minh Tuấn', '098', '@gmail', 'TPHCM', N'Quản lý')

