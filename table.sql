CREATE DATABASE QUANLIGARA
GO

USE QUANLIGARA
GO
--------------------------------------
--------------------------------------
-- TAO BANG, KHOA CHINH, KHOA NGOAI --
--------------------------------------

-- 1. XE
create table XE(
	BienSo varchar(10),
	TenChuXe nvarchar(50),
	HieuXe varchar(20),
	DiaChi nvarchar(50),
	DienThoai varchar(50),
	Email varchar(50),
	TienNo money,
	NgayTiepNhan smalldatetime,
	constraint PK_XE primary key(BienSo)
)

-- 2. HIEU XE
create table HIEUXE(
	HieuXe varchar(20)
	constraint PK_HIEUXE primary key(HieuXe)
)

-- 3. PHIEU SUA CHUA
create table PHIEUSUACHUA(
	IntMaPSC int identity(1,1),
	MaPSC as RIGHT(CAST(IntMaPSC AS varchar(10)), 10) persisted,
	BienSo varchar(10),
	NgaySuaChua smalldatetime,
	TongTien money
	constraint PK_PHIEUSUACHUA primary key(MaPSC)
)

-- 4. CHI TIET PHIEU SUA CHUA
create table CT_PSC(
	
	MaPSC varchar(10),
	NoiDung nvarchar(200),
	MaVTPT varchar(10),
	SoLuong int,
	DonGia money,
	MaTienCong varchar(10),
	TienCong money,
	ThanhTien money,

)

-- 5. PHU TUNG
create table PHUTUNG(
	IntMaVTPT int identity(1,1),
	MaVTPT as RIGHT(CAST(IntMaVTPT AS varchar(10)), 10) persisted,
	TenVTPT nvarchar(50),
	SoLuongTon int,
	DonGia money,
	constraint PK_PHUTUNG primary key(MaVTPT)
)

-- 6. TIEN CONG
create table TIENCONG(
	MaTienCong varchar(10),
	NoiDung nvarchar(200),
	TienCong money
	constraint PK_TIENCONG primary key(MaTienCong)
)

-- 7. QUY DINH 
create table QUYDINH(
	SoXeSuaChuaToiDa int,
	TiLeLai float
	constraint PK_QUYDINH primary key(SoXeSuaChuaToiDa)
)

-- 8. PHIEU THU TIEN
create table PHIEUTHUTIEN(
	MaPTT varchar(10),
	BienSo varchar(10),
	NgayThuTien smalldatetime,
	SoTienThu money
	constraint PK_PHIEUTHUTIEN primary key(MaPTT)
)

-- 9.BAO CAO DOANH THU
create table BAOCAODOANHTHU(
	IntMaBCDT int identity(1,1),
	MaBCDT as RIGHT(CAST(IntMaBCDT AS varchar(10)), 10) persisted,
	Thang int,
	Nam int,
	TongDoanhThu money
	constraint PK_BAOCAODOANHTHU primary key(MaBCDT)
)

-- 10. CHI TIET BAO CAO DOANH THU
create table CT_BAOCAODOANHTHU(
	
	MaBCDT varchar(10),
	HieuXe varchar(20),
	ThanhTien money,
	TiLe float
	
)

-- 11. BAO CAO TON VAT TU PHU TUNG 
create table BAOCAOTONVTPT(
	IntMaBCTVTPT int identity(1,1),
	MaBCTVTPT as RIGHT(CAST(IntMaBCTVTPT AS varchar(10)), 10) persisted,
	Thang int,
	Nam int,
	constraint PK_BAOCAOTONVTPT primary key(MaBCTVTPT)
)

-- 12. CHI TIET BAO CAO TON VAT TU PHU TUNG 
create table CT_BAOCAOTONVTPT(
	
	MaBCTVTPT varchar(10),
	MaVTPT varchar(10),
	TonDau int,
	PhatSinh int,
	TonCuoi int,
	
)

-- 13. PHIEU NHAP KHO VAT TU PHU TUNG
create table PHIEUNHAPKHOVTPT(
	IntMaNKVTPT int identity(1,1),
	MaNKVTPT as RIGHT(CAST(IntMaNKVTPT AS varchar(10)), 10) persisted,
	NgayNhap smalldatetime
	constraint PK_PHIEUNHAPKHOVTPT primary key(MaNKVTPT)
)

-- 14. CHI TIET PHIEU NHAP KHO VAT TU PHU TUNG
create table CT_PNKVTPT(
	MaNKVTPT varchar(10),
	MaVTPT varchar(10),
	TenVTPT nvarchar(50),
	SoLuong int,
	GiaNhap money
	
)

-- TAO KHOA NGOAI
-- 1. BANG XE
alter table XE add constraint FK_XE foreign key(HieuXe) references HIEUXE(HieuXe)

