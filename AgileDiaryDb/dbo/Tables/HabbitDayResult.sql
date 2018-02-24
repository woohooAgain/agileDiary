CREATE TABLE [dbo].[HabbitDayResult] (
    [Habbit] UNIQUEIDENTIFIER NOT NULL,
    [Day]    UNIQUEIDENTIFIER NOT NULL,
    [Done]   BIT              NULL,
    CONSTRAINT [PK_HabbitDayResult] PRIMARY KEY CLUSTERED ([Habbit] ASC, [Day] ASC),
    CONSTRAINT [FK_HabbitDayResult_Day] FOREIGN KEY ([Day]) REFERENCES [dbo].[Day] ([Id]),
    CONSTRAINT [FK_HabbitDayResult_Habbit] FOREIGN KEY ([Habbit]) REFERENCES [dbo].[Habbit] ([Id])
);

