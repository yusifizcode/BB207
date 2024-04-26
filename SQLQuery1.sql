CREATE DATABASE CARGOBB207
USE CARGOBB207


CREATE TABLE Suppliers(
	Id INT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(50),
	Phone NVARCHAR(20)
)




CREATE TABLE Categories(
	Id INT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(50),
	TopCategoryId INT FOREIGN KEY REFERENCES Categories(Id)
)

CREATE TABLE Products(
	Id INT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(50),
	CategoryId INT FOREIGN KEY REFERENCES Categories(Id)
)

CREATE TABLE SupplierProducts(
	Id INT PRIMARY KEY IDENTITY,
	SupplierId INT FOREIGN KEY REFERENCES Suppliers(Id),
	ProductId INT FOREIGN KEY REFERENCES Products(Id),
	Price DECIMAL(18,2),
	StockQuantity INT
)


CREATE TABLE Orders(
	Id INT PRIMARY KEY IDENTITY,
	OrderDate NVARCHAR(20),
	TotalAmount DECIMAL(18,2),
	IsDeleted BIT 
)


CREATE TABLE OrderDetails(
	Id INT PRIMARY KEY IDENTITY,
	ProductId INT FOREIGN KEY REFERENCES Products(Id),
	OrderId INT FOREIGN KEY REFERENCES Orders(Id),
	Quantity INT,
	Price DECIMAL(18,2)
)

CREATE VIEW VW_GetProductsByCategory
AS
SELECT P.Name, C.Name as 'Category Name' FROM Products P
JOIN Categories C
ON P.CategoryId = C.Id

SELECT * FROM VW_GetProductsByCategory


CREATE VIEW VW_GetOrderDetailsByProduct
AS
SELECT P.Name, O.OrderId, O.Price, O.Quantity FROM OrderDetails O
JOIN Products P
ON O.ProductId = P.Id

SELECT * FROM VW_GetOrderDetailsByProduct


ALTER PROCEDURE USP_GetOrderDetailsByProductId @productId INT
AS
SELECT * FROM OrderDetails O
JOIN Products P
ON O.ProductId = P.Id
WHERE O.ProductId = @productId

EXEC USP_GetOrderDetailsByProductId 2


CREATE PROCEDURE USP_GetCategoriesByProductId @categoryId INT
AS
SELECT * FROM Products P
JOIN Categories C
ON P.CategoryId = C.Id
WHERE P.CategoryId = @categoryId


EXEC USP_GetCategoriesByProductId 9

CREATE FUNCTION UFN_GetOrderCount(@orderId INT)
RETURNS INT
BEGIN
	DECLARE @Count INT;
	SELECT @Count = Count(*) FROM OrderDetails 
	WHERE OrderDetails.OrderId = @orderId
	RETURN @Count
END

SELECT dbo.UFN_GetOrderCount(1) AS 'Count'


CREATE FUNCTION UFN_GetOrdersTable(@orderId INT)
RETURNS TABLE
	RETURN (
		SELECT * FROM Orders O
		WHERE O.Id = @orderId
	)

SELECT * FROM dbo.UFN_GetOrdersTable(4) 


CREATE TRIGGER TRGR_UpdateOrder
ON Orders
INSTEAD OF DELETE
AS
BEGIN
	UPDATE Orders SET IsDeleted = 1
	FROM deleted
	WHERE deleted.Id = Orders.Id
END

SELECT * FROM Orders

DELETE FROM Orders
WHERE Id = 3