CREATE TABLE URUN(
ID tinyint  not null IDENTITY (1,1) unique,
RESIM varchar(100),
URUN varchar(20) not null primary key,
RENK varchar(10) not null,
BIRIM varchar(10) not null,
FIYAT decimal(18,2)not null,
KAYIT_TARIHI DATETIME not null DEFAULT GETDATE(),
KAYDEDEN varchar(20) not null,
GUNCELLEME_TARIHI DATETIME not null DEFAULT GETDATE(),
GUNCELLEYEN varchar(20) not null
)