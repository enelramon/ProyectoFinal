create database PaquetesDb
go

use PaquetesDb
go

create table UsuarioEmpleados(
UsuarioEmpleadoId int identity primary key,
Usuario varchar(max),
Clave varchar(max)
)
go

insert into UsuarioEmpleados values('root','')
go

create table Usuarios(
UsuarioId int identity primary key,
ClienteId int not null,
Usuario varchar(max),
Clave varchar(max)
)
go

insert into Usuarios values('root','')
go

create table Transportes(
TransporteId int identity primary key,
Compania varchar(max),
Telefono varchar(max)
)
go

insert into Transportes values('Caribe Tours','809-999-9999')
insert into Transportes values('USPS','809-789-1258')
go


create table Paquetes(
PaqueteId int identity primary key,
ClienteId int not null,
TransporteId int not null,
Estado varchar(max),
Tracking varchar(max),
Contenido varchar(max),
Proveedor varchar(max),
Transportista varchar(max),
Peso float
)
go


create table Clientes(
ClienteId int identity primary key,
UsuarioId int not null,
Nombres varchar(max),
Edad int constraint CK_Clientes_Edad check (Edad > 0),
Sexo char(1),
Telefono varchar(max),
Celular varchar(max),
Email varchar(max),
Ciudad varchar(max)
)
go

create table Facturas(
FacturaId int identity primary key,
ClienteId int not null,
Fecha date,
Monto money
)
go

create table FacturaDetalles(
Id int identity primary key,
FacturaId int not null,
PaqueteId int not null,
Contenido varchar(max),
Proveedor varchar(max),
Peso float,
Descuento float,
Precio money
)
go


