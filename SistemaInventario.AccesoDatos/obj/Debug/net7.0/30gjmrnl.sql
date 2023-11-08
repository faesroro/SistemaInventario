BEGIN TRANSACTION;
GO

CREATE TABLE [Categorias] (
    [Id] int NOT NULL IDENTITY,
    [Nombre] nvarchar(60) NOT NULL,
    [Descripcion] nvarchar(100) NOT NULL,
    [Estado] bit NOT NULL,
    CONSTRAINT [PK_Categorias] PRIMARY KEY ([Id])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20231107162008_AgregarCategoriaMigracion', N'7.0.13');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Bodegas] (
    [Id] int NOT NULL IDENTITY,
    [Nombre] nvarchar(60) NOT NULL,
    [Descripcion] nvarchar(100) NOT NULL,
    [Estado] bit NOT NULL,
    CONSTRAINT [PK_Bodegas] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Categorias] (
    [Id] int NOT NULL IDENTITY,
    [Nombre] nvarchar(60) NOT NULL,
    [Descripcion] nvarchar(100) NOT NULL,
    [Estado] bit NOT NULL,
    CONSTRAINT [PK_Categorias] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Marcas] (
    [Id] int NOT NULL IDENTITY,
    [Nombre] nvarchar(60) NOT NULL,
    [Descripcion] nvarchar(100) NOT NULL,
    [Estado] bit NOT NULL,
    CONSTRAINT [PK_Marcas] PRIMARY KEY ([Id])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20231107221530_AgregarMarcaMigracion', N'7.0.13');
GO

COMMIT;
GO

