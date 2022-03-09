CREATE TABLE [dbo].[Table]
(
	[ProductID] INT NOT NULL PRIMARY KEY, 
    [ProductName] VARCHAR(100) NOT NULL, 
    [Quantity] INT NOT NULL, 
    [Price] NUMERIC NOT NULL, 
    [Description] NCHAR(1000) NULL, 
    [UPC] VARCHAR(50) NOT NULL
)
