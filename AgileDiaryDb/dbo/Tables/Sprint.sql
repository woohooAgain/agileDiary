CREATE TABLE [dbo].[Sprint] (
    [Id]           UNIQUEIDENTIFIER NOT NULL,
    [Conclusion]   TEXT             NOT NULL,
    [Thanks]       TEXT             NOT NULL,
    [Improvements] TEXT             NOT NULL,
    [Reward]       TEXT             NOT NULL,
    [PerfectWeek]  UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_Sprint] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Sprint_Week] FOREIGN KEY ([PerfectWeek]) REFERENCES [dbo].[Week] ([Id])
);

