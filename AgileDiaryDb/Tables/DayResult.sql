﻿CREATE TABLE [dbo].[DayResult]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY , 
    [ExerciseTime] DECIMAL NOT NULL DEFAULT 0, 
    [Mood] SMALLINT NOT NULL DEFAULT 0, 
    [SleepTime] DECIMAL NOT NULL DEFAULT 0, 
    [WaterGlases] SMALLINT NOT NULL DEFAULT 0, 
    [HabbitResult] UNIQUEIDENTIFIER NOT NULL, 
    CONSTRAINT [FK_DayResult_ToHabbitDayResult] FOREIGN KEY (HabbitResult) REFERENCES [HabbitDayResult](Id)
)
