--create database seproject

use seproject

CREATE TABLE Users (
    UserID INT IDENTITY PRIMARY KEY,
    Email VARCHAR(255) NOT NULL UNIQUE,
    MemberName VARCHAR(255) NOT NULL,
    RollNo VARCHAR(50)  UNIQUE,
    Password VARCHAR(255) NOT NULL
    -- Other user attributes as necessary
);

CREATE TABLE Societies (
    SocietyID INT IDENTITY PRIMARY KEY,
    Name VARCHAR(255) NOT NULL,
    Bio VARCHAR(255) NOT NULL,
    Description VARCHAR(MAX),
    PresidentUserID INT,
    CONSTRAINT FK_Societies_PresidentUserID FOREIGN KEY (PresidentUserID) REFERENCES Users(UserID)
    -- This foreign key links to the Users table to identify the Society President
);

CREATE TABLE Memberships (
    UserID INT,
    SocietyID INT,
    Role VARCHAR(255) NOT NULL DEFAULT 'Member',
    CONSTRAINT PK_Memberships PRIMARY KEY (UserID, SocietyID),
    CONSTRAINT FK_Memberships_UserID FOREIGN KEY (UserID) REFERENCES Users(UserID),
    CONSTRAINT FK_Memberships_SocietyID FOREIGN KEY (SocietyID) REFERENCES Societies(SocietyID),
    CONSTRAINT CHK_Role CHECK (Role IN ('President', 'Member'))
    -- Check constraint to enforce the allowed values for Role
);

CREATE TABLE Announcements (
    AnnouncementID INT IDENTITY PRIMARY KEY,
    SocietyID INT,
    PostedByUserID INT,
    Title VARCHAR(255) NOT NULL,
    Content VARCHAR(MAX) NOT NULL,
    DatePosted DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    CONSTRAINT FK_Announcements_SocietyID FOREIGN KEY (SocietyID) REFERENCES Societies(SocietyID),
    CONSTRAINT FK_Announcements_PostedByUserID FOREIGN KEY (PostedByUserID) REFERENCES Users(UserID)
);

CREATE TABLE Events (
    EventID INT IDENTITY PRIMARY KEY,
    SocietyID INT,
    CreatedByUserID INT,
    Name VARCHAR(255) NOT NULL,
    Description VARCHAR(MAX) NOT NULL,
    EventDate DATETIME,
    Location VARCHAR(255),
    CONSTRAINT FK_Events_SocietyID FOREIGN KEY (SocietyID) REFERENCES Societies(SocietyID),
    CONSTRAINT FK_Events_CreatedByUserID FOREIGN KEY (CreatedByUserID) REFERENCES Users(UserID)
);

CREATE TABLE Tickets (
    TicketID INT IDENTITY PRIMARY KEY,
    EventID INT,
    UserID INT,
    IssueDate DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    IsValid BIT NOT NULL DEFAULT 1,
    CONSTRAINT FK_Tickets_EventID FOREIGN KEY (EventID) REFERENCES Events(EventID),
    CONSTRAINT FK_Tickets_UserID FOREIGN KEY (UserID) REFERENCES Users(UserID)
);

CREATE TABLE Admins (
    AdminID INT IDENTITY PRIMARY KEY,
    UserID INT,
    CONSTRAINT FK_Admins_UserID FOREIGN KEY (UserID) REFERENCES Users(UserID)
);

select *from Users
select *from Admins
select *from Societies
select *from Memberships

INSERT INTO Users (Email, MemberName, RollNo, Password)
VALUES ('user@example.com', 'John Doe', '12345', 'userPassword123');

ALTER TABLE Users
ADD Role VARCHAR(50) NULL,
CONSTRAINT CHK_Users_Role CHECK (Role IN ('President', 'Member') OR Role IS NULL);

