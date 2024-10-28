CREATE DATABASE LaptopStoreDB;
USE LaptopStoreDB;

CREATE TABLE Products (
    ProductId INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(100),
    Description NVARCHAR(255),
    Price DECIMAL(18, 2),
    Stock INT,
    ImageUrl NVARCHAR(255)
);