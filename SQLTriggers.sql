Create DataBase PB201Task
Use PB201Task

CREATE TABLE Academies (
    Id INT PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL
)

CREATE TABLE Groups (
    Id INT PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    IsDeleted BIT NOT NULL DEFAULT 0,
    AcademyId INT,
    FOREIGN KEY (AcademyId) REFERENCES Academies(Id)
)

CREATE TABLE Students (
    Id INT PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    Surname NVARCHAR(100) NOT NULL,
    Age INT NOT NULL,
    Adulthood BIT NOT NULL DEFAULT 0,
    GroupId INT,
    FOREIGN KEY (GroupId) REFERENCES Groups(Id)
)

CREATE TABLE DeletedStudents (
    Id INT PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    Surname NVARCHAR(100) NOT NULL,
    GroupId INT,
    FOREIGN KEY (GroupId) REFERENCES Groups(Id)
)

CREATE TABLE DeletedGroups (
    Id INT PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    AcademyId INT,
    FOREIGN KEY (AcademyId) REFERENCES Academies(Id)
)

CREATE VIEW vw_AllData AS
SELECT 'Academy' AS TableType, Id, Name, NULL AS Surname, NULL AS Age, NULL AS Adulthood, NULL AS GroupId
FROM Academies
UNION ALL
SELECT 'Group', Id, Name, NULL, NULL, NULL, AcademyId
FROM Groups
UNION ALL
SELECT 'Student', Id, Name, Surname, Age, Adulthood, GroupId
FROM Students

CREATE PROCEDURE sp_GetGroupByName
    @GroupName NVARCHAR(100)
AS
BEGIN
    SELECT Id, Name, IsDeleted, AcademyId
    FROM Groups
    WHERE Name = @GroupName;
END

CREATE PROCEDURE sp_GetStudentsOlderThan
    @Age INT
AS
BEGIN
    SELECT Id, Name, Surname, Age, Adulthood, GroupId
    FROM Students
    WHERE Age > @Age;
END

CREATE PROCEDURE sp_GetStudentsYoungerThan
    @Age INT
AS
BEGIN
    SELECT Id, Name, Surname, Age, Adulthood, GroupId
    FROM Students
    WHERE Age < @Age;
END

CREATE TRIGGER trg_DeleteStudent
ON Students
AFTER DELETE
AS
BEGIN
    INSERT INTO DeletedStudents (Id, Name, Surname, GroupId)
    SELECT Id, Name, Surname, GroupId
    FROM deleted;
END

CREATE TRIGGER trg_DeleteGroup
ON Groups
INSTEAD OF DELETE
AS
BEGIN
    UPDATE g
    SET IsDeleted = 1
    OUTPUT deleted.Id, deleted.Name, deleted.AcademyId INTO DeletedGroups(Id, Name, AcademyId)
    FROM Groups g
    INNER JOIN deleted ON g.Id = deleted.Id;
END

CREATE TRIGGER trg_UpdateAdulthood
ON Students
AFTER INSERT, UPDATE
AS
BEGIN
    UPDATE s
    SET Adulthood = CASE
                        WHEN Age >= 18 THEN 1
                        ELSE 0
                    END
    FROM Students s
    INNER JOIN inserted i ON s.Id = i.Id;
END

CREATE FUNCTION dbo.fn_GetStudentsByGroupId
(
    @GroupId INT
)
RETURNS TABLE
AS
RETURN
(
    SELECT Id, Name, Surname, Age, Adulthood, GroupId
    FROM Students
    WHERE GroupId = @GroupId
)

CREATE FUNCTION dbo.fn_GetGroupsByAcademyId
(
    @AcademyId INT
)
RETURNS TABLE
AS
RETURN
(
    SELECT Id, Name, IsDeleted, AcademyId
    FROM Groups
    WHERE AcademyId = @AcademyId
)









