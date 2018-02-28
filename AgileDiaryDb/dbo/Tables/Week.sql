CREATE TABLE [dbo].[Week] (
    [Id]         UNIQUEIDENTIFIER NOT NULL,
    [Conclusion] TEXT             NULL,
    [Thanks]     TEXT             NULL,
    [Sprint]     UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_Week] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Week_Sprint] FOREIGN KEY ([Sprint]) REFERENCES [dbo].[Sprint] ([Id])
);



