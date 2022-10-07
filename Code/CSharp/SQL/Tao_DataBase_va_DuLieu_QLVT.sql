------------Tao CSDL-------------------------------------------------
--Chu y thay doi thu muc luu tru file .mdf va .ldf

CREATE DATABASE QLBanHang
	ON PRIMARY
	(	Name=QLBanHang_data,
		FileName='D:\QLBanHang.mdf',
		Size=5MB,
		MaxSize=50MB,
		FileGrowth=10%
	)
	LOG ON
	(	Name=QLBanHang_log,
		FileName='D:\QLBanHang.ldf',
		Size=1MB,
		MaxSize=5MB,
		FileGrowth=10%
	)
GO
USE QLBanHang
------------------------------------------------------------------------------------------------
/*================================Tao cac bang trong CSDL=====================================*/
CREATE TABLE VATTU
(
	Mavtu char(4) not null,
	TenVTu varchar(100),
	Dvtinh varchar(10),
	Phantram real,
	Primary Key (Mavtu)
)
Go
------------------------------

CREATE TABLE NHACC
(
	MaNCC char(3) not null,
	TenNCC varchar(100),
	Diachi varchar(200),
	Dienthoai varchar(20),
	Primary Key (MaNCC)
)
GO
------------------------------
CREATE TABLE DONDH
(
	SoDH char(4) not null,
	NgayDH datetime,
	MaNCC char(3) not null,	
	Primary Key (SoDH)
	--Foreign Key (MaNCC) References NhaCC(ManCC) 
)
GO
------------------------------
CREATE TABLE CTDONDH
(
	SoDH char(4) not null,
	Mavtu char(4) not null,
	SlDat int,	
	Primary key (SoDH,Mavtu)
	--Foreign Key (SoDH) References DonDH(SoDH),
	--Foreign Key (MaVTu) References Vattu(MaVTu)
)
GO
------------------------------
CREATE TABLE PNHAP
(
	SoPn char(4) not null,
	NgayNhap Datetime not null,
	SoDH char(4) not null,	
	Primary key (SoPn)
	--Foreign Key (SoDH) References DonDH(SoDH)	
)
GO
------------------------------
CREATE TABLE CTPNHAP
(
	SoPn char(4) not null,
	Mavtu char(4) not null,
	SLNhap Int,	
	DGNhap Money,
	primary key (SoPn,Mavtu)
	--Foreign Key (SoPn) References PNhap(SoPn),
	--Foreign Key (MaVTu) References VaTTu(MaVTu)	
)
GO
------------------------------
CREATE TABLE PXUAT
(
	SoPx char(4) not null,
	NgayXuat Datetime not null,
	TenKH Varchar(100) not null,	
	Primary key (SoPx)	
)
GO
------------------------------
CREATE TABLE CTPXUAT
(
	SoPx char(4) not null,
	Mavtu char(4) not null,
	SLXuat Int,	
	DGXuat Money,
	Primary key (SoPx,Mavtu)	
)
GO
------------------------------
CREATE TABLE TONKHO
(
	NamThang char(6) not null,
	Mavtu char(4) not null,
	SLDau Int,	
	TongSLN int,
	TongSLX int,
	SLCuoi as (SLDau+TongSLN-TongSLX),
	Primary key (NamThang,Mavtu)		
)
GO
-----------------------------------------------------------------------------
/*===================Tao cac CONSTRAINT - rang buoc toan ven=================*/

ALTER TABLE VATTU
	ADD
	CONSTRAINT UNQ_VATTU_Tenvt UNIQUE(Tenvtu),
	CONSTRAINT DEF_VATTU_Dvtinh DEFAULT '' For dvtinh,
	CONSTRAINT CHK_VATTU_Phantram CHECK(phantram between 0 And 100)
Go
------------------------------------------------------------------
ALTER TABLE NhaCC
	ADD
	CONSTRAINT UNQ_NHACC_TenNcc UNIQUE(Tenncc,diachi),	
	CONSTRAINT DEF_VATTU_Dienthoai DEFAULT 'Chua co' For dienthoai
------------------------------------------------------------------
Go
ALTER TABLE DONDH
	ADD	
	CONSTRAINT Frk_DONDH_Mancc FOREIGN KEY(Mancc) REFERENCES Nhacc(mancc),
	CONSTRAINT DEF_DONDH_Ngaydh DEFAULT Getdate() For Ngaydh

Go
------------------------------------------------------------------
ALTER TABLE CTDONDH
	ADD	
	CONSTRAINT Frk_CTDONDH_sodh FOREIGN KEY(Sodh) REFERENCES Dondh(sodh),
	CONSTRAINT Frk_CTDONDH_Mavtu FOREIGN KEY(Mavtu) REFERENCES Vattu(Mavtu),	
	CONSTRAINT CHK_CTDONDH_sldat CHECK(Sldat>0)
