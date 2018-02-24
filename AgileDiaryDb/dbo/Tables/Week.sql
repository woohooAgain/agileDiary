CREATE TABLE [dbo].[Week] (
    [Id]         UNIQUEIDENTIFIER NOT NULL,
    [Conclusion] TEXT             NOT NULL,
    [Thanks]     TEXT             NOT NULL,
    [Sprint]     UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_Week] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Week_Sprint] FOREIGN KEY ([Sprint]) REFERENCES [dbo].[Sprint] ([Id])
);

