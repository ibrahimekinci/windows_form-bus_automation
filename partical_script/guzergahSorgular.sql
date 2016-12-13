----Tüm sorgular
use otobus
go

----Güzergah

----guzergahları listele

-- select g.guzergahID 'Guzergah ID',g.ad 'Guzergah Ad',g.aciklama 'Açıklama',g.EklenmeTarihi 'Eklenme Tarihi',g.durum 'Durum',Count(gb.guzergahID) 'Durak Sayısı'  from guzergahDurak gb inner join guzergah g on g.guzergahID =gb.guzergahID group by g.guzergahID,g.ad,g.aciklama,g.EklenmeTarihi,g.durum having  order by 'Guzergah Ad'

 
-- --GuzegahDurak listele
-- select gd.guzergahDurakID 'Durak ID',se.ad 'Sehir',s.ad 'Durak Ad',gd.kilometre 'Durak Arası Mesafe(km)',gd.sira 'Sıra' from guzergah g inner join guzergahDurak gd on g.guzergahID = gd.guzergahID inner join sube s on s.subeID = gd.SubeID inner join adres a on a.adresID= s.adresID inner join sehir se on a.sehirID = se.sehirID where  gd.guzergahID='0' order by gd.sira 

-- --Guzergah
-- --Şube getir
-- select  s.subeID, s.ad, se.ad  from sube s inner join adres a on  a.adresID = s.adresID inner join sehir se on se.sehirID = a.sehirID where se.ad like '%' and s.subeID !=0;

-- --mola tesis getir
-- select mt.molaTesisID, mt.ad, se.ad  from molaTesis mt inner join adres a on  a.adresID = mt.adresID inner join sehir se on se.sehirID = a.sehirID where se.ad like '%' and
-- (se.ad ='ADANA' or se.ad)

-- --guzergah Ekle
-- select * from guzergah
-- insert into guzergah (ad,aciklama) values ('','')

-- --GuzegahDurakEkle
-- select * from guzergahDurak
-- insert into guzergahDurak (guzergahID,subeID,sira,kilometre) values (0,0,0,0)

-- --GuzergahMolaEkle
-- select * from guzergahMola
-- insert into guzergahMola(guzergahID,molaTesisID) values (0,0)
-- --guzergah sil
-- use otobus
--go

--create trigger tg_GuzergahSil on guzergah
--instead of delete 
--as
--update guzergah set durum = 0 from guzergah g inner join deleted d on g.guzergahID =d.guzergahID
--go

--delete from guzergah where guzergahID=2

----guzergahUpdate
--alter proc sp_guzergahUpdate(
--@guzergahID int
--,@guzergahAd nvarchar(40)
--,@guzergahAciklama nvarchar(40)
--)
--as
--delete from guzergahMola where guzergahId= @guzergahID
--delete from guzergahDurak where guzergahID=@guzergahID
--update guzergah set ad=@guzergahAd,aciklama=@guzergahAciklama where guzergahId= @guzergahID
--go


--exec sp_guzergahUpdate 0 ,'',''

----guzergahDurakGetir
--select s.subeID,s.ad,se.ad,gd.kilometre from guzergahDurak gd  inner join sube s on s.subeID =gd.subeID inner join adres a on a.adresID= s.adresID inner join sehir se on se.sehirID=a.sehirID
----GuzergahMolaTesisiGetir
--select gm.guzergahMolaID,mt.ad,se.ad from guzergahMola gm inner join molaTesis mt on mt.molaTesisID= gm.molaTesisID inner join adres a on a.adresID = mt.adresID inner join sehir se on se.sehirID = a.sehirID

----sefer Getir
--use otobus
--go

--declare @nereden int, @nereye int,@yon bit,@tarih datetime
--set @nereden=9
--set @nereye=4
--set @yon =0

--set @tarih='2015-01-16 00:00:00.000'

--select s.seferID,s.kalkisTarihi,g.ad,g.aciklama from sefer s inner join guzergah g on g.guzergahID = s.guzergahID 
--inner join guzergahDurak gd on g.guzergahID = gd.guzergahID where s.durum =1 and g.durum=1 and s.yon=@yon and (gd.subeID=@nereden or gd.subeID =@nereye) group by g.guzergahID,s.seferID,s.kalkisTarihi,g.ad,g.aciklama having COUNT(*) =2 and Convert(varchar,s.kalkisTarihi,104) =Convert(varchar,@tarih,104)



--sefer getir  alternatif

--alter proc sp_seferGetirByGuzergahAndTarih(
-- @neredenSubeID int
--,@nereyeSubeID int
--,@kalkisTarihi datetime
--)
--as
--SELECT  sefer.yon,sefer.guzergahID,sefer.seferID,guzergah.ad,sefer.kalkisTarihi FROM sefer 
--INNER JOIN guzergah on sefer.guzergahID = guzergah.guzergahID 
--INNER JOIN guzergahDurak ON guzergah.guzergahID = guzergahDurak.guzergahID 
--WHERE guzergahDurak.guzergahID  
--IN(
--select guzergahID  from guzergahDurak 
--WHERE SubeID IN(@neredenSubeID,@nereyeSubeID)
--group by guzergahID 
--having  count(guzergahID)=2
--)
--AND Convert(varchar(20), kalkisTarihi, 102)=Convert(varchar(20), @kalkisTarihi, 102) and sefer.durum=1 
--group by guzergah.ad,sefer.seferID,sefer.kalkisTarihi,sefer.guzergahID,sefer.yon
--go

--exec sp_seferGetirByGuzergahAndTarih 9,8,'2015-01-25 00:00:00.000'
----seferFiltrele

--alter proc sp_seferFiltreleByYon
(
--@guzergahID int
--,@neredenSubeID int 
--,@nereyeSubeID int
--)
--as
--declare @yon bit

--declare @neredenSira int,@nereyeSira int
--select @neredenSira=sira from guzergahDurak where guzergahID=@guzergahID  and subeID=@neredenSubeID
--select @nereyeSira=sira from guzergahDurak where guzergahID=@guzergahID  and subeID=@nereyeSubeID
--if (@neredenSira>@nereyeSira)
--begin
--set @yon=0
--end
--else if(@neredenSira<@nereyeSira)
--begin
--set @yon=1
--end
--select @yon 'yon'


--kilometre hesaplama

--use otobus
--go
--alter proc sp_seferDetaylariGetir
--(
--@guzergahID int
--,@neredenSubeID int 
--,@nereyeSubeID int
--)
--as
--declare @neredenSira int,@nereyeSira int,@guzergahMolaSayisi int,@kilometre int
--select @guzergahMolaSayisi=Count(*) from guzergahMola where guzergahID = @guzergahID
--select @neredenSira=sira from guzergahDurak where guzergahID=@guzergahID  and subeID=@neredenSubeID
--select @nereyeSira=sira from guzergahDurak where guzergahID=@guzergahID  and subeID=@nereyeSubeID
--if(@neredenSira<@nereyeSira)
--begin
--select @kilometre = sum(kilometre) from guzergahDurak where guzergahID=@guzergahID and sira  between @neredenSira+1 and @nereyeSira-1
--end
--else
--begin
--select @kilometre = sum(kilometre) from guzergahDurak where guzergahID=@guzergahID and sira  between @nereyeSira+1 and @neredenSira -1
--end
--select @guzergahMolaSayisi,@kilometre

--KOLTUK KONTROL DOLU BOŞ CİNSİYET
use otobus 
go

select k.koltukNo,m.cinsiyet from koltuk k inner join sefer s on s.seferID =k.seferID 
inner join guzergahDurak gd on gd.guzergahID = s.guzergahID  
inner join musteri m on m.musteriID= k.musteriID
where s.seferID =3 and k.guzergahDurakSira between 0 and 6
group by k.koltukNo,m.cinsiyet order by k.koltukNo


--bilet ekle
insert into bilet(musteriID,seferID,islem,ucret,CalisanID) values (@musteriID,@seferID,@islem,@ucret,@CalisanID)

insert into koltuk (seferID,musteriID,guzergahDurakIDSira,koltukNo) values  (@seferID,@musteriID,@guzergahDurakIDSira,@koltukNo) 