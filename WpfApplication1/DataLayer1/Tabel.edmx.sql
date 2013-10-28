
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 10/28/2013 18:34:16
-- Generated from EDMX file: C:\Users\haritha\Documents\GitHub\program\WpfApplication1\DataLayer1\Tabel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [CSharp];
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

-- Creating table 'Students'
CREATE TABLE [dbo].[Students] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FName] nvarchar(max)  NOT NULL,
    [LName] nvarchar(max)  NOT NULL,
    [StandardId] nvarchar(max)  NOT NULL,
    [CampusId] int  NOT NULL,
    [Standard_Id] int  NOT NULL,
    [Faculty_Id] int  NOT NULL,
    [Program_Id] int  NOT NULL
);
GO

-- Creating table 'Standards'
CREATE TABLE [dbo].[Standards] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [StandardName] nvarchar(max)  NOT NULL,
    [StandardId] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Faculties'
CREATE TABLE [dbo].[Faculties] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [SSN] nvarchar(max)  NOT NULL,
    [Address] nvarchar(max)  NOT NULL,
    [CampusId] int  NOT NULL,
    [Program_Id] int  NOT NULL,
    [Account_Id] int  NOT NULL,
    [Department_Id] int  NOT NULL
);
GO

-- Creating table 'Programs'
CREATE TABLE [dbo].[Programs] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Telephone] nvarchar(max)  NOT NULL,
    [DepartmentId] nvarchar(max)  NOT NULL,
    [FacultyId] int  NOT NULL,
    [CampusId] int  NOT NULL
);
GO

-- Creating table 'Campus'
CREATE TABLE [dbo].[Campus] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Location] nvarchar(max)  NOT NULL,
    [CampusType] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Cars'
CREATE TABLE [dbo].[Cars] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [VIN] nvarchar(max)  NOT NULL,
    [Model] nvarchar(max)  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Student_Id] int  NOT NULL
);
GO

-- Creating table 'Accounts'
CREATE TABLE [dbo].[Accounts] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [AcctNum] nvarchar(max)  NOT NULL,
    [Type] nvarchar(max)  NOT NULL,
    [Branch_Id] int  NOT NULL
);
GO

-- Creating table 'Branches'
CREATE TABLE [dbo].[Branches] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [BranchNo] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Departments'
CREATE TABLE [dbo].[Departments] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [DepartId] nvarchar(max)  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [CampusId] int  NOT NULL
);
GO

-- Creating table 'Projects'
CREATE TABLE [dbo].[Projects] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Type] nvarchar(max)  NOT NULL,
    [DepartmentId] int  NOT NULL
);
GO

-- Creating table 'Books'
CREATE TABLE [dbo].[Books] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ISBN] nvarchar(max)  NOT NULL,
    [Author] nvarchar(max)  NOT NULL,
    [Title] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Entity1'
