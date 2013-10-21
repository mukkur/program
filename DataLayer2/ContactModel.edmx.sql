
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 10/03/2013 16:31:10
-- Generated from EDMX file: C:\Users\haritha\Documents\GitHub\program\ConsoleAppSample1\DataLayer\ContactModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [code];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Contacts1'
CREATE TABLE [dbo].[Contacts1] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL,
    [KeywordId] int  NOT NULL
);
GO

-- Creating table 'Keywords1'
CREATE TABLE [dbo].[Keywords1] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [KeywordId] int  NOT NULL
);
GO

-- Creating table 'ContactMethods'
CREATE TABLE [dbo].[ContactMethods] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ContactsId] int  NOT NULL,
    [KeywordsId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Contacts1'
ALTER TABLE [dbo].[Contacts1]
ADD CONSTRAINT [PK_Contacts1]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Keywords1'
ALTER TABLE [dbo].[Keywords1]
ADD CONSTRAINT [PK_Keywords1]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ContactMethods'
ALTER TABLE [dbo].[ContactMethods]
ADD CONSTRAINT [PK_ContactMethods]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [KeywordId] in table 'Contacts1'
ALTER TABLE [dbo].[Contacts1]
ADD CONSTRAINT [FK_ContactsKeywords]
    FOREIGN KEY ([KeywordId])
    REFERENCES [dbo].[Keywords1]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ContactsKeywords'
CREATE INDEX [IX_FK_ContactsKeywords]
ON [dbo].[Contacts1]
    ([KeywordId]);
GO

-- Creating foreign key on [ContactsId] in table 'ContactMethods'
ALTER TABLE [dbo].[ContactMethods]
ADD CONSTRAINT [FK_ContactsContactMethod]
    FOREIGN KEY ([ContactsId])
    REFERENCES [dbo].[Contacts1]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ContactsContactMethod'
CREATE INDEX [IX_FK_ContactsContactMethod]
ON [dbo].[ContactMethods]
    ([ContactsId]);
GO

-- Creating foreign key on [KeywordsId] in table 'ContactMethods'
ALTER TABLE [dbo].[ContactMethods]
ADD CONSTRAINT [FK_KeywordsContactMethod]
    FOREIGN KEY ([KeywordsId])
    REFERENCES [dbo].[Keywords1]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_KeywordsContactMethod'
CREATE INDEX [IX_FK_KeywordsContactMethod]
ON [dbo].[ContactMethods]
    ([KeywordsId]);
GO

-- Creating foreign key on [KeywordId] in table 'Keywords1'
ALTER TABLE [dbo].[Keywords1]
ADD CONSTRAINT [FK_KeywordKeyword]
    FOREIGN KEY ([KeywordId])
    REFERENCES [dbo].[Keywords1]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_KeywordKeyword'
CREATE INDEX [IX_FK_KeywordKeyword]
ON [dbo].[Keywords1]
    ([KeywordId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------