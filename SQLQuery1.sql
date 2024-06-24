Create DataBase DepartamentDB
Use DepartamentDB

CREATE TABLE Departaments (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(150) NOT NULL,
    MaxEmployeeCount INT NOT NULL CHECK (MaxEmployeeCount >= 10 AND MaxEmployeeCount <= 50)
)

CREATE TABLE Positions (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(50) NOT NULL
)

CREATE TABLE Employees (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(60) DEFAULT 'Employee Name' NOT NULL,
    Surname NVARCHAR(70) DEFAULT 'Employee Surname' NULL,
    Salary DECIMAL(18,2) CHECK (Salary >= 500 AND Salary <= 12000)
)

Select * From Departaments
Select * From Positions
Select * From Employees

--Insert Into Departaments
--Values 
--(1, 'Eli Eliyev', 11),
--(2, 'Veli Veliyev', 49)

--Insert Into Positions
--Values
--(3, 'Eziz Qasimov', 34)

--Insert Into Employees
--Values
--(4, 'Rinat', 'Asgarov', 550)