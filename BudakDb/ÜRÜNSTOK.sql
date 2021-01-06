CREATE TABLE URUN_STOK(
ID int not null IDENTITY (1,1) unique,
URUN varchar(20) not null,
ADI varchar(20) not null,
BIRIM varchar(10) not null,
RENK varchar(10) not null,
MIKTAR int not null,
KAYIT_TARIHI DATETIME not null DEFAULT GETDATE(),
KAYDEDEN varchar(20) not null,
GUNCELLEME_TARIHI DATETIME not null DEFAULT GETDATE(),
GUNCELLEYEN varchar(20) not null
)