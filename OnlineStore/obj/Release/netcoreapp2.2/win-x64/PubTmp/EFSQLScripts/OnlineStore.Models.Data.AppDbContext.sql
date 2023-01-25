IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200623195330_CreateDb')
BEGIN
    CREATE TABLE [Categories] (
        [CatId] int NOT NULL IDENTITY,
        [Description] nvarchar(max) NULL,
        CONSTRAINT [PK_Categories] PRIMARY KEY ([CatId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200623195330_CreateDb')
BEGIN
    CREATE TABLE [Customers] (
        [CustId] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        [Address] nvarchar(max) NULL,
        [Mob1] nvarchar(max) NULL,
        [Mob2] nvarchar(max) NULL,
        CONSTRAINT [PK_Customers] PRIMARY KEY ([CustId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200623195330_CreateDb')
BEGIN
    CREATE TABLE [Transports] (
        [TransId] int NOT NULL IDENTITY,
        [Country] nvarchar(max) NULL,
        [Cost] decimal(18,2) NOT NULL,
        CONSTRAINT [PK_Transports] PRIMARY KEY ([TransId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200623195330_CreateDb')
BEGIN
    CREATE TABLE [Users] (
        [UserId] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        [UserName] nvarchar(max) NULL,
        [Password] nvarchar(max) NULL,
        [Phone] nvarchar(max) NULL,
        [Kind] nvarchar(max) NULL,
        CONSTRAINT [PK_Users] PRIMARY KEY ([UserId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200623195330_CreateDb')
BEGIN
    CREATE TABLE [Products] (
        [ProdID] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        [Price] decimal(18,2) NOT NULL,
        [Qut] int NOT NULL,
        [CategoryCatId] int NULL,
        CONSTRAINT [PK_Products] PRIMARY KEY ([ProdID]),
        CONSTRAINT [FK_Products_Categories_CategoryCatId] FOREIGN KEY ([CategoryCatId]) REFERENCES [Categories] ([CatId]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200623195330_CreateDb')
BEGIN
    CREATE TABLE [Logins] (
        [LogId] int NOT NULL IDENTITY,
        [UserId] int NULL,
        [LoginTime] datetime2 NOT NULL,
        CONSTRAINT [PK_Logins] PRIMARY KEY ([LogId]),
        CONSTRAINT [FK_Logins_Users_UserId] FOREIGN KEY ([UserId]) REFERENCES [Users] ([UserId]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200623195330_CreateDb')
BEGIN
    CREATE TABLE [Orders] (
        [OrderId] int NOT NULL IDENTITY,
        [CustomerCustId] int NULL,
        [ProductProdID] int NULL,
        [TransportTransId] int NULL,
        [UserId] int NULL,
        [Size] nvarchar(max) NULL,
        [Note] nvarchar(max) NULL,
        [Total] decimal(18,2) NOT NULL,
        [OrderDate] datetime2 NOT NULL,
        [Comfirm] nvarchar(max) NULL,
        CONSTRAINT [PK_Orders] PRIMARY KEY ([OrderId]),
        CONSTRAINT [FK_Orders_Customers_CustomerCustId] FOREIGN KEY ([CustomerCustId]) REFERENCES [Customers] ([CustId]) ON DELETE NO ACTION,
        CONSTRAINT [FK_Orders_Products_ProductProdID] FOREIGN KEY ([ProductProdID]) REFERENCES [Products] ([ProdID]) ON DELETE NO ACTION,
        CONSTRAINT [FK_Orders_Transports_TransportTransId] FOREIGN KEY ([TransportTransId]) REFERENCES [Transports] ([TransId]) ON DELETE NO ACTION,
        CONSTRAINT [FK_Orders_Users_UserId] FOREIGN KEY ([UserId]) REFERENCES [Users] ([UserId]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200623195330_CreateDb')
BEGIN
    CREATE INDEX [IX_Logins_UserId] ON [Logins] ([UserId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200623195330_CreateDb')
BEGIN
    CREATE INDEX [IX_Orders_CustomerCustId] ON [Orders] ([CustomerCustId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200623195330_CreateDb')
BEGIN
    CREATE INDEX [IX_Orders_ProductProdID] ON [Orders] ([ProductProdID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200623195330_CreateDb')
BEGIN
    CREATE INDEX [IX_Orders_TransportTransId] ON [Orders] ([TransportTransId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200623195330_CreateDb')
BEGIN
    CREATE INDEX [IX_Orders_UserId] ON [Orders] ([UserId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200623195330_CreateDb')
BEGIN
    CREATE INDEX [IX_Products_CategoryCatId] ON [Products] ([CategoryCatId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200623195330_CreateDb')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200623195330_CreateDb', N'2.2.6-servicing-10079');
END;

GO

