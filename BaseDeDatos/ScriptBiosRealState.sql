USE master
GO

IF EXISTS(SELECT * FROM sys.databases WHERE name='BIOSREALSTATE')
BEGIN
	DROP DATABASE BIOSREALSTATE
END
GO

CREATE DATABASE BIOSREALSTATE
GO

USE BIOSREALSTATE
GO

CREATE TABLE Zonas(
	Departamento varchar(1) NOT NULL,
	Codigo varchar(3) NOT NULL,
	Nombre varchar(50) NOT NULL,
	Habitantes int NOT NULL,
	PRIMARY KEY(Departamento,Codigo)
)
GO

CREATE TABLE Servicios(
	Departamento varchar(1) NOT NULL FOREIGN KEY REFERENCES Zonas(Departamento),
	Codigo varchar(3) NOT NULL FOREIGN KEY REFERENCES Zonas(Codigo),
	UnServicio varchar(50) NOT NULL,
	PRIMARY KEY(Departamento,Codigo,UnServicio)
)
GO

CREATE TABLE Empleados(
	UserName varchar(20) NOT NULL PRIMARY KEY,
	Pass varchar(10) NOT NULL
)
GO

CREATE TABLE Propiedades(
	NroPadron int NOT NULL PRIMARY KEY,
	Direccion varchar(50) NOT NULL,
	Precio int NOT NULL,
	Accion varchar(10) NOT NULL,
	Banios int NOT NULL,
	Habitacaiones int NOT NULL,
	Metros int NOT NULL,
	UserName varchar(20) NOT NULL FOREIGN KEY REFERENCES Empleados(UserName),
	Departamento varchar(1) NOT NULL FOREIGN KEY REFERENCES Zonas(Departamento),
	Codigo varchar(3) NOT NULL FOREIGN KEY REFERENCES Zonas(Codigo)
)
GO

CREATE TABLE Casas(
	NroPadron int NOT NULL PRIMARY KEY FOREIGN KEY REFERENCES Propiedades(NroPadron),
	Terreno int NOT NULL,
	Fondo bit NOT NULL
)
GO

CREATE TABLE Apartamentos(
	NroPadron int NOT NULL PRIMARY KEY FOREIGN KEY REFERENCES Propiedades(NroPadron),
	Piso int NOT NULL,
	Ascensor bit NOT NULL
)

CREATE TABLE Locales(
	NroPadron int NOT NULL PRIMARY KEY FOREIGN KEY REFERENCES Propiedades(NroPadron),
	Habilitacion bit NOT NULL
)
GO

CREATE TABLE Visitas(
	DiaYHora datetime NOT NULL,
	NroPadron int NOT NULL FOREIGN KEY REFERENCES Propiedades(NroPadron),
	NomVisitante varchar(50) NOT NULL,
	Telefono varchar(9) NOT NULL,
	PRIMARY KEY (DiaYHora,NroPadron)
)
GO
