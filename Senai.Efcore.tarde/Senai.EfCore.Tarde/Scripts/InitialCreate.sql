IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Alunos] (
    [Id] uniqueidentifier NOT NULL,
    [Nome] nvarchar(max) NULL,
    [DataNasc] datetime2 NOT NULL,
    CONSTRAINT [PK_Alunos] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [Escolas] (
    [Id] uniqueidentifier NOT NULL,
    [Nome] nvarchar(max) NULL,
    CONSTRAINT [PK_Escolas] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [EscolasAlunos] (
    [Id] uniqueidentifier NOT NULL,
    [IdEscola] uniqueidentifier NOT NULL,
    [IdAluno] uniqueidentifier NOT NULL,
    CONSTRAINT [PK_EscolasAlunos] PRIMARY KEY ([Id])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200909014742_InitialCreate', N'3.1.8');

GO

