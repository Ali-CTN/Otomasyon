CREATE TABLE TEDARIKCI_ALIM(
ID tinyint not null IDENTITY (1,1) unique,
MALZEME varchar(20) not null,
MIKTAR int,
BIRIM varchar(10) not null,
RENK varchar(10) not null,
ALIM_FÝYATI decimal(18,2) not null,
TOPLAM_FÝYAT decimal(18,2)not null,
SIPARIS_TARIHI DATE NOT NULL,
TESLIM_TARIHI DATE NOT NULL,
TEDARIKCI_FIRMA varchar(20) not null,
ADRES varchar(100) not null,
KAYIT_TARIHI DATETIME not null DEFAULT GETDATE(),
KAYDEDEN varchar(20) not null,
GUNCELLEME_TARIHI DATETIME not null DEFAULT GETDATE(),
GUNCELLEYEN varchar(20) not null
)