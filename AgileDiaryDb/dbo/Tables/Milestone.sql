CREATE TABLE [dbo].[Milestone] (
    [Id]             UNIQUEIDENTIFIER NOT NULL,
    [Description]    TEXT             NULL,
    [EstimationWeek] INT              NULL,
    [Goal]           UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_Milestone] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Milestone_Goal] FOREIGN KEY ([Goal]) REFERENCES [dbo].[Goal] ([Id])
);



