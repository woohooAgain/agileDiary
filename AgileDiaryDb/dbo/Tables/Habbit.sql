CREATE TABLE [dbo].[Habbit] (
    [Id]     UNIQUEIDENTIFIER NOT NULL,
    [Chain]  INT              NOT NULL,
    [Total]  INT              NOT NULL,
    [Sprint] UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_Habbit] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Habbit_Sprint] FOREIGN KEY ([Sprint]) REFERENCES [dbo].[Sprint] ([Id])
);

