CREATE TABLE [dbo].[ProductosColores] (
    [Id]         NVARCHAR (450) NOT NULL,
    [ProductoId] NVARCHAR (450) NULL,
    [ColorId]    NVARCHAR (450) NULL,
    CONSTRAINT [PK_ProductosColores] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_ProductosColores_ParamColores] FOREIGN KEY ([ColorId]) REFERENCES [dbo].[ParamColores] ([Id]),
    CONSTRAINT [FK_ProductosColores_Productos] FOREIGN KEY ([ProductoId]) REFERENCES [dbo].[Productos] ([Id])
);

