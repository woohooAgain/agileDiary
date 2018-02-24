CREATE TABLE [dbo].[Goal] (
    [Id]          UNIQUEIDENTIFIER NOT NULL,
    [Reason]      TEXT             NOT NULL,
    [Result]      TEXT             NOT NULL,
    [Description] TEXT             NOT NULL,
    [Sprint]      UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_Goal] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Goal_Sprint] FOREIGN KEY ([Sprint]) REFERENCES [dbo].[Sprint] ([Id])
);

