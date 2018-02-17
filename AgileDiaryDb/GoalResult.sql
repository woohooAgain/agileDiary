CREATE TABLE [dbo].[GoalResult]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Goal] UNIQUEIDENTIFIER NOT NULL, 
    [Result] TEXT NOT NULL
)
