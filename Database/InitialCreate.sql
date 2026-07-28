-- SQL script generated to create initial ChurchDB schema for MemberCrud
IF DB_ID('ChurchDB') IS NULL
BEGIN
	CREATE DATABASE [ChurchDB];
END
GO

USE [ChurchDB];
GO

SET ANSI_NULLS ON;
SET QUOTED_IDENTIFIER ON;
GO

CREATE TABLE [dbo].[Ministries]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Name] NVARCHAR(MAX) NOT NULL
);
GO

CREATE TABLE [dbo].[Members]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[FirstName] NVARCHAR(MAX) NOT NULL,
	[LastName] NVARCHAR(MAX) NOT NULL,
	[Phone] NVARCHAR(MAX) NOT NULL,
	[Email] NVARCHAR(MAX) NOT NULL,
	[MembershipStatus] NVARCHAR(MAX) NOT NULL,
	[CreateAt] DATETIME2 NOT NULL
);
GO

CREATE TABLE [dbo].[MemberMinistries]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[MemberId] INT NOT NULL,
	[MinistryId] INT NOT NULL,
	CONSTRAINT FK_MemberMinistries_Members FOREIGN KEY (MemberId) REFERENCES Members(Id) ON DELETE CASCADE,
	CONSTRAINT FK_MemberMinistries_Ministries FOREIGN KEY (MinistryId) REFERENCES Ministries(Id) ON DELETE CASCADE
);
GO

CREATE INDEX IX_MemberMinistries_MemberId ON dbo.MemberMinistries(MemberId);
CREATE INDEX IX_MemberMinistries_MinistryId ON dbo.MemberMinistries(MinistryId);
GO
