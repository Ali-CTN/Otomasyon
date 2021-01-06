CREATE TABLE TEDARIKCI(
ID tinyint not null IDENTITY (1,1) UNIQUE,
TEDARIKCI_FIRMA varchar(20) not null,
AD varchar(20) not null,
SOYAD varchar(20) not null,
TEL_NO1 CHAR(11) not null,
TEL_NO2 CHAR(11) not null,
EMAIL varchar(50)not null,
ADRES varchar(100)unique
)
