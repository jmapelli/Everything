use master;
go

create database everything;
go
use everything;
go

create table tipo (
	id int not null primary key identity,
	nombre varchar(50) not null
)

create table producto (
	id int not null primary key identity,
	nombre varchar(100) not null,
	descripcion varchar(500) not null,
	cantidad varchar(10) not null,
	precio varchar(9) not null,
	etiquetas varchar(500) not null,
	tipo int not null foreign key references tipo(id)
)

create table usuario (
	id int not null primary key identity,
	nombres varchar(100) not null,
	apellidos varchar(100) not null,
	correo varchar(100) not null,
	telefeno varchar(9) not null,
	contraseña varchar(12) not null
)

create table orden (
	id int not null primary key identity,
	orden_fecha varchar(20) not null,
	delivery_fecha varchar(20) not null,
	tipo_documento varchar(20) not null,
	usuario int not null foreign key references usuario(id)
)

create table orden_detalle (
	id int not null primary key identity,
	orden int not null foreign key references orden(id),
	producto int not null foreign key references producto(id),
	cantidad varchar(9) not null,
	precio varchar(9) not null,
	total varchar(9) not null
)