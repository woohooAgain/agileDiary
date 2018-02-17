﻿CREATE TABLE [dbo].[Task]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [StartTime] DATETIME NOT NULL, 
    [EndTime] DATETIME NOT NULL, 
    [Title] TEXT NOT NULL
)
