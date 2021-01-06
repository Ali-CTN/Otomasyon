CREATE TABLE MUSTERI_SATIS(
ID tinyint not null IDENTITY (1,1)  unique,
URUN varchar(20) not null,
MIKTAR int NOT NULL,
BIRIM varchar(10) not null,
RENK varchar(10) not null,
FIYAT decimal(18,2) not null,
TOPLAM_FIYAT decimal(18,2)not null,
SIPARIS_TARIHI DATE NOT NULL,
TESLIM_TARIHI DATE NOT NULL,
MUSTERI_FIRMA varchar(20) not null,
ADRES varchar(100) not null,
KAYIT_TARIHI DATETIME not null DEFAULT GETDATE(),
KAYDEDEN varchar(20) not null,
GUNCELLEME_TARIHI DATETIME not null DEFAULT GETDATE(),
GUNCELLEYEN varchar(20) not null
)