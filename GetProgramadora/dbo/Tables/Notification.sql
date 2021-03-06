﻿CREATE TABLE [dbo].[Notification] (
    [Id]        UNIQUEIDENTIFIER NOT NULL,
    [CreatedAt] DATETIME2 (7)    DEFAULT (getdate()) NOT NULL,
    [DeletedAt] DATETIME2 (7)    NULL,
    [Link]      NVARCHAR (MAX)   NOT NULL,
    [Title]     NVARCHAR (150)   NOT NULL,
    [UpdatedAt] DATETIME2 (7)    DEFAULT (getdate()) NOT NULL,
    [UserId]    UNIQUEIDENTIFIER NOT NULL,
    [ViewAt]    DATETIME2 (7)    NULL,
    CONSTRAINT [PK_Notification] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Notification_User_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[User] ([Id]) ON DELETE CASCADE
);






GO
CREATE NONCLUSTERED INDEX [IX_Notification_UserId]
    ON [dbo].[Notification]([UserId] ASC);

