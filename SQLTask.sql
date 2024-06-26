Create DataBase Library
Use Library

CREATE TABLE Authors (
    Id INT PRIMARY KEY,
    Name NVARCHAR(100),
    Surname NVARCHAR(100)
)

CREATE TABLE Books (
    Id INT PRIMARY KEY,
    Name NVARCHAR(100),
    AuthorId INT FOREIGN KEY REFERENCES Authors(Id),
    PageCount INT,
    CostPrice DECIMAL(10, 2),  
    SalePrice DECIMAL(10, 2)   
)

CREATE TABLE Tags (
    Id INT PRIMARY KEY,
    Name NVARCHAR(100)
)

CREATE TABLE BooksTags (
    BookId INT,
    TagId INT,
    PRIMARY KEY (BookId, TagId),
    FOREIGN KEY (BookId) REFERENCES Books(Id),
    FOREIGN KEY (TagId) REFERENCES Tags(Id)
)

INSERT INTO Authors (Id, Name, Surname)
VALUES
    (1, 'Tunar', 'Aliyev'),
    (2, 'Rinat', 'Asgarov')

INSERT INTO Books (Id, Name, AuthorId, PageCount, CostPrice, SalePrice)
VALUES
    (1, 'Book One', 1, 200, 12.99, 27.99),
    (2, 'Book Two', 2, 150, 15.50, 16.99)

INSERT INTO Tags (Id, Name)
VALUES
    (1, 'BestSeller'),
    (2, 'Featured'),
    (3, 'New')

INSERT INTO BooksTags (BookId, TagId)
VALUES
    (1, 1),  
    (1, 2),  
    (2, 2),  
    (2, 3)

CREATE VIEW BookDetails AS
SELECT b.Id AS BookId,
       CONCAT(a.Name, ' ', a.Surname) AS AuthorFullName,
       b.Name AS BookName,
       b.SalePrice AS BookPrice,
       b.PageCount,
       t.Name AS TagName
FROM Books b
JOIN Authors a ON b.AuthorId = a.Id
JOIN BooksTags bt ON b.Id = bt.BookId
JOIN Tags t ON bt.TagId = t.Id

SELECT * FROM BookDetails









