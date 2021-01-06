CREATE TABLE MUSTERI(
ID tinyint not null IDENTITY (1,1) unique ,
MUSTERI_FIRMA varchar(20) primary key not null,
AD varchar(20) not null,
SOYAD varchar(20) not null,
TEL_NO1 CHAR(11) not null,
TEL_NO2 CHAR(11)NULL,
EMAIL varchar(50) NOT NULL,
ADRES varchar(100) NOT NULL
)