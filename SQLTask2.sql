Create DataBase LibraryBook
Use LibraryBook

CREATE TABLE Authors (
    Id INT PRIMARY KEY,
    Name VARCHAR(100),
    Surname VARCHAR(100)
)

CREATE TABLE Books (
    Id INT PRIMARY KEY,
    Name VARCHAR(100),
    AuthorId INT,
    PageCount INT,
    FOREIGN KEY (AuthorId) REFERENCES Authors(Id)
)

CREATE VIEW BooksAuthorsView AS
SELECT
    b.Id AS BookId,
    b.Name AS BookName,
    b.PageCount,
    CONCAT(a.Name, ' ', a.Surname) AS AuthorFullName
FROM
    Books b
INNER JOIN Authors a ON b.AuthorId = a.Id

CREATE PROCEDURE SearchBooksByTerm
    @searchTerm VARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON

    SELECT
        b.Id AS BookId,
        b.Name AS BookName,
        b.PageCount,
        CONCAT(a.Name, ' ', a.Surname) AS AuthorFullName
    FROM
        Books b
    INNER JOIN Authors a ON b.AuthorId = a.Id
    WHERE
        b.Name LIKE '%' + @searchTerm + '%'
        OR CONCAT(a.Name, ' ', a.Surname) LIKE '%' + @searchTerm + '%';
END

CREATE VIEW AuthorsView AS
SELECT
    a.Id AS AuthorId,
    CONCAT(a.Name, ' ', a.Surname) AS FullName,
    COUNT(b.Id) AS BooksCount,
    MAX(b.PageCount) AS MaxPageCount
FROM
    Authors a
LEFT JOIN Books b ON a.Id = b.AuthorId
GROUP BY
    a.Id, a.Name, a.Surname



