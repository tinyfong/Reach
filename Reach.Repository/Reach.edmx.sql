
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/25/2015 23:30:53
-- Generated from EDMX file: E:\Projects\Reach\Reach.Repository\Reach.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Reach];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[VideoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[VideoSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'VideoSet'
CREATE TABLE [dbo].[VideoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [YoukuId] nvarchar(max)  NULL,
    [Name] nvarchar(max)  NULL,
    [Url] nvarchar(max)  NULL,
    [Description] nvarchar(max)  NULL,
    [UpdateTime] nvarchar(max)  NULL,
    [Customer] nvarchar(max)  NULL,
    [Rank] int  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'VideoSet'
ALTER TABLE [dbo].[VideoSet]
ADD CONSTRAINT [PK_VideoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------