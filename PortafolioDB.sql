-- Crear la base de datos
CREATE DATABASE PortafolioDB;
GO

USE PortafolioDB;
GO

-- Tabla de Persona
CREATE TABLE Persona (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    NombreCompleto NVARCHAR(100) NOT NULL,
    Usuario NVARCHAR(50) NOT NULL UNIQUE,
    Contrasena NVARCHAR(255) NOT NULL,
    Correo NVARCHAR(100) NOT NULL UNIQUE,
    Sexo NVARCHAR(10) NOT NULL,
    Ciudad NVARCHAR(50) NOT NULL,
    AceptaTerminos BIT NOT NULL
);
GO

-- Tabla de Proyectos (recetas)
CREATE TABLE Proyectos (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Titulo NVARCHAR(200) NOT NULL,
    Descripcion NVARCHAR(MAX) NOT NULL,
    ImagenURL NVARCHAR(255),
    Link NVARCHAR(255),
    UsuarioId INT NOT NULL,
    FOREIGN KEY (UsuarioId) REFERENCES Persona(Id)
);
GO

-- Tabla de Contactos
CREATE TABLE Contactos (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100) NOT NULL,
    Mensaje NVARCHAR(MAX) NOT NULL,
    FechaEnvio DATETIME NOT NULL DEFAULT GETDATE()
);
GO
