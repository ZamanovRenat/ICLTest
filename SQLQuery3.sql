CREATE TABLE Product
(
    Id INT PRIMARY KEY IDENTITY,
    ProductName NVARCHAR(100) NOT NULL,
    Price MONEY,
	Description NVARCHAR(MAX)
);

CREATE TABLE Storage 
(
	Id INT PRIMARY KEY IDENTITY,
	ProductId INT REFERENCES Product (Id), 
	City NVARCHAR(20),
	Address NVARCHAR(100)
);

SELECT * FROM Storage
WHERE ProductId = VAR

SELECT COUNT(ProductId) FROM Storage WHERE ProductId = VAR

SELECT ProductId FROM Storage WHERE City = VAR

SELECT TOP 1 * FROM Storage
ORDER BY COUNT(ProductId = VAR) 
