CREATE TABLE [dbo].[Result]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [GoalResult] UNIQUEIDENTIFIER NOT NULL, 
    [ResultDescription] UNIQUEIDENTIFIER NOT NULL, 
    CONSTRAINT [FK_Result_ToGoalResult] FOREIGN KEY (GoalResult) REFERENCES [GoalResult](Id), 
    CONSTRAINT [FK_Result_ToResultDescription] FOREIGN KEY (ResultDescription) REFERENCES [ResultDescription](Id)
)
