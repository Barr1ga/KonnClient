IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Users] (
    [Id] int NOT NULL IDENTITY,
    [Email] nvarchar(max) NOT NULL,
    [Name] nvarchar(max) NOT NULL,
    [Image] nvarchar(max) NULL,
    [CreatedAt] datetime2 NOT NULL,
    [UpdatedAt] datetime2 NULL,
    [IsDeleted] bit NOT NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Workspaces] (
    [Id] int NOT NULL IDENTITY,
    [UserId] int NOT NULL,
    [Name] nvarchar(max) NOT NULL,
    [Description] nvarchar(max) NOT NULL,
    [Image] nvarchar(max) NULL,
    [IsDeleted] bit NOT NULL,
    [CreatedAt] datetime2 NOT NULL,
    [UpdatedAt] datetime2 NULL,
    CONSTRAINT [PK_Workspaces] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Workspaces_Users_UserId] FOREIGN KEY ([UserId]) REFERENCES [Users] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [Categories] (
    [Id] int NOT NULL IDENTITY,
    [WorkspaceId] int NOT NULL,
    [Name] nvarchar(max) NOT NULL,
    [Color] nvarchar(max) NOT NULL,
    [Description] nvarchar(max) NOT NULL,
    [IsDeleted] bit NOT NULL,
    [CreatedAt] datetime2 NOT NULL,
    [UpdatedAt] datetime2 NULL,
    CONSTRAINT [PK_Categories] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Categories_Workspaces_WorkspaceId] FOREIGN KEY ([WorkspaceId]) REFERENCES [Workspaces] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [Contacts] (
    [Id] int NOT NULL IDENTITY,
    [WorkspaceId] int NOT NULL,
    [Name] nvarchar(max) NOT NULL,
    [Pronounciation] nvarchar(max) NOT NULL,
    [Email] nvarchar(max) NOT NULL,
    [Phone] nvarchar(max) NOT NULL,
    [Telephone] nvarchar(max) NOT NULL,
    [Image] nvarchar(max) NULL,
    [Notes] nvarchar(max) NOT NULL,
    [IsFavorite] bit NOT NULL,
    [IsBlocked] bit NOT NULL,
    [IsEmergency] bit NOT NULL,
    [IsDeleted] bit NOT NULL,
    [LastOpenedAt] datetime2 NOT NULL,
    [CreatedAt] datetime2 NOT NULL,
    [UpdatedAt] datetime2 NULL,
    CONSTRAINT [PK_Contacts] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Contacts_Workspaces_WorkspaceId] FOREIGN KEY ([WorkspaceId]) REFERENCES [Workspaces] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [Addresses] (
    [Id] int NOT NULL IDENTITY,
    [ContactId] int NOT NULL,
    [FullName] nvarchar(max) NOT NULL,
    [IsDefault] bit NOT NULL,
    [CreatedAt] datetime2 NOT NULL,
    [UpdatedAt] datetime2 NULL,
    CONSTRAINT [PK_Addresses] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Addresses_Contacts_ContactId] FOREIGN KEY ([ContactId]) REFERENCES [Contacts] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [ContactCategories] (
    [Id] int NOT NULL IDENTITY,
    [ContactId] int NOT NULL,
    [CategoryId] int NOT NULL,
    CONSTRAINT [PK_ContactCategories] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_ContactCategories_Categories_CategoryId] FOREIGN KEY ([CategoryId]) REFERENCES [Categories] ([Id]),
    CONSTRAINT [FK_ContactCategories_Contacts_ContactId] FOREIGN KEY ([ContactId]) REFERENCES [Contacts] ([Id])
);
GO

CREATE INDEX [IX_Addresses_ContactId] ON [Addresses] ([ContactId]);
GO

CREATE INDEX [IX_Categories_WorkspaceId] ON [Categories] ([WorkspaceId]);
GO

CREATE INDEX [IX_ContactCategories_CategoryId] ON [ContactCategories] ([CategoryId]);
GO

CREATE INDEX [IX_ContactCategories_ContactId] ON [ContactCategories] ([ContactId]);
GO

CREATE INDEX [IX_Contacts_WorkspaceId] ON [Contacts] ([WorkspaceId]);
GO

CREATE INDEX [IX_Workspaces_UserId] ON [Workspaces] ([UserId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240730085838_InitialCreate', N'8.0.7');
GO

COMMIT;
GO