Go
------------------------------------------------------------------
ALTER TABLE CTPNhap
	ADD	
	CONSTRAINT Frk_CTPNHAP_sopn FOREIGN KEY(sopn) REFERENCES Pnhap(sopn)  ON DELETE NO ACTION ON UPDATE CASCADE,
	CONSTRAINT Frk_CTPNHAP_Mavtu FOREIGN KEY(Mavtu) REFERENCES Vattu(Mavtu) ON DELETE NO ACTION ON UPDATE CASCADE,
	CONSTRAINT CHK_CTPNHAP_SlNhap CHECK(SlNhap>0),
	CONSTRAINT CHK_CTPNHAP_DgNhap CHECK(DgNhap>0)
Go
------------------------------------------------------------------
ALTER TABLE CTPXuat
	ADD	
	CONSTRAINT Frk_CTPPXUAT_sopx FOREIGN KEY(sopx) REFERENCES Pxuat(sopx),
	CONSTRAINT Frk_CTPPXUAT_Mavtu FOREIGN KEY(Mavtu) REFERENCES Vattu(Mavtu),			
	CONSTRAINT CHK_SlXuat_CTPXuat CHECK(SlXuat>0),
	CONSTRAINT CHK_DgXuat_CTPXuat CHECK(DgXuat>0)
Go
------------------------------------------------------------------
ALTER TABLE TONKHO
	ADD	
	CONSTRAINT Frk_TONKHO_Mavtu FOREIGN KEY(Mavtu) REFERENCES Vattu(Mavtu),				
	CONSTRAINT CHK_SlDau_CTPXuat CHECK(SlDau>=0),
	CONSTRAINT CHK_TongSLN_TONKHO CHECK(TongSLN>=0),
	CONSTRAINT CHK_TongSLX_TONKHO CHECK(TongSLX>=0),
	CONSTRAINT DEF_SlDau_CTPXuat DEFAULT 0 For SlDau,
	CONSTRAINT DEF_TongSLN_TONKHO DEFAULT 0 For TongSLN,
	CONSTRAINT DEF_TongSLX_TONKHO DEFAULT 0 For TongSLX
Go
-------------------------------------------------------------------------------------------------------------
/*================Tao cac CONSTRAINT khoa ngoai===============*/

-- Font ch÷:  .VnCentury Schoolbook
/*Du Lieu Bang Nha Cung Cap*/
INSERT INTO NHACC VALUES ('C01','Lª Minh TrÝ','54 HËu Giang Q6 HCM','8781024')
INSERT INTO NHACC VALUES ('C02','TrÇn Minh Th¹nh','145 Hung V­¬ng Mü Tho','7698154')
INSERT INTO NHACC VALUES ('C03','Hång Ph­¬ng','154/85 Lª Lai Q1 HCM','8757757')
INSERT INTO NHACC VALUES ('C04','NhËt Th¾ng','198/40 H­¬ng Lé 14 QTB HCM','9600125')
INSERT INTO NHACC VALUES ('C05','L­u NguyÖt QuÕ','178 NguyÔn V¨n Lu«ng §µ L¹t','7964251')
INSERT INTO NHACC VALUES ('C06','Cao Minh Trung','125 Lª Quang Sung Nha Trang','')
Go
------------------------------------------------------------------------
/*Du Lieu Bang VATTU*/
INSERT INTO VATTU VALUES ('DD01','§Çu DVD Hitachi 1 ®Üa','Bé',40)
INSERT INTO VATTU VALUES ('DD02','§Çu DVD Hitachi 3 ®Üa','Bé',40)
INSERT INTO VATTU VALUES ('TL15','Tñ L¹nh Sanyo 150 lÝt','C¸i',25)
INSERT INTO VATTU VALUES ('TL90','Tñ L¹nh Sanyo 90 lÝt','C¸i',20)
INSERT INTO VATTU VALUES ('TV14','Tivi SONY 14 inches','C¸i',15)
INSERT INTO VATTU VALUES ('TV21','Tivi SONY 21 inches','C¸i',10)
INSERT INTO VATTU VALUES ('TV29','Tivi SONY 29 inches','C¸i',10)
INSERT INTO VATTU VALUES ('VD01','§Çu VCD SONY 1 ®Üa','Bé',30)
INSERT INTO VATTU VALUES ('VD02','§Çu VCD SONY 3 ®Üa','Bé',30)
Go
------------------------------------------------------------------------
/*Du Lieu Bang DONDH*/
INSERT INTO DONDH VALUES('D001','01/15/2005','C03')
INSERT INTO DONDH VALUES('D002','01/30/2005','C01')
INSERT INTO DONDH VALUES('D003','02/10/2005','C02')
INSERT INTO DONDH VALUES('D004','02/17/2005','C05')
INSERT INTO DONDH VALUES('D005','03/01/2005','C02')
INSERT INTO DONDH VALUES('D006','03/12/2005','C05')
Go
------------------------------------------------------------------------
/*Du Lieu Bang PNHAP*/
INSERT INTO PNHAP VALUES('N001','01/17/2005','D001')
INSERT INTO PNHAP VALUES('N002','01/20/2005','D001')
INSERT INTO PNHAP VALUES('N003','01/31/2005','D002')
INSERT INTO PNHAP VALUES('N004','02/15/2005','D003')
Go
------------------------------------------------------------------------
/*Du Lieu Bang CTDONDH*/
INSERT INTO CTDONDH VALUES('D001','DD01',10)
INSERT INTO CTDONDH VALUES('D001','DD02',15)
INSERT INTO CTDONDH VALUES('D002','VD02',30)
INSERT INTO CTDONDH VALUES('D003','TV14',10)
INSERT INTO CTDONDH VALUES('D003','TV29',20)
INSERT INTO CTDONDH VALUES('D004','TL90',10)
INSERT INTO CTDONDH VALUES('D005','TV14',10)
INSERT INTO CTDONDH VALUES('D005','TV29',20)
INSERT INTO CTDONDH VALUES('D006','TV14',10)
INSERT INTO CTDONDH VALUES('D006','TV29',20)
INSERT INTO CTDONDH VALUES('D006','VD01',20)
Go
------------------------------------------------------------------------
/*Du Lieu Bang CTPNHAP*/
INSERT INTO CTPNHAP VALUES('N001','DD01',8 ,25)
INSERT INTO CTPNHAP VALUES('N001','DD02',10 ,35)
INSERT INTO CTPNHAP VALUES('N002','DD01', 2,25)
INSERT INTO CTPNHAP VALUES('N002','DD02', 5,35)
INSERT INTO CTPNHAP VALUES('N003','VD02', 30,25)
INSERT INTO CTPNHAP VALUES('N004','TV14', 5,25)
INSERT INTO CTPNHAP VALUES('N004','TV21', 12,35)

