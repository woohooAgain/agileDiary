CREATE TABLE [dbo].[TaskForWeek] (
    [Task] UNIQUEIDENTIFIER NOT NULL,
    [Week] UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_TaskForWeek] PRIMARY KEY CLUSTERED ([Task] ASC, [Week] ASC),
    CONSTRAINT [FK_TaskForWeek_Task] FOREIGN KEY ([Task]) REFERENCES [dbo].[Task] ([Id]),
    CONSTRAINT [FK_TaskForWeek_Week] FOREIGN KEY ([Week]) REFERENCES [dbo].[Week] ([Id])
);

