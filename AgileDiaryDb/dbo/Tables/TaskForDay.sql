CREATE TABLE [dbo].[TaskForDay] (
    [Task] UNIQUEIDENTIFIER NOT NULL,
    [Day]  UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_TaskForDay] PRIMARY KEY CLUSTERED ([Task] ASC, [Day] ASC),
    CONSTRAINT [FK_TaskForDay_Day] FOREIGN KEY ([Day]) REFERENCES [dbo].[Day] ([Id]),
    CONSTRAINT [FK_TaskForDay_Task] FOREIGN KEY ([Task]) REFERENCES [dbo].[Task] ([Id])
);

