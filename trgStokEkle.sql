USE dbT
GO
CREATE TRIGGER trg_StokArt�r
ON Islem
AFTER UPDATE
AS
DECLARE @gunceladet int, @stokid int
	SELECT @gunceladet=islemAdet, @stokid=islemNo from inserted
		update StokHareket set stokUrunAdet=stokUrunAdet+@gunceladet 
			where stokIslemNo=@gunceladet