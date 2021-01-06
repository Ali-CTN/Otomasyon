CREATE TABLE PERSONEL(
ID tinyint not null IDENTITY (1,1)unique,
AD varchar(20) not null,
SOYAD varchar(20) not null,
GOREV  varchar(20)not null,
GIRIS_TARIHI date,
MAAS VARCHAR(10),
TEL_NO CHAR(11) not null,
EMAIL varchar(50) not null,
KULLANICI_ADI VARCHAR(20) not null,
SIFRE varchar(10) not null,
KURTARMA_SORUSU varchar(50) not null,
CEVAP VARCHAR (20)not null
)