CREATE TABLE [dbo].[Entity1] (
    [Id] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'StudentAccount'
CREATE TABLE [dbo].[StudentAccount] (
    [Students_Id] int  NOT NULL,
    [Accounts_Id] int  NOT NULL
);
GO

-- Creating table 'StudentBook'
CREATE TABLE [dbo].[StudentBook] (
    [Students_Id] int  NOT NULL,
    [Books_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Students'
ALTER TABLE [dbo].[Students]
ADD CONSTRAINT [PK_Students]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Standards'
ALTER TABLE [dbo].[Standards]
ADD CONSTRAINT [PK_Standards]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Faculties'
ALTER TABLE [dbo].[Faculties]
ADD CONSTRAINT [PK_Faculties]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Programs'
ALTER TABLE [dbo].[Programs]
ADD CONSTRAINT [PK_Programs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Campus'
ALTER TABLE [dbo].[Campus]
ADD CONSTRAINT [PK_Campus]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Cars'
ALTER TABLE [dbo].[Cars]
ADD CONSTRAINT [PK_Cars]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Accounts'
ALTER TABLE [dbo].[Accounts]
ADD CONSTRAINT [PK_Accounts]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Branches'
ALTER TABLE [dbo].[Branches]
ADD CONSTRAINT [PK_Branches]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Departments'
ALTER TABLE [dbo].[Departments]
ADD CONSTRAINT [PK_Departments]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Projects'
ALTER TABLE [dbo].[Projects]
ADD CONSTRAINT [PK_Projects]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Books'
ALTER TABLE [dbo].[Books]
ADD CONSTRAINT [PK_Books]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Entity1'
ALTER TABLE [dbo].[Entity1]
ADD CONSTRAINT [PK_Entity1]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Students_Id], [Accounts_Id] in table 'StudentAccount'
ALTER TABLE [dbo].[StudentAccount]
ADD CONSTRAINT [PK_StudentAccount]
    PRIMARY KEY NONCLUSTERED ([Students_Id], [Accounts_Id] ASC);
GO

-- Creating primary key on [Students_Id], [Books_Id] in table 'StudentBook'
ALTER TABLE [dbo].[StudentBook]
ADD CONSTRAINT [PK_StudentBook]
    PRIMARY KEY NONCLUSTERED ([Students_Id], [Books_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Standard_Id] in table 'Students'
ALTER TABLE [dbo].[Students]
ADD CONSTRAINT [FK_StudentStandard]
    FOREIGN KEY ([Standard_Id])
    REFERENCES [dbo].[Standards]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_StudentStandard'
CREATE INDEX [IX_FK_StudentStandard]
ON [dbo].[Students]
    ([Standard_Id]);
GO

-- Creating foreign key on [Faculty_Id] in table 'Students'
ALTER TABLE [dbo].[Students]
ADD CONSTRAINT [FK_StudentFaculty]
    FOREIGN KEY ([Faculty_Id])
    REFERENCES [dbo].[Faculties]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_StudentFaculty'
CREATE INDEX [IX_FK_StudentFaculty]
ON [dbo].[Students]
    ([Faculty_Id]);
GO

-- Creating foreign key on [FacultyId] in table 'Programs'
ALTER TABLE [dbo].[Programs]
ADD CONSTRAINT [FK_FacultyProgram]
    FOREIGN KEY ([FacultyId])
    REFERENCES [dbo].[Faculties]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FacultyProgram'
CREATE INDEX [IX_FK_FacultyProgram]
ON [dbo].[Programs]
    ([FacultyId]);
GO

-- Creating foreign key on [Program_Id] in table 'Students'
ALTER TABLE [dbo].[Students]
ADD CONSTRAINT [FK_StudentProgram]
    FOREIGN KEY ([Program_Id])
    REFERENCES [dbo].[Programs]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_StudentProgram'
CREATE INDEX [IX_FK_StudentProgram]
ON [dbo].[Students]
    ([Program_Id]);
GO

-- Creating foreign key on [CampusId] in table 'Students'
ALTER TABLE [dbo].[Students]
ADD CONSTRAINT [FK_CampusStudent]
    FOREIGN KEY ([CampusId])
    REFERENCES [dbo].[Campus]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CampusStudent'
CREATE INDEX [IX_FK_CampusStudent]
ON [dbo].[Students]
    ([CampusId]);
GO

-- Creating foreign key on [CampusId] in table 'Faculties'
ALTER TABLE [dbo].[Faculties]
ADD CONSTRAINT [FK_CampusFaculty]
    FOREIGN KEY ([CampusId])
    REFERENCES [dbo].[Campus]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CampusFaculty'
CREATE INDEX [IX_FK_CampusFaculty]
ON [dbo].[Faculties]
    ([CampusId]);
GO

-- Creating foreign key on [CampusId] in table 'Programs'
ALTER TABLE [dbo].[Programs]
ADD CONSTRAINT [FK_CampusProgram]
    FOREIGN KEY ([CampusId])
    REFERENCES [dbo].[Campus]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CampusProgram'
CREATE INDEX [IX_FK_CampusProgram]
ON [dbo].[Programs]
    ([CampusId]);
GO

-- Creating foreign key on [Student_Id] in table 'Cars'
ALTER TABLE [dbo].[Cars]
ADD CONSTRAINT [FK_StudentCar]
    FOREIGN KEY ([Student_Id])
    REFERENCES [dbo].[Students]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_StudentCar'
CREATE INDEX [IX_FK_StudentCar]
ON [dbo].[Cars]
    ([Student_Id]);
GO

-- Creating foreign key on [Students_Id] in table 'StudentAccount'
ALTER TABLE [dbo].[StudentAccount]
ADD CONSTRAINT [FK_StudentAccount_Student]
    FOREIGN KEY ([Students_Id])
    REFERENCES [dbo].[Students]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Accounts_Id] in table 'StudentAccount'
ALTER TABLE [dbo].[StudentAccount]
ADD CONSTRAINT [FK_StudentAccount_Account]
    FOREIGN KEY ([Accounts_Id])
    REFERENCES [dbo].[Accounts]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_StudentAccount_Account'
CREATE INDEX [IX_FK_StudentAccount_Account]
ON [dbo].[StudentAccount]
    ([Accounts_Id]);
GO

-- Creating foreign key on [Program_Id] in table 'Faculties'
ALTER TABLE [dbo].[Faculties]
ADD CONSTRAINT [FK_FacultyProgram1]
    FOREIGN KEY ([Program_Id])
    REFERENCES [dbo].[Programs]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FacultyProgram1'
CREATE INDEX [IX_FK_FacultyProgram1]
ON [dbo].[Faculties]
    ([Program_Id]);
GO

-- Creating foreign key on [Account_Id] in table 'Faculties'
ALTER TABLE [dbo].[Faculties]
ADD CONSTRAINT [FK_FacultyAccount]
    FOREIGN KEY ([Account_Id])
    REFERENCES [dbo].[Accounts]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FacultyAccount'
CREATE INDEX [IX_FK_FacultyAccount]
ON [dbo].[Faculties]
    ([Account_Id]);
GO

-- Creating foreign key on [Branch_Id] in table 'Accounts'
ALTER TABLE [dbo].[Accounts]
ADD CONSTRAINT [FK_AccountBranch]
    FOREIGN KEY ([Branch_Id])
    REFERENCES [dbo].[Branches]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_AccountBranch'
CREATE INDEX [IX_FK_AccountBranch]
ON [dbo].[Accounts]
    ([Branch_Id]);
GO

-- Creating foreign key on [CampusId] in table 'Departments'
ALTER TABLE [dbo].[Departments]
ADD CONSTRAINT [FK_CampusDepartment]
    FOREIGN KEY ([CampusId])
    REFERENCES [dbo].[Campus]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CampusDepartment'
CREATE INDEX [IX_FK_CampusDepartment]
ON [dbo].[Departments]
    ([CampusId]);
GO

-- Creating foreign key on [Department_Id] in table 'Faculties'
ALTER TABLE [dbo].[Faculties]
ADD CONSTRAINT [FK_DepartmentFaculty]
    FOREIGN KEY ([Department_Id])
    REFERENCES [dbo].[Departments]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_DepartmentFaculty'
CREATE INDEX [IX_FK_DepartmentFaculty]
ON [dbo].[Faculties]
    ([Department_Id]);
GO

-- Creating foreign key on [DepartmentId] in table 'Projects'
ALTER TABLE [dbo].[Projects]
ADD CONSTRAINT [FK_DepartmentProject]
    FOREIGN KEY ([DepartmentId])
    REFERENCES [dbo].[Departments]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_DepartmentProject'
CREATE INDEX [IX_FK_DepartmentProject]
ON [dbo].[Projects]
    ([DepartmentId]);
GO

-- Creating foreign key on [Students_Id] in table 'StudentBook'
ALTER TABLE [dbo].[StudentBook]
ADD CONSTRAINT [FK_StudentBook_Student]
    FOREIGN KEY ([Students_Id])
    REFERENCES [dbo].[Students]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Books_Id] in table 'StudentBook'
ALTER TABLE [dbo].[StudentBook]
ADD CONSTRAINT [FK_StudentBook_Book]
    FOREIGN KEY ([Books_Id])
    REFERENCES [dbo].[Books]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_StudentBook_Book'
CREATE INDEX [IX_FK_StudentBook_Book]
ON [dbo].[StudentBook]
    ([Books_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------