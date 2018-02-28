﻿CREATE TABLE [dbo].[Day] (
    [Id]           UNIQUEIDENTIFIER NOT NULL,
    [Achievements] TEXT             NULL,
    [Thanks]       TEXT             NULL,
    [Week]         UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_Day] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Day_Week] FOREIGN KEY ([Week]) REFERENCES [dbo].[Week] ([Id])
);



