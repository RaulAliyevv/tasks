CREATE DATABASE DemoApp
USE DemoApp

CREATE TABLE People (
    Id INT PRIMARY KEY,
    Name VARCHAR(100) NOT NULL,
    Surname VARCHAR(100) NOT NULL,
    PhoneNumber VARCHAR(20) DEFAULT 'Not Provided',
    Email VARCHAR(100),
    Age INT,
    Gender CHAR(1) CHECK (Gender IN ('M', 'F')),
    HasCitizenship BIT,
    CountryId INT,
    CityId INT,
    FOREIGN KEY (CountryId) REFERENCES Countries(Id),
    FOREIGN KEY (CityId) REFERENCES Cities(Id)
)

CREATE TABLE Countries (
    Id INT PRIMARY KEY,
    Name VARCHAR(100) NOT NULL,
    Area DECIMAL(18, 2) NOT NULL
)

CREATE TABLE Cities (
    Id INT PRIMARY KEY,
    Name VARCHAR(100) NOT NULL,
    Area DECIMAL(18, 2) NOT NULL,
    CountryId INT,
    FOREIGN KEY (CountryId) REFERENCES Countries(Id)
)

CREATE VIEW vwPeopleDetails
AS
SELECT
    p.Id,
    p.Name,
    p.Surname,
    p.PhoneNumber,
    p.Email,
    p.Age,
    p.Gender,
    p.HasCitizenship,
    c.Name AS Country,
    ci.Name AS City
FROM
    People p
LEFT JOIN Countries c ON p.CountryId = c.Id
LEFT JOIN Cities ci ON p.CityId = ci.Id

SELECT *
FROM Countries
ORDER BY Area DESC

SELECT *
FROM Cities
ORDER BY Name ASC

SELECT COUNT(*)
FROM Countries
WHERE Area > 20000

SELECT TOP 1 Name, Area
FROM Countries
WHERE Name LIKE '?%'
ORDER BY Area DESC

SELECT Name, NULL AS Area FROM Countries
UNION
SELECT Name, NULL AS Area FROM Cities

SELECT CityId, COUNT(*) AS PersonCount
FROM People
GROUP BY CityId

SELECT CityId, COUNT(*) AS PersonCount
FROM People
GROUP BY CityId
HAVING COUNT(*) > 5

