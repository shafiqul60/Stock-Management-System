CREATE DATABASE StockManagementSystem

USE StockManagementSystem

CREATE TABLE LoginPanel

(
UserId int IDENTITY (1,1),
UserName varchar (50),
UserPassword varchar (50)

)

SELECT * FROM LoginPanel

INSERT INTO LoginPanel ( UserName, UserPassword) VALUES ('Shafiqul', 1993)
INSERT INTO LoginPanel ( UserName, UserPassword) VALUES ('User', 1234)