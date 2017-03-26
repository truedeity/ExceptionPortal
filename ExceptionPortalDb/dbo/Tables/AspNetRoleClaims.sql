CREATE TABLE [dbo].[AspNetRoleClaims] (
    [Id]         INT            IDENTITY (1, 1) NOT NULL,
    [ClaimType]  NVARCHAR (MAX) NULL,
    [ClaimValue] NVARCHAR (MAX) NULL,
    [RoleId]     NVARCHAR (450) NOT NULL,
	[IsSuppressed]    BIT              CONSTRAINT [DF_AspNetRoleClaims_IsSuppressed] DEFAULT ((0)) NOT NULL,
    [CreatedDt]       DATETIME         NOT NULL,
    [CreatedByUserId] INT              NOT NULL,
    [UpdatedDt]       DATETIME         NULL,
    [UpdatedByUserId] INT              NULL,
    [LastUpdateGuid]  UNIQUEIDENTIFIER DEFAULT (newid()) NOT NULL,
	[EntityGuid]			UNIQUEIDENTIFIER NOT NULL DEFAULT(NEWID()),
    CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [dbo].[AspNetRoles] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_AspNetRoleClaims_RoleId]
    ON [dbo].[AspNetRoleClaims]([RoleId] ASC);

