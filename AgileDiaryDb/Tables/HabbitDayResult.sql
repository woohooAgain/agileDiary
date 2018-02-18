CREATE TABLE [dbo].[HabbitDayResult]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Habbit] UNIQUEIDENTIFIER NOT NULL, 
    [Result] BIT NOT NULL, 
    CONSTRAINT [FK_HabbitDayResult_ToHabbit] FOREIGN KEY (Habbit) REFERENCES [Habbit](Id)
)
