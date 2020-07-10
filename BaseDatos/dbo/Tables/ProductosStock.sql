CREATE TABLE [dbo].[ProductosStock] (
    [Id]          NVARCHAR (450) NOT NULL,
    [SucursalId]  NVARCHAR (450) NULL,
    [UbicacionId] NVARCHAR (450) NULL,
    [ProductoId]  NVARCHAR (450) NULL,
    [ColorId]     NVARCHAR (450) NULL,
    [TalleId]     NVARCHAR (450) NULL,
    [Cantidad]    NUMERIC (10)   NULL,
    CONSTRAINT [PK_ProductosStock] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_ProductosStock_ParamColores] FOREIGN KEY ([ColorId]) REFERENCES [dbo].[ParamColores] ([Id]),
    CONSTRAINT [FK_ProductosStock_Productos] FOREIGN KEY ([ProductoId]) REFERENCES [dbo].[Productos] ([Id]),
    CONSTRAINT [FK_ProductosStock_Sucursales] FOREIGN KEY ([SucursalId]) REFERENCES [dbo].[Sucursales] ([Id]),
    CONSTRAINT [FK_ProductosStock_Ubicaciones] FOREIGN KEY ([UbicacionId]) REFERENCES [dbo].[Ubicaciones] ([Id])
);

