
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/11/2017 23:33:10
-- Generated from EDMX file: D:\Projekt\VS\NackademinUppgift05\NackademinUppgift05\Zoophobia.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ModelFirst.Zoophobia];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_AnimalVisit]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Visits] DROP CONSTRAINT [FK_AnimalVisit];
GO
IF OBJECT_ID(N'[dbo].[FK_VeterinarianVisit]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Visits] DROP CONSTRAINT [FK_VeterinarianVisit];
GO
IF OBJECT_ID(N'[dbo].[FK_EaterTypeSpecies]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Species] DROP CONSTRAINT [FK_EaterTypeSpecies];
GO
IF OBJECT_ID(N'[dbo].[FK_SpeciesEnvironment]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Species] DROP CONSTRAINT [FK_SpeciesEnvironment];
GO
IF OBJECT_ID(N'[dbo].[FK_AnimalSpecies]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Animals] DROP CONSTRAINT [FK_AnimalSpecies];
GO
IF OBJECT_ID(N'[dbo].[FK_AnimalParents]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Animals] DROP CONSTRAINT [FK_AnimalParents];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Animals]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Animals];
GO
IF OBJECT_ID(N'[dbo].[Veterinarians]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Veterinarians];
GO
IF OBJECT_ID(N'[dbo].[Visits]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Visits];
GO
IF OBJECT_ID(N'[dbo].[EaterTypes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EaterTypes];
GO
IF OBJECT_ID(N'[dbo].[Environments]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Environments];
GO
IF OBJECT_ID(N'[dbo].[Species]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Species];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Animals'
CREATE TABLE [dbo].[Animals] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(255)  NOT NULL,
    [Origin] nvarchar(255)  NOT NULL,
    [Weight] float  NOT NULL,
    [SpeciesId] int  NOT NULL
);
GO

-- Creating table 'Veterinarians'
CREATE TABLE [dbo].[Veterinarians] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(255)  NOT NULL
);
GO

-- Creating table 'Visits'
CREATE TABLE [dbo].[Visits] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Date] datetime  NOT NULL,
    [AnimalId] int  NOT NULL,
    [VeterinarianId] int  NOT NULL
);
GO

-- Creating table 'EaterTypes'
CREATE TABLE [dbo].[EaterTypes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Label] nvarchar(255)  NOT NULL
);
GO

-- Creating table 'Environments'
CREATE TABLE [dbo].[Environments] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Label] nvarchar(255)  NOT NULL
);
GO

-- Creating table 'Species'
CREATE TABLE [dbo].[Species] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Label] nvarchar(255)  NOT NULL,
    [EaterTypeId] int  NOT NULL,
    [EnvironmentId] int  NOT NULL
);
GO

-- Creating table 'AnimalParents'
CREATE TABLE [dbo].[AnimalParents] (
    [ChildId] int  NOT NULL,
    [ParentId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Animals'
ALTER TABLE [dbo].[Animals]
ADD CONSTRAINT [PK_Animals]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Veterinarians'
ALTER TABLE [dbo].[Veterinarians]
ADD CONSTRAINT [PK_Veterinarians]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Visits'
ALTER TABLE [dbo].[Visits]
ADD CONSTRAINT [PK_Visits]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'EaterTypes'
ALTER TABLE [dbo].[EaterTypes]
ADD CONSTRAINT [PK_EaterTypes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Environments'
ALTER TABLE [dbo].[Environments]
ADD CONSTRAINT [PK_Environments]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Species'
ALTER TABLE [dbo].[Species]
ADD CONSTRAINT [PK_Species]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [ChildId], [ParentId] in table 'AnimalParents'
ALTER TABLE [dbo].[AnimalParents]
ADD CONSTRAINT [PK_AnimalParents]
    PRIMARY KEY CLUSTERED ([ChildId], [ParentId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [AnimalId] in table 'Visits'
ALTER TABLE [dbo].[Visits]
ADD CONSTRAINT [FK_AnimalVisit]
    FOREIGN KEY ([AnimalId])
    REFERENCES [dbo].[Animals]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AnimalVisit'
CREATE INDEX [IX_FK_AnimalVisit]
ON [dbo].[Visits]
    ([AnimalId]);
GO

-- Creating foreign key on [VeterinarianId] in table 'Visits'
ALTER TABLE [dbo].[Visits]
ADD CONSTRAINT [FK_VeterinarianVisit]
    FOREIGN KEY ([VeterinarianId])
    REFERENCES [dbo].[Veterinarians]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_VeterinarianVisit'
CREATE INDEX [IX_FK_VeterinarianVisit]
ON [dbo].[Visits]
    ([VeterinarianId]);
GO

-- Creating foreign key on [EaterTypeId] in table 'Species'
ALTER TABLE [dbo].[Species]
ADD CONSTRAINT [FK_EaterTypeSpecies]
    FOREIGN KEY ([EaterTypeId])
    REFERENCES [dbo].[EaterTypes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EaterTypeSpecies'
CREATE INDEX [IX_FK_EaterTypeSpecies]
ON [dbo].[Species]
    ([EaterTypeId]);
GO

-- Creating foreign key on [EnvironmentId] in table 'Species'
ALTER TABLE [dbo].[Species]
ADD CONSTRAINT [FK_SpeciesEnvironment]
    FOREIGN KEY ([EnvironmentId])
    REFERENCES [dbo].[Environments]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SpeciesEnvironment'
CREATE INDEX [IX_FK_SpeciesEnvironment]
ON [dbo].[Species]
    ([EnvironmentId]);
GO

-- Creating foreign key on [SpeciesId] in table 'Animals'
ALTER TABLE [dbo].[Animals]
ADD CONSTRAINT [FK_AnimalSpecies]
    FOREIGN KEY ([SpeciesId])
    REFERENCES [dbo].[Species]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AnimalSpecies'
CREATE INDEX [IX_FK_AnimalSpecies]
ON [dbo].[Animals]
    ([SpeciesId]);
GO

-- Creating foreign key on [ChildId] in table 'AnimalParents'
ALTER TABLE [dbo].[AnimalParents]
ADD CONSTRAINT [FK_AnimalParenting]
    FOREIGN KEY ([ChildId])
    REFERENCES [dbo].[Animals]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ParentId] in table 'AnimalParents'
ALTER TABLE [dbo].[AnimalParents]
ADD CONSTRAINT [FK_AnimalChildering]
    FOREIGN KEY ([ParentId])
    REFERENCES [dbo].[Animals]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AnimalChildering'
CREATE INDEX [IX_FK_AnimalChildering]
ON [dbo].[AnimalParents]
    ([ParentId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------