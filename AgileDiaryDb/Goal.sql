CREATE TABLE [dbo].[Goal]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Title] TEXT NOT NULL, 
    [Description] TEXT NULL, 
    [Milestone] UNIQUEIDENTIFIER NOT NULL, 
    [Reason] TEXT NOT NULL
)