UPDATE  CTPNHAP SET dgnhap=dgNhap*100000
Go
------------------------------------------------------------------------
/*Du Lieu Bang PXUAT*/
INSERT INTO PXUAT VALUES('X001','01/17/2005','NguyÔn Ngäc Ph­¬ng Nhi')
INSERT INTO PXUAT VALUES('X002','01/25/2005','NguyÔn Hång Ph­¬ng')
INSERT INTO PXUAT VALUES('X003','01/31/2005','NguyÔn TuÊn Tó')
Go
------------------------------------------------------------------------
/*Du Lieu Bang CTPXUAT*/
INSERT INTO CTPXUAT VALUES('X001','DD01',2 ,35)
INSERT INTO CTPXUAT VALUES('X002','DD01',1 ,35)
INSERT INTO CTPXUAT VALUES('X002','DD02', 5,49)
INSERT INTO CTPXUAT VALUES('X003','DD01', 3,35)
INSERT INTO CTPXUAT VALUES('X003','DD02', 2,49)
INSERT INTO CTPXUAT VALUES('X003','VD02', 10,32.5)

UPDATE  CTPXUAT SET dgxuat=dgxuat*100000
Go
------------------------------------------------------------------------
/*Du Lieu Bang TONKHO*/

INSERT INTO TONKHO(Namthang,Mavtu,SLDau,TongSLN,TongSLX) VALUES('200501','DD01',0,10,6 )
INSERT INTO TONKHO(Namthang,Mavtu,SLDau,TongSLN,TongSLX) VALUES('200501','DD02',0,15,7 )
INSERT INTO TONKHO(Namthang,Mavtu,SLDau,TongSLN,TongSLX) VALUES('200501','VD02',0,30,10 )
INSERT INTO TONKHO(Namthang,Mavtu,SLDau,TongSLN,TongSLX) VALUES('200502','DD01',4,0,0 )
INSERT INTO TONKHO(Namthang,Mavtu,SLDau,TongSLN,TongSLX) VALUES('200502','DD02',8,0,0 )
INSERT INTO TONKHO(Namthang,Mavtu,SLDau,TongSLN,TongSLX) VALUES('200502','VD02',20,0,0 )
INSERT INTO TONKHO(Namthang,Mavtu,SLDau,TongSLN,TongSLX) VALUES('200502','TV14',5,0,0 )
INSERT INTO TONKHO(Namthang,Mavtu,SLDau,TongSLN,TongSLX) VALUES('200502','TV29',12,0,0 )


