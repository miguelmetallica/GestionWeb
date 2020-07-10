CREATE TABLE [dbo].[ProductosPrecios] (
    [Id]             NVARCHAR (450)  NOT NULL,
    [ProductoId]     NVARCHAR (450)  NULL,
    [Precio]         NUMERIC (18, 2) NULL,
    [PrecioRebajado] NUMERIC (18, 2) NULL,
    [FechaHasta]     DATETIME        NULL,
    [Estado]         BIT             NULL,
    [FechaProceso]   DATETIME        NULL,
    [UsuarioProceso] NVARCHAR (450)  NULL,
    CONSTRAINT [PK_ProductosPrecios] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_ProductosPrecios_Productos] FOREIGN KEY ([ProductoId]) REFERENCES [dbo].[Productos] ([Id])
);

