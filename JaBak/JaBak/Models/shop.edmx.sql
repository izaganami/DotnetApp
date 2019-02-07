
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 01/06/2019 00:15:23
-- Generated from EDMX file: C:\Users\izaganami\Desktop\cours_web\projetdotnet\projetdotnet\Models\shop.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [shop];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[acheter]', 'U') IS NOT NULL
    DROP TABLE [dbo].[acheter];
GO
IF OBJECT_ID(N'[dbo].[produit]', 'U') IS NOT NULL
    DROP TABLE [dbo].[produit];
GO
IF OBJECT_ID(N'[dbo].[reserver]', 'U') IS NOT NULL
    DROP TABLE [dbo].[reserver];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'acheter'
CREATE TABLE [dbo].[acheter] (
    [id_achat] int IDENTITY(1,1) NOT NULL,
    [id_produit] int  NULL,
    [id_client] nchar(36)  NULL,
    [libelle] nchar(50)  NULL,
    [id_fournisseur] varchar(36)  NULL,
    [catégorie] varchar(50)  NULL,
    [Email] nvarchar(256)  NULL,
    [Prix] float  NULL
);
GO

-- Creating table 'reserver'
CREATE TABLE [dbo].[reserver] (
    [id_reservation] int IDENTITY(1,1) NOT NULL,
    [id_client] varchar(36)  NULL,
    [id_produit] int  NULL,
    [id_fournisseur] varchar(36)  NULL,
    [libelle] nchar(50)  NULL,
    [catégorie] varchar(50)  NULL,
    [Email] nvarchar(256)  NULL,
    [Prix] float  NULL
);
GO

-- Creating table 'produit'
CREATE TABLE [dbo].[produit] (
    [id_produit] int IDENTITY(1,1) NOT NULL,
    [libelle] varchar(50)  NULL,
    [catégorie] varchar(50)  NULL,
    [prix] float  NULL,
    [quantité] int  NULL,
    [id_fournisseur] varchar(36)  NULL,
    [PhotoFile] varbinary(max)  NULL,
    [ImageMimeType] nvarchar(max)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [id_achat] in table 'acheter'
ALTER TABLE [dbo].[acheter]
ADD CONSTRAINT [PK_acheter]
    PRIMARY KEY CLUSTERED ([id_achat] ASC);
GO

-- Creating primary key on [id_reservation] in table 'reserver'
ALTER TABLE [dbo].[reserver]
ADD CONSTRAINT [PK_reserver]
    PRIMARY KEY CLUSTERED ([id_reservation] ASC);
GO

-- Creating primary key on [id_produit] in table 'produit'
ALTER TABLE [dbo].[produit]
ADD CONSTRAINT [PK_produit]
    PRIMARY KEY CLUSTERED ([id_produit] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------