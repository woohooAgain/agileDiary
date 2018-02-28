CREATE TABLE [dbo].[Sprint] (
    [Id]           UNIQUEIDENTIFIER NOT NULL,
    [Conclusion]   TEXT             NULL,
    [Thanks]       TEXT             NULL,
    [Improvements] TEXT             NULL,
    [Reward]       TEXT             NULL,
    CONSTRAINT [PK_Sprint] PRIMARY KEY CLUSTERED ([Id] ASC)
);



