CREATE TABLE [dbo].[AspNetUserTokens] (
    [UserId]        NVARCHAR (450) NOT NULL,
    [LoginProvider] NVARCHAR (450) NOT NULL,
    [Name]          NVARCHAR (450) NOT NULL,
    [Value]         NVARCHAR (MAX) NULL,
	[IsSuppressed]    BIT              CONSTRAINT [DF_AspNetUserTokens_IsSuppressed] DEFAULT ((0)) NOT NULL,
    [CreatedDt]       DATETIME         NOT NULL,
    [CreatedByUserId] INT              NOT NULL,
    [UpdatedDt]       DATETIME         NULL,
    [UpdatedByUserId] INT              NULL,
    [LastUpdateGuid]  UNIQUEIDENTIFIER DEFAULT (newid()) NOT NULL,
	[EntityGuid]			UNIQUEIDENTIFIER NOT NULL DEFAULT(NEWID()),
    CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED ([UserId] ASC, [LoginProvider] ASC, [Name] ASC)
);

