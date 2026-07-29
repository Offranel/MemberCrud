CREATE DATABASE MemberCrud;
GO

-- To use MemberCrub

USE MemberCrud;
GO

-- Members table
CREATE TABLE Members
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    FirstName NVARCHAR(100) NOT NULL,
    LastName NVARCHAR(100) NOT NULL,
    Phone NVARCHAR(30) NOT NULL,
    Email NVARCHAR(100) NOT NULL,
    MembershipStatus NVARCHAR(50) NOT NULL,
    CreateAt DATETIME NOT NULL
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
        REFERENCES Ministries(Id)
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