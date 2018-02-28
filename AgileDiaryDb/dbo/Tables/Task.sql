CREATE TABLE [dbo].[Task] (
    [Id]          UNIQUEIDENTIFIER NOT NULL,
    [Description] TEXT             NULL,
    [StartTime]   DATETIME         NULL,
    [EndTime]     DATETIME         NULL,
    [Goal]        UNIQUEIDENTIFIER NULL,
    [Result]      TEXT             NULL,
    [IsPrimary]   BIT              NULL,
    CONSTRAINT [PK_Task] PRIMARY KEY CLUSTERED ([Id] ASC)
);



