CREATE DATABASE bs_subastas
GO

USE bs_subastas
GO

CREATE TABLE categorias(
 id_categoria INT NOT NULL IDENTITY CONSTRAINT pkid_categoria PRIMARY KEY,
 nombre_categoria VARCHAR(200) NOT NULL
);
GO

CREATE TABLE usuarios(
 id_usuario INT NOT NULL IDENTITY CONSTRAINT pkid_usuario PRIMARY KEY,
 nombre VARCHAR(50),
 apellido VARCHAR(50),
 direccion VARCHAR(254),
 email VARCHAR(100),
 login VARCHAR(100) NULL,
 clave VARCHAR(250) NULL,
 tipo VARCHAR(20) NULL
);
GO

CREATE TABLE articulo(
 id_articulo INT NOT NULL IDENTITY CONSTRAINT pkid_articulo PRIMARY KEY,
 id_usuario INT NOT NULL CONSTRAINT fkidusuario REFERENCES usuarios,
 nombre_articulo VARCHAR(50),
 descripcion VARCHAR(50), 
 estado VARCHAR(30)
);
GO

CREATE TABLE articulo_categoria(
 id_articulo_categoria INT NOT NULL IDENTITY CONSTRAINT pkid_articulo_categoria PRIMARY KEY,
 id_articulo INT NOT NULL CONSTRAINT fkid_articulo REFERENCES articulo,
 id_categoria INT NOT NULL CONSTRAINT fkid_categoria2 REFERENCES categorias
);
GO

CREATE TABLE subasta(
 id_subasta INT NOT NULL IDENTITY CONSTRAINT pkid_subasta PRIMARY KEY,
 id_articulo INT NOT NULL CONSTRAINT fkid_articulo2 REFERENCES articulo,
 precio FLOAT,
 fecha_limite DATETIME
);
GO

CREATE TABLE ofertas(
 id_ofertas INT NOT NULL IDENTITY CONSTRAINT pkid_oferta2 PRIMARY KEY,
 id_subasta INT NOT NULL CONSTRAINT fkid_subasta2 REFERENCES subasta,
 id_usuario INT NOT NULL CONSTRAINT fkidusuario2 REFERENCES usuarios,
 precio_oferta FLOAT,
 fecha_oferta DATETIME,
 estado VARCHAR(2) NULL
);
GO

CREATE TABLE fotos(
id_imagen INT IDENTITY(1,1) NOT NULL CONSTRAINT pkid_imagen PRIMARY KEY,
id_articulo INT not NULL CONSTRAINT fkid_i_articulo REFERENCES articulo,
imagen_articulo IMAGE NULL
)
Go