CREATE TABLE MALZEME(
ID tinyint  not null IDENTITY (1,1) UNIQUE,
MALZEME varchar(20) not null,
RENK varchar(10) not null,
BIRIM varchar(10) not null,
FIYAT decimal(18,2)not null,
KAYIT_TARIHI DATETIME NOT NULL DEFAULT GETDATE() ,
KAYDEDEN varchar(20) not null ,
GUNCELLEME_TARIHI DATETIME not null DEFAULT GETDATE(),
GUNCELLEYEN varchar(20) not null
)