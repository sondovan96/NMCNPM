
Create database QLCHUYENBAY
go
use QLCHUYENBAY
go
SET DATEFORMAT DMY
go
Create table QuiDinh
(
	TGBayToiThieu INT NULL,
	TGDungToiThieu INT NULL,
	TGDungToiDa INT NULL,
	SLSanBay INT NULL,
	TGDatVeToiDa INT NULL,
	TGHuyVeToiDa INT NULL,
	SLSanBayTG INT NULL
) 
go
Create table SanBay
(
	MaSB INT IDENTITY(1,1) NOT NULL,
	TenSB NVARCHAR(50) NULL,
Primary Key (MaSB)
) 
go
Create table TuyenBay
(
	MaTuyenBay INT IDENTITY(1,1) NOT NULL,
	MaSanBayDi INT NOT NULL,
	MaSanBayDen INT NOT NULL,
	ThoiGianBay INT NULL,
	CONSTRAINT PK_TuyenBay Primary Key (MaTuyenBay),
	CONSTRAINT FK_MaSanBayDi_TuyenBay FOREIGN KEY (MaSanBayDi) REFERENCES SanBay(MaSB),
	CONSTRAINT FK_MaSanBayDen_TuyenBay FOREIGN KEY (MaSanBayDen) REFERENCES SanBay(MaSB)
) 
go
Create table CTChuyenBay
(
	MaTuyenBay INT NOT NULL,
	MaSanBayTrungGian INT NOT NULL,
	GhiChu NVARCHAR(100) NULL,
	ThoiGianDung INT NULL,
	CONSTRAINT PK_CTChuyenBay Primary Key (MaTuyenBay,MaSanBayTrungGian),
	CONSTRAINT FK_MaTuyenBay_CTChuyenBay FOREIGN KEY (MaTuyenBay) REFERENCES TuyenBay(MaTuyenBay),
	CONSTRAINT FK_MaSanBayTrungGian_CTChuyenBay FOREIGN KEY (MaSanBayTrungGian) REFERENCES SanBay(MaSB) 
)
GO
Create table ChuyenBay
(
	MaChuyenBay VARCHAR(10) NOT NULL,
	MaTuyenBay INT NOT NULL,
	SLGheHang1 INT NULL,
	SLGheHang2 INT NULL,
	NgayGio DATETIME NULL,
	CONSTRAINT PK_ChuyenBay Primary Key (MaChuyenBay),
	CONSTRAINT FK_MaTuyenBay_ChuyenBay FOREIGN KEY (MaTuyenBay) REFERENCES TuyenBay(MaTuyenBay)
) 
go
Create table HanhKhach
(
	MaHK int identity(1,1) NOT NULL,
	TenHK NVARCHAR(50) NULL,
	CMND Char(15) NULL,
	DienThoai Char(15) NULL,
	CONSTRAINT PK_HanhKhach Primary Key (MaHK)
) 
go
Create table HangVe
(
	MaHangVe int identity(1,1) NOT NULL,
	TenHangVe NVARCHAR(50) NULL,
	CONSTRAINT PK_HangVe Primary Key (MaHangVe)
) 
go
Create table DonGia
(
	MaDonGia INT IDENTITY(1,1) NOT NULL,
	DonGia FLOAT NULL,
	MaChuyenBay VARCHAR(10) NOT NULL,
	MaHangVe INT NOT NULL,
	CONSTRAINT PK_DonGia Primary Key (MaDonGia),
	CONSTRAINT FK_MaChuyenBay_DonGia FOREIGN KEY (MaChuyenBay) REFERENCES ChuyenBay(MaChuyenBay),
	CONSTRAINT FK_MaHangVe_DonGia FOREIGN KEY (MaHangVe) REFERENCES HangVe(MaHangVe)
) 
go
Create table Ghe
(
	MaGhe INT IDENTITY(1,1) NOT NULL,
	MaHangVe INT NOT NULL,
	TinhTrang NVARCHAR(10) NULL,
	MaChuyenBay VARCHAR(10) NOT NULL,
	CONSTRAINT PK_Ghe Primary Key (MaGhe),
	CONSTRAINT FK_MaHangVe_Ghe FOREIGN KEY (MaHangVe) REFERENCES HangVe(MaHangVe),
	CONSTRAINT FK_MaChuyenBay_Ghe FOREIGN KEY (MaChuyenBay) REFERENCES ChuyenBay(MaChuyenBay),
) 
go
Create table PhieuDatCho
(
	MaPhieuDat int identity(1,1) NOT NULL,
	NgayDat datetime NULL,
	MaHK int NOT NULL,
	MaChuyenBay varchar(10) NOT NULL,
	MaGhe int NOT NULL,
	MaHangVe int NOT NULL,
	CONSTRAINT PK_PhieuDatCho Primary Key (MaPhieuDat),
	CONSTRAINT FK_MaHK_PhieuDatCho FOREIGN KEY (MaHK) REFERENCES HanhKhach(MaHK),
	CONSTRAINT FK_MaGhe_PhieuDatCho FOREIGN KEY (MaGhe) REFERENCES Ghe(MaGhe),
) 
go
Create table VeChuyenBay
(
	MaVe int identity(1,1) NOT NULL,
	NgayXV datetime NULL,
	MaPhieuDat int NOT NULL,
	CONSTRAINT PK_VeChuyenBay Primary Key (MaVe),
	CONSTRAINT FK_MaPhieuDat FOREIGN KEY (MaPhieuDat) REFERENCES PhieuDatCho(MaPhieuDat)
) 
go

