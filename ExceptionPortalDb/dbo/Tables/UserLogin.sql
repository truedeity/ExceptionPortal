CREATE TABLE [dbo].[UserLogin] (
    [UserLoginId]     INT              IDENTITY (1, 1) NOT NULL,
		[EntityGuid]	  uniqueidentifier not null default(newid()),
    [UserId]          INT              NOT NULL,
    [LoginProvider]   NVARCHAR (MAX)   NULL,
    [ProviderKey]     NVARCHAR (MAX)   NULL,
    [IsSuppressed]    BIT              CONSTRAINT [DF_UserLogin_IsSuppressed] DEFAULT ((0)) NOT NULL,
    [CreatedDt]       DATETIME         NOT NULL,
    [CreatedByUserId] INT              NOT NULL,
    [UpdatedDt]       DATETIME         NULL,
    [UpdatedByUserId] INT              NULL,
    [LastUpdateGuid]  UNIQUEIDENTIFIER DEFAULT (newid()) NOT NULL,
    CONSTRAINT [PK_UserLogins] PRIMARY KEY CLUSTERED ([UserLoginId] ASC),
    CONSTRAINT [FK_UserLogins_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[User] ([UserId]) ON DELETE CASCADE
);

