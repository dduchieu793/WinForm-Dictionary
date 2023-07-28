--CREATE DATABASE [PRN211_Project]
--DROP DATABASE [PRN211_Project]
USE [PRN211_Project]

CREATE TABLE [User] (
[username] VARCHAR(20),
[password] VARCHAR(20),
[isAdmin] TINYINT DEFAULT 0,
PRIMARY KEY ([username])
)

CREATE TABLE [Type] (
[id] TINYINT IDENTITY(1,1),
[name] NVARCHAR(100),
PRIMARY KEY ([id])
)

CREATE TABLE [Word] (
[id] BIGINT IDENTITY(1,1),
[name] VARCHAR(100),
[meaning] VARCHAR(MAX),
[typeId] TINYINT,
[username] VARCHAR(20) DEFAULT NULL,
PRIMARY KEY ([id]),
FOREIGN KEY ([typeId]) REFERENCES [Type]([id])
)

CREATE TABLE [user_word] (
[username] VARCHAR(20),
[id] BIGINT,
PRIMARY KEY ([username],[id]),
FOREIGN KEY ([username]) REFERENCES [User]([username]),
FOREIGN KEY ([id]) REFERENCES [Word]([id])
)

CREATE TABLE [history] (
[username] VARCHAR(20),
[id] BIGINT,
[addtime] DATETIME,
PRIMARY KEY ([username],[id]),
FOREIGN KEY ([username]) REFERENCES [User]([username]),
FOREIGN KEY ([id]) REFERENCES [Word]([id])
)

CREATE TABLE [synonyms] (
[firstId] BIGINT,
[secondId] BIGINT,
[username] VARCHAR(20),
PRIMARY KEY ([firstId],[secondId]),
FOREIGN KEY ([firstId]) REFERENCES [Word]([id]),
FOREIGN KEY ([secondId]) REFERENCES [Word]([id])
)

