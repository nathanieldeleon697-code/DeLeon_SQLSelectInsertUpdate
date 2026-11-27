-- Run in SQL Server Object Explorer against .\SQLEXPRESS.
-- The application also attempts to create ClubDB and this table if missing.
USE master;
GO
IF DB_ID(N'ClubDB') IS NULL CREATE DATABASE ClubDB;
GO
USE ClubDB;
GO
IF OBJECT_ID(N'dbo.ClubMembers', N'U') IS NULL
CREATE TABLE dbo.ClubMembers (
    ID INT NOT NULL PRIMARY KEY,
    StudentId BIGINT NOT NULL UNIQUE,
    FirstName VARCHAR(50) NOT NULL,
    MiddleName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    Age INT NOT NULL CHECK (Age BETWEEN 1 AND 120),
    Gender VARCHAR(50) NOT NULL,
    Program VARCHAR(50) NOT NULL
);
GO
SELECT StudentId, FirstName, MiddleName, LastName, Age, Gender, Program
FROM dbo.ClubMembers ORDER BY ID;
