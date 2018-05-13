-------Create Database
----CREATE DATABASE [ShopV3]

------Create Models
USE [ShopV3]
GO

----Users
CREATE TABLE Users(
     UserId INT IDENTITY(1,1) PRIMARY KEY,
    NumePrenume VARCHAR(255) NOT NULL,
    Email VARCHAR(255) NOT NULL,
    Telefon VARCHAR(10) NOT NULL,
    Adresa VARCHAR(255) NOT NULL,
    Parola VARCHAR(255) NOT NULL,
    Nickname VARCHAR(255)
    
);

--Vanzatori
CREATE TABLE Vanzatori(
    VanzatorId INT IDENTITY(1,1) PRIMARY KEY,
    UserId INT FOREIGN KEY REFERENCES Users(UserId),
    NumeCompanie VARCHAR(255) NOT NULL,
    Cont VARCHAR(255) NOT NULL,
    CUI VARCHAR(255) NOT NULL

);

--Admini
CREATE TABLE Admins(
    AdminId INT IDENTITY(1,1) PRIMARY KEY,
    UserId INT FOREIGN KEY REFERENCES Users(UserId)

);

----Produse

--Branduri
CREATE TABLE Branduri(
    BrandId INT IDENTITY(1,1) PRIMARY KEY,
    NumeBrand VARCHAR(255) NOT NULL

);

--Categorii Produse
CREATE TABLE CategoriiProduse(
    CategorieId int IDENTITY(1,1) PRIMARY KEY,
    NumeCategorie VARCHAR(255) NOT NULL
);

--Produse

CREATE TABLE Produse(
    ProdusId INT IDENTITY(1,1) PRIMARY KEY,
    VanzatorId INT FOREIGN KEY REFERENCES Vanzatori(VanzatorId),
    BrandId INT FOREIGN KEY REFERENCES Branduri(BrandId),
    CategorieId INT FOREIGN KEY REFERENCES CategoriiProduse(CategorieId),

    NumeProdus VARCHAR(255) NOT NULL,
    Pret DECIMAL NOT NULL,
    Stoc INT NOT NULL,
    Caracteristici TEXT NOT NULL,
    Imagine IMAGE NULL
);

----Orders

CREATE TABLE Cumparare(
    CumparareId INT IDENTITY(1,1) PRIMARY KEY,
    UserId INT FOREIGN KEY REFERENCES Users(UserId)
);
CREATE TABLE CumparareItem(
    CumparareId INT FOREIGN KEY REFERENCES Cumparare(CumparareId),
    ProdusId INT FOREIGN KEY REFERENCES Produse(ProdusId),
    NumarIteme INT,
	Primary Key(CumparareId, ProdusId)
);
