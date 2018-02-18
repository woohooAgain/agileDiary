CREATE TABLE [dbo].[Goal]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Title] TEXT NOT NULL, 
    [Description] TEXT NULL, 
    [Milestone] UNIQUEIDENTIFIER NOT NULL, 
    [Reason] TEXT NULL, 
    CONSTRAINT [FK_Goal_ToMilestone] FOREIGN KEY (Milestone) REFERENCES [Milestone](Id)
)
