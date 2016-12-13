use master
go

create database otobus
go

use otobus
go


--Þube BÝlgileri
create table sube
(
subeID int primary key identity(0,1)
,ad nvarchar(50) not null
,adresID int not null
,acilisTarihi datetime not null default GETDATE()
,durum bit default 1 not null
)
go

--Çaliþan Bilgileri


create table calisanPozisyon
(
calisanPozisyonID int primary key identity(0,1)
,ad nvarchar(50) not null
)
go

create table calisan
(
calisanID int primary key identity(0,1)
,calisanPozisyonID int not null
,subeID int not null
,ad nvarchar(50) not null
,soyad nvarchar(50) not null
,cinsiyet nvarchar(50) default 'bay'
,dogumTarihi datetime not null
,dogumYeri datetime not null
,ehliyetSinifi nvarchar(5)
,ehliyetAlisTarihi datetime default 0
,telefon nvarchar(20) not null
,mail nvarchar(50) not null
,adresID int not null
,girisTarihi datetime  default GETDATE()not null
,cikisTarihi datetime 
,maas money default 1200 not null
,durum bit default 1 not null
)
go

create table calisanKullanici
(
,calisanID int primary key
,kadi nvarchar(50) not null
,sifre nvarchar(50) not null
,kayitTarihi datetime  default GETDATE() not null
,durum bit default 1 not null
)
--Otobus bilgileri
create table otobusMarka
(
otobusMarkaID int primary key identity(0,1)
,ad nvarchar(50) not null
,aciklama nvarchar(MAX)
,durum bit default 1 not null
)
go
create table otobusTuru
(
otobusTuruID int primary key identity(0,1)
,ad nvarchar(50) not null
,resimUrl nvarchar(Max)
,aciklama nvarchar(MAX)
,durum bit default 1 not null
)
go
--insert into otobusTuru(ad) values ('Rahat Hat')
--insert into otobusTuru(ad) values ('Normal Hat')
create table otobusModel
(
otobusModelID int primary key identity(0,1)
,otobusMarkaID int not null
,otobusTuruID int not null
,ad nvarchar(50) not null
,koltukSayisi int default 60 not null
,durum bit default 1 not null
)
go
create table otobus
(
otobusID int primary key identity(0,1)
,saseNumarasi  int not null
,plaka  nvarchar(10) not null
,otobusModelID int not null
,uretimYili datetime not null
,durum bit default 1 not null
)
go


--guzergah Bilgileri
create table molaTesis
(
molaTesisID int primary key identity(0,1)
,ad nvarchar(50) not null
,adresID int not null
,aciklama nvarchar(MAX)
,EklenmeTarihi datetime not null default GETDATE()
,durum bit default 1
)
go

create table guzergahMola
(
guzergahMolaID int primary key identity(0,1)
,molaTesisID int not null
,guzergahID int not null

)
go
create table guzergah
(
guzergahID int primary key identity(0,1)
,ad nvarchar(50) not null
,aciklama nvarchar(MAX)
,EklenmeTarihi datetime  default GETDATE()
,durum bit default 1
)
go
create table guzergahDurak
(
guzergahDurakID int primary key identity(0,1)
,guzergahID int not null
,SubeID int not null
,sira int not null
,kilometre int not null
)
go


--sefer Bilgileri
create table seferCalisan
(
seferCalisanID int primary key identity(0,1)
,calisanID int not null
)
go
create table sefer
(
seferID int primary key identity(0,1)
,otobusID int
,kalkisTarihi datetime not null
,varisTarihi datetime not null
,guzergahID int not null
,durum bit default 1
)
go