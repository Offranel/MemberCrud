CREATE DATABASE MemberCrud;
GO

-- To use MemberCrub

USE MemberCrud;
GO

-- The Members table stores essential information about individuals who 
-- are part of an organization or community. It includes required details 
-- such as names, contact information (phone and email), and membership status, 
-- as well as optional details like address, postal code, and date of birth. 
-- The table also tracks when a member was added to the system, ensuring 
-- accurate record-keeping and enabling efficient management of member data.
-- This table serves as the foundation for tracking memberships, communications, and engagement.
CREATE TABLE Members
(
    -- Unique identifier for each member (auto-incremented)
    Id INT IDENTITY(1,1) PRIMARY KEY,

    -- Member's first name (required)
    FirstName NVARCHAR(100) NOT NULL,

    -- Member's last name (required)
    LastName NVARCHAR(100) NOT NULL,

    -- Member's phone number (required, stored as string to preserve formatting)
    Phone NVARCHAR(30) NOT NULL,

    -- Member's email address (required)
    Email NVARCHAR(100) NOT NULL,

    -- Current status of the member's membership (e.g., Active, Expired, Pending)
    MembershipStatus NVARCHAR(50) NOT NULL,

    -- Date and time when the member record was created (defaults to current timestamp)
    CreatedAt DATETIME NOT NULL DEFAULT GETDATE(),

    -- Street address (optional)
    Street CHAR(200),

    -- City (optional)
    City CHAR(100),

    -- State or province (optional)
    State CHAR(100),

    -- Postal or ZIP code (optional)
    PostalCode VARCHAR(20),

    -- Member's date of birth (NOT optional)
    DateOfBirth DATE NOT NULL
);


-- The Ministries table stores information about the different
-- groups or departments within an organization. 
-- Each entry includes a unique identifier, a name, and a description 
-- of the ministry. This table helps categorize and manage members
-- based on their affiliations or roles within the organization.
CREATE TABLE Ministries
(
    -- Unique identifier for each ministry (auto-incremented)
    Id INT IDENTITY(1,1) PRIMARY KEY,

    -- Name of the ministry (required) 
    Name NVARCHAR(100) NOT NULL,

    -- Description of the ministry (required)
    Description NVARCHAR(255) NOT NULL
);

-- The MemberMinistries table acts as a junction table that links 
-- members to ministries. It ensures each member can only be 
-- assigned to a specific ministry once, maintaining a clean and 
-- organized relationship between members and their affiliated groups.
-- This table enforces referential integrity by requiring that both 
-- MemberId and MinistryId reference valid entries in their respective tables.
CREATE TABLE MemberMinistries
(
    -- Unique identifier for each record (auto-incremented)
    Id INT IDENTITY(1,1) PRIMARY KEY,

    -- ID of the member (required, links to the Members table)
    MemberId INT NOT NULL,

    -- ID of the ministry (required, links to the Ministries table)
    MinistryId INT NOT NULL,

    -- Ensures a member can only be assigned to a specific ministry once
    CONSTRAINT UQ_MemberMinistries_MemberId_MinistryId UNIQUE (MemberId, MinistryId),

    -- Foreign key constraint to ensure MemberId references a valid member
    CONSTRAINT FK_MemberMinistries_Members FOREIGN KEY (MemberId) REFERENCES Members(Id),

    -- Foreign key constraint to ensure MinistryId references a valid ministry
    CONSTRAINT FK_MemberMinistries_Ministries FOREIGN KEY (MinistryId) REFERENCES Ministries(Id)
);

-- The VolunteerMessages table stores messages sent by members
-- regarding volunteer activities. It includes the member ID, 
-- message text, and timestamp for when the message was sent, 
-- ensuring a record of communication between members and the
-- volunteer system.
CREATE TABLE VolunteerMessages
(
    -- Unique identifier for each message (auto-incremented)
    Id INT IDENTITY(1,1) PRIMARY KEY,

    -- ID of the member who sent the message (required, links to the Members table)
    MemberId INT NOT NULL,

    -- The actual message text (required, can be very long)
    MessageText NVARCHAR(MAX) NOT NULL,

    -- Timestamp for when the message was sent (required)
    SentAt DATETIME NOT NULL,

    -- Foreign key constraint to ensure MemberId references a valid member
    CONSTRAINT FK_VolunteerMessages_Members FOREIGN KEY (MemberId) REFERENCES Members(Id)
);
GO