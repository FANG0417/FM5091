
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/02/2021 20:08:35
-- Generated from EDMX file: C:\Users\54571\source\repos\WindowsFormsApp4\WindowsFormsApp4\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [OPMdb];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_InstrumentPrice]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PriceSet] DROP CONSTRAINT [FK_InstrumentPrice];
GO
IF OBJECT_ID(N'[dbo].[FK_InstrumentTrade]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TradeSet] DROP CONSTRAINT [FK_InstrumentTrade];
GO
IF OBJECT_ID(N'[dbo].[FK_InstTypeInstrument]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[InstrumentSet] DROP CONSTRAINT [FK_InstTypeInstrument];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[InstrumentSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[InstrumentSet];
GO
IF OBJECT_ID(N'[dbo].[InstTypeSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[InstTypeSet];
GO
IF OBJECT_ID(N'[dbo].[InterestRateSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[InterestRateSet];
GO
IF OBJECT_ID(N'[dbo].[PriceSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PriceSet];
GO
IF OBJECT_ID(N'[dbo].[TradeSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TradeSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'InstrumentSet'
CREATE TABLE [dbo].[InstrumentSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CompanyName] nvarchar(max)  NOT NULL,
    [Ticker] nvarchar(max)  NOT NULL,
    [Exchange] nvarchar(max)  NOT NULL,
    [Underlying] nvarchar(max)  NULL,
    [Strike] float  NULL,
    [Tenor] float  NULL,
    [IsCall] bit  NULL,
    [InstTypeId] int  NOT NULL,
    [Rebate] float  NULL,
    [Barrier] float  NULL,
    [BarrierType] nvarchar(max)  NULL
);
GO

-- Creating table 'PriceSet'
CREATE TABLE [dbo].[PriceSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Date] datetime  NOT NULL,
    [ClosingPrice] float  NOT NULL,
    [InstrumentId] int  NOT NULL
);
GO

-- Creating table 'InstTypeSet'
CREATE TABLE [dbo].[InstTypeSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [TypeName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'InterestRateSet'
CREATE TABLE [dbo].[InterestRateSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Tenor] float  NOT NULL,
    [Rate] float  NOT NULL
);
GO

-- Creating table 'TradeSet'
CREATE TABLE [dbo].[TradeSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [IsBuy] bit  NOT NULL,
    [Quantity] float  NOT NULL,
    [Price] float  NOT NULL,
    [Timestamp] datetime  NOT NULL,
    [InstrumentId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'InstrumentSet'
ALTER TABLE [dbo].[InstrumentSet]
ADD CONSTRAINT [PK_InstrumentSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PriceSet'
ALTER TABLE [dbo].[PriceSet]
ADD CONSTRAINT [PK_PriceSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'InstTypeSet'
ALTER TABLE [dbo].[InstTypeSet]
ADD CONSTRAINT [PK_InstTypeSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'InterestRateSet'
ALTER TABLE [dbo].[InterestRateSet]
ADD CONSTRAINT [PK_InterestRateSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TradeSet'
ALTER TABLE [dbo].[TradeSet]
ADD CONSTRAINT [PK_TradeSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [InstrumentId] in table 'PriceSet'
ALTER TABLE [dbo].[PriceSet]
ADD CONSTRAINT [FK_InstrumentPrice]
    FOREIGN KEY ([InstrumentId])
    REFERENCES [dbo].[InstrumentSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_InstrumentPrice'
CREATE INDEX [IX_FK_InstrumentPrice]
ON [dbo].[PriceSet]
    ([InstrumentId]);
GO

-- Creating foreign key on [InstTypeId] in table 'InstrumentSet'
ALTER TABLE [dbo].[InstrumentSet]
ADD CONSTRAINT [FK_InstTypeInstrument]
    FOREIGN KEY ([InstTypeId])
    REFERENCES [dbo].[InstTypeSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_InstTypeInstrument'
CREATE INDEX [IX_FK_InstTypeInstrument]
ON [dbo].[InstrumentSet]
    ([InstTypeId]);
GO

-- Creating foreign key on [InstrumentId] in table 'TradeSet'
ALTER TABLE [dbo].[TradeSet]
ADD CONSTRAINT [FK_InstrumentTrade]
    FOREIGN KEY ([InstrumentId])
    REFERENCES [dbo].[InstrumentSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_InstrumentTrade'
CREATE INDEX [IX_FK_InstrumentTrade]
ON [dbo].[TradeSet]
    ([InstrumentId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------