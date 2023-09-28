IF EXISTS(select name from SYS.databases where name = 'DMSV')
drop database DMSV
go
CREATE DATABASE DMSV
USE DMSV
(
--DATA
	NAME = DMSC_DAT,
	filename = 'C:\Users\Pham Thanh Long\Desktop\hoc c#\SQL.mdf',
	size = 5,
	maxsize = 500,
	filegrowth = 5
)SVS
log on
(
--log
	name = QLBH_LOG,
	filename = 'D:\QLBH_SQL.ldf',
	size = 5,
	maxsize = 500,
	filegrowth = 5
);
go

go
Create table DMQUYEN
(
	MAQUYEN int identity(1,1)  primary key,
	LOAIQUYEN nvarchar(100) not null,
)
Create table DMUSER
(
	MAUSER int identity(1,1)  primary key,
	TENDANGNHAP VARCHAR(50) not null,
	MATKHAU VARCHAR(50) NOT NULL,
	MAQUYEN INT REFERENCES DMQUYEN(MAQUYEN)
)

CREATE TABLE Sinh_Vien
(
MA_SV		 VARCHAR(3)		 not null primary key,
TEN_SV		 NVARCHAR(15)	 not null,
Ngay_sinh	 DATE			 not null,
Que_quan	 NVARCHAR(30)	 not null,
Noi_o		 NVARCHAR(50)	 null,
Lop			 NVARCHAR (20)   null,
Khoa		 NVARCHAR(30)	 null,
MAUSER		INT				null REFERENCES DMUSER(MAUSER)
	
)
go
Insert  DMQUYEN(LOAIQUYEN)
values(N'Admin')
Insert  DMQUYEN(LOAIQUYEN)
values(N'Khoa Marketing ')
Insert  DMQUYEN(LOAIQUYEN)
values(N'khoa công nghệ thông tin')
Insert  DMQUYEN(LOAIQUYEN)
values(N'khoa công nghệ ô tô')


/* Thêm vào dmuser*/
Insert  DMUSER(TENDANGNHAP,MATKHAU,MAQUYEN)
values('admin','admin',1)
Insert  DMUSER(TENDANGNHAP,MATKHAU,MAQUYEN)
values('cntt','cntt',2)
Insert  DMUSER(TENDANGNHAP,MATKHAU,MAQUYEN)
values('mkt','mkt',3)
Insert  DMUSER(TENDANGNHAP,MATKHAU,MAQUYEN)
values('cnot','cnot',4)

SELECT * FROM DMUSER
SELECT * FROM Sinh_Vien
INSERT Sinh_Vien (MA_SV, TEN_SV, Ngay_sinh, Que_quan, Noi_o, Lop, Khoa) VALUES ('SV1',N'Tú', CAST(N'1979-08-08' AS Date),N'Nam Định',N'Nguyễn Khành Toàn','CNNT_SD18204',N'Công nghệ thông tin ')
INSERT Sinh_Vien (MA_SV, TEN_SV, Ngay_sinh, Que_quan, Noi_o, Lop, Khoa) VALUES ('SV2',N'Cường', CAST(N'1993-01-08' AS Date),N'Quang Ninh',N'Dương Quảng Hàm','MKT_SD14304',N'Marketing ')
INSERT Sinh_Vien (MA_SV, TEN_SV, Ngay_sinh, Que_quan, Noi_o, Lop, Khoa) VALUES ('SV3',N'Tuấn', CAST(N'1989-01-09' AS Date),N'Yên Bái',N'Nguyễn Trãi','MKT_SD14324',N'Marketing')
INSERT Sinh_Vien (MA_SV, TEN_SV, Ngay_sinh, Que_quan, Noi_o, Lop, Khoa) VALUES ('SV4',N'Thiết', CAST(N'1999-02-12' AS Date),N'Sóc Sơn',N'Đông Quan','CNOT_SD13204',N'Công nghệ ô tô ')
INSERT Sinh_Vien (MA_SV, TEN_SV, Ngay_sinh, Que_quan, Noi_o, Lop, Khoa) VALUES ('SV5',N'Tuyên', CAST(N'2000-06-20' AS Date),N'Phú Thọ',N'Quan Hoa','CNNT_SD18264',N'Công nghệ thông tin ')


drop table Sinh_Vien

