CREATE TABLE [dbo].[AspNetUserClaims] (
    [Id]         INT            IDENTITY (1, 1) NOT NULL,
    [ClaimType]  NVARCHAR (MAX) NULL,
    [ClaimValue] NVARCHAR (MAX) NULL,
    [UserId]     NVARCHAR (450) NOT NULL,
	[IsSuppressed]    BIT              CONSTRAINT [DF_AspNetUserClaims_IsSuppressed] DEFAULT ((0)) NOT NULL,
    [CreatedDt]       DATETIME         NOT NULL,
    [CreatedByUserId] INT              NOT NULL,
    [UpdatedDt]       DATETIME         NULL,
    [UpdatedByUserId] INT              NULL,
    [LastUpdateGuid]  UNIQUEIDENTIFIER DEFAULT (newid()) NOT NULL,
	[EntityGuid]			UNIQUEIDENTIFIER NOT NULL DEFAULT(NEWID()),
    CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[AspNetUsers] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_AspNetUserClaims_UserId]
    ON [dbo].[AspNetUserClaims]([UserId] ASC);

