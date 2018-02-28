CREATE TABLE [dbo].[Goal] (
    [Id]          UNIQUEIDENTIFIER NOT NULL,
    [Reason]      TEXT             NULL,
    [Result]      TEXT             NULL,
    [Description] TEXT             NULL,
    [Sprint]      UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_Goal] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Goal_Sprint] FOREIGN KEY ([Sprint]) REFERENCES [dbo].[Sprint] ([Id])
);