-- 2. BANG PHIEU SUA CHUA
alter table PHIEUSUACHUA add constraint FK_PHIEUSUACHUA foreign key(BienSo) references XE(BienSo)

-- 3. BANG CHI TIET PHIEU SUA CHUA
alter table CT_PSC add constraint FK1_CT_PSC foreign key(MaPSC) references PHIEUSUACHUA(MaPSC)
alter table CT_PSC add constraint FK2_CT_PSC foreign key(MaVTPT) references PHUTUNG(MaVTPT)
alter table CT_PSC add constraint FK3_CT_PSC foreign key(MaTienCong) references TIENCONG(MaTienCong)

-- 4. BANG PHIEU THU TIEN
alter table PHIEUTHUTIEN add constraint FK_PHIEUTHUTIEN foreign key(BienSo) references XE(BienSo)

-- 5. BANG CT_BAOCAODOANHTHU
alter table CT_BAOCAODOANHTHU add constraint FK1_CT_BAOCAODOANHTHU foreign key(MaBCDT) references BAOCAODOANHTHU(MaBCDT)
alter table CT_BAOCAODOANHTHU add constraint FK2_CT_BAOCAODOANHTHU foreign key(HieuXe) references HIEUXE(HieuXe)

-- 6. BANG CT_BAOCAOTONVTPT
alter table CT_BAOCAOTONVTPT add constraint FK1_CT_BAOCAOTONVTPT foreign key(MaBCTVTPT) references BAOCAOTONVTPT(MaBCTVTPT)
alter table CT_BAOCAOTONVTPT add constraint FK2_CT_BAOCAOTONVTPT foreign key(MaVTPT) references PHUTUNG(MaVTPT)


-- 8. BANG CT_PNKVTPT
alter table CT_PNKVTPT add constraint FK_CT_PNKVTPT foreign key(MaVTPT) references PHUTUNG(MaVTPT)


------------------------------
-- THEM CAC RANG BUOC TOAN VEN
-- So xe sua chua toi da trong ngay la 30
alter table QUYDINH add constraint CHECK_SOXESUACHUATOIDA check (SoXeSuaChuaToiDa <=30)

-- ThanhTien = SoLuong*DonGia + TienCong
alter table CT_PSC add constraint CHECK_THANHTIEN check (ThanhTien = SoLuong*DonGia + TienCong)
USE QUANLIGARA
GO
CREATE TABLE NHANVIEN
(
	TenDangNhap nvarchar(20),
	MatKhau char(20),
	TenNV nvarchar(50),
	DienThoai varchar(50),
	Email varchar(50),
	DiaChi nvarchar(50),
	ChucVu nvarchar(50)
	constraint PK_NHANVIEN primary key(TenDangNhap)
)
GO




ALTER TABLE CT_PNKVTPT
DROP CONSTRAINT FK_CT_PNKVTPT
GO
ALTER TABLE CT_PNKVTPT
ADD CONSTRAINT FK1_CT_PNKVTPT foreign key (MaNKVTPT) references PHIEUNHAPKHOVTPT (MaNKVTPT)
GO
ALTER TABLE CT_PNKVTPT
add constraint FK2_CT_PNKVTPT foreign key(MaVTPT) references PHUTUNG(MaVTPT)
GO
CREATE FUNCTION [dbo].[fuConvertToUnsign1] ( @strInput NVARCHAR(4000) ) RETURNS NVARCHAR(4000) AS BEGIN IF @strInput IS NULL RETURN @strInput IF @strInput = '' RETURN @strInput DECLARE @RT NVARCHAR(4000) DECLARE @SIGN_CHARS NCHAR(136) DECLARE @UNSIGN_CHARS NCHAR (136) SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' +NCHAR(272)+ NCHAR(208) SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' DECLARE @COUNTER int DECLARE @COUNTER1 int SET @COUNTER = 1 WHILE (@COUNTER <=LEN(@strInput)) BEGIN SET @COUNTER1 = 1 WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) BEGIN IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) BEGIN IF @COUNTER=1 SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) ELSE SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) BREAK END SET @COUNTER1 = @COUNTER1 +1 END SET @COUNTER = @COUNTER +1 END SET @strInput = replace(@strInput,' ','-') RETURN @strInput END

GO

CREATE PROC DANGNHAP @username nvarchar(10), @password char(20)
AS
BEGIN
	SELECT TenDangNhap, MatKhau, ChucVu FROM NHANVIEN WHERE CAST(TenDangNhap AS varbinary(100)) = CAST(@username AS varbinary(100)) AND CAST(MatKhau AS varbinary(100)) = CAST(@password AS varbinary(100))
END
GO

-- Maso cua cac bang CT tu dong tang khi nhap vao

/*USE MASTER
GO
ALTER DATABASE QUANLIGARA
SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
DROP DATABASE QUANLIGARA
GO*/