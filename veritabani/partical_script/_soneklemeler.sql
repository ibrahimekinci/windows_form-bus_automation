
create trigger tg_calisanSil on calisan
instead of delete 
as
declare @calisanID int;
select @calisanID=calisanID from deleted
update calisan set durum=0 where calisanID=@calisanID
go

create trigger tg_GuzergahSil on guzergah
instead of delete 
as
update guzergah set durum = 0 from guzergah g inner join deleted d on g.guzergahID =d.guzergahID
go

trigger tg_seferEkle on sefer
for insert 
as

declare @tarih datetime;
select @tarih=kalkisTarihi from inserted

if(@tarih<GETDATE())
begin
select @tarih
    RAISERROR ('Sefer tarihi þimdiki zamandan sonraki bir tarihte olmalýdýr',16,1)
 rollback

end
go

insert into sefer(otobusID,kalkisTarihi,guzergahID,durum,yon) values (8,'2014-01-25 00:00:00.000',11,1,1)