CREATE TABLE [dbo].[UserCd] (
    [UserCdId]        INT              NOT NULL,
	[EntityGuid]	  uniqueidentifier not null default(newid()),
    [UserCdName]      NVARCHAR (50)    NOT NULL,
    [IsSuppressed]    BIT              CONSTRAINT [DF_UserCd_IsSuppressed] DEFAULT ((0)) NOT NULL,
    [CreatedDt]       DATETIME         NOT NULL,
    [CreatedByUserId] INT              NOT NULL,
    [UpdatedDt]       DATETIME         NULL,
    [UpdatedByUserId] INT              NULL,
    [LastUpdateGuid]  UNIQUEIDENTIFIER DEFAULT (newid()) NOT NULL,
    CONSTRAINT [PK_UserCd] PRIMARY KEY CLUSTERED ([UserCdId] ASC) WITH (FILLFACTOR = 90)
);

