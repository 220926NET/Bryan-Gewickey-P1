CREATE TABLE Ticket (
    ticketID int IDENTITY(1, 1) PRIMARY KEY,
    subDate DATETIME,
    reason NVARCHAR(100),
    amount money,
    expDate DATE,
    userID NVARCHAR(100)
);

CREATE TABLE Users (
    username NVARCHAR(100),
    pass NVARCHAR(100) PRIMARY KEY,
    isManager BIT DEFAULT '0'
);

CREATE TABLE TicketVibe (
    resolved BIT PRIMARY KEY,
    approveDeny BIT,
    isManager BIT,
    managerInitial int
);

CREATE PROCEDURE sp_insertuser
(@name NVARCHAR(10), 
@pword NVARCHAR(10), 
@emp BIT = 0)
AS
BEGIN
INSERT INTO Users
(username, pass, isManager)
VALUES
(@name,
@pword,
@emp)
END


exec sp_insertuser
@name = 'tim',
@pword = 'greenday1';

SELECT * FROM Ticket;
SELECT * FROM Users;


INSERT INTO Users (username, pass, isManager) VALUES ('harrysmith', 'guesswho', 0);
INSERT INTO Users (username, pass, isManager) VALUES ('jimbean', 'number1', 1);
