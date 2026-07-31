CREATE DATABASE MemberCrud;
GO

-- To use MemberCrub

USE MemberCrud;
GO

-- Members table
CREATE TABLE Members
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    FirstName VARCHAR(60) NOT NULL,
    LastName VARCHAR(60) NOT NULL,
    Phone BIGINT NULL,  
    Email CHAR(100) NULL,  
    MembershipStatus VARCHAR(50) NOT NULL,
    CreatedAt DATETIME NOT NULL DEFAULT GETDATE(),
    Street CHAR(100),
    City CHAR(100),
    State CHAR(70),
    PostalCode VARCHAR(20),
    DateOfBirth DATE,
    CONSTRAINT chk_phone_or_email CHECK (Phone IS NOT NULL OR Email IS NOT NULL)
);


-- Ministries table
CREATE TABLE Ministries
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    Description NVARCHAR(255) NOT NULL
);

-- MemberMinistries table
CREATE TABLE MemberMinistries
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    MemberId INT NOT NULL,
    MinistryId INT NOT NULL,

    CONSTRAINT FK_MemberMinistries_Members
        FOREIGN KEY (MemberId)
        REFERENCES Members(Id),

    CONSTRAINT FK_MemberMinistries_Ministries
        FOREIGN KEY (MinistryId)
        REFERENCES Ministries(Id),

    CONSTRAINT UQ_MemberMinistries_MemberId_MinistryId
        UNIQUE (MemberId, MinistryId)
);

-- VolunteerMessages table
CREATE TABLE VolunteerMessages
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    MemberId INT NOT NULL,
    MessageText NVARCHAR(MAX) NOT NULL,
    SentAt DATETIME NOT NULL,

    CONSTRAINT FK_VolunteerMessages_Members
        FOREIGN KEY (MemberId)
        REFERENCES Members(Id)
);
GO