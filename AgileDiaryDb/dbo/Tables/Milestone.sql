CREATE TABLE [dbo].[Milestone] (
    [Id]             UNIQUEIDENTIFIER NOT NULL,
    [Description]    TEXT             NOT NULL,
    [EstimationWeek] INT              NOT NULL,
    [Goal]           UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_Milestone] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Milestone_Goal] FOREIGN KEY ([Goal]) REFERENCES [dbo].[Goal] ([Id])
);