drop table VeChuyenBay
go
drop table PhieuDatCho
go
drop table Ghe
go
drop table DonGia
go
drop table HangVe
go
drop table HanhKhach
go
drop table ChuyenBay
go
drop table CTChuyenBay
go
drop table TuyenBay
go
drop table SanBay
go
drop table QuiDinh
go
----------------insert sanbay--------------------------
INSERT INTO dbo.SanBay
VALUES (N'Hà Nội')
INSERT INTO SanBay
VALUES (N'Thành Phố Hồ Chí Minh')
INSERT INTO SanBay
VALUES (N'Đà Nẵng')
INSERT INTO SanBay
VALUES (N'Phú Quốc')
go
--------------------insert TuyenBay--------------------------
INSERT INTO TuyenBay
VALUES (1,2,90)
INSERT INTO TuyenBay
VALUES (2,1,90)
INSERT INTO TuyenBay
VALUES (1,3,60)
INSERT INTO TuyenBay
VALUES (1,4,120)
--------------------insert Chi tiet tuyen bay--------------------------
go
INSERT INTO CTChuyenBay
VALUES (1,2,NULL,15)
INSERT INTO CTChuyenBay
VALUES (4,3,NULL,15)
INSERT INTO CTChuyenBay
VALUES (4,2,NULL,20)
--------------------insert chuyenbay--------------------------
go
INSERT INTO ChuyenBay
VALUES ('VNA1','1',50,50,'20/07/2020 15:00')
INSERT INTO ChuyenBay
VALUES ('VJA1','1',60,50,'21/07/2020 20:00')
INSERT INTO ChuyenBay
VALUES ('VNA2','3',100,50,'22/07/2020 12:00')
go
-------------------insert HanhKhach--------------------------
INSERT INTO HanhKhach
VALUES (N'Đỗ Văn Sơn',142881576,'0707705997')
INSERT INTO HanhKhach
VALUES (N'Đào Ngọc Tân',435189735,'0395268285')

-------------------insert HangVe--------------------------
GO
INSERT INTO HangVe
VALUES (N'VIP')
INSERT INTO HangVe
VALUES (N'Thường')
GO
-------------------insert Ghe--------------------------
INSERT INTO Ghe
VALUES (1,N'Trống','VNA1')
INSERT INTO Ghe
VALUES (1,N'Đặt','VNA1')
INSERT INTO Ghe
VALUES (1,N'Trống','VNA1')
INSERT INTO Ghe
VALUES (1,N'Trống','VNA1')
INSERT INTO Ghe
VALUES (1,N'Đặt','VNA1')
INSERT INTO Ghe
VALUES (1,N'Trống','VNA1')
INSERT INTO Ghe
VALUES (1,N'Trống','VNA2')
GO

--------------------insert DonGia----------------------------
INSERT INTO DonGia
VALUES (500000,'VNA1',1)
INSERT INTO DonGia
VALUES (300000,'VNA1',2)
INSERT INTO DonGia
VALUES (700000,'VNA2',1)
INSERT INTO DonGia
VALUES (500000,'VNA2',2)
INSERT INTO DonGia
VALUES (500000,'VJA1',1)
INSERT INTO DonGia
VALUES (200000,'VJA1',2)
----------------------INSERT PHIEU DAT CHO------------------
go
INSERT INTO PhieuDatCho
VALUES ('15/7/2020',1,1,1,1)
INSERT INTO PhieuDatCho
VALUES ('15/7/2020',2,1,3,1)
go
select MaChuyenBay,MaSanBayDi,MaSanBayDen,MaSanBayTrungGian,NgayGio,ThoiGianDung,GhiChu ,tb.MaTuyenBay
from ChuyenBay cb,SanBay sb,CTChuyenBay ct,TuyenBay tb
where cb.MaTuyenBay = tb.MaTuyenBay
and tb.MaTuyenBay = ct.MaTuyenBay
and sb.MaSB = ct.MaSanBayTrungGian

