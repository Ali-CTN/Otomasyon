CREATE TABLE MALZEME_STOK(
ID tinyint not null unique IDENTITY (1,1),
MALZEME VARCHAR(20) NOT NULL,
BIRIM varchar(10) not null,
RENK varchar(10) not null,
MIKTAR int not null,
KAYIT_TARIHI DATETIME not null DEFAULT GETDATE(),
KAYDEDEN varchar(20) not null,
GUNCELLEME_TARIHI DATETIME not null DEFAULT GETDATE(),
GUNCELLEYEN varchar(20) not null
)