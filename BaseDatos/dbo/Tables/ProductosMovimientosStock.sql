﻿CREATE TABLE [dbo].[ProductosMovimientosStock] (
    [Id]                NVARCHAR (450) NOT NULL,
    [NumeroMovimiento]  NUMERIC (10)   NULL,
    [SucursalId]        NVARCHAR (450) NULL,
    [UbicacionId]       NVARCHAR (450) NULL,
    [ProductoId]        NVARCHAR (450) NULL,
    [ColorId]           NVARCHAR (450) NULL,
    [TalleId]           NVARCHAR (450) NULL,
    [Cantidad]          NUMERIC (10)   NULL,
    [Descripcion]       NVARCHAR (500) NULL,
    [FechaMovimiento]   DATETIME       NULL,
    [UsuarioMovimiento] NVARCHAR (450) NULL,
    CONSTRAINT [PK_ProductosMovimientosStock] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_ProductosMovimientosStock_ParamColores] FOREIGN KEY ([ColorId]) REFERENCES [dbo].[ParamColores] ([Id]),
    CONSTRAINT [FK_ProductosMovimientosStock_Productos] FOREIGN KEY ([ProductoId]) REFERENCES [dbo].[Productos] ([Id]),
    CONSTRAINT [FK_ProductosMovimientosStock_Sucursales] FOREIGN KEY ([SucursalId]) REFERENCES [dbo].[Sucursales] ([Id]),
    CONSTRAINT [FK_ProductosMovimientosStock_Ubicaciones] FOREIGN KEY ([UbicacionId]) REFERENCES [dbo].[Ubicaciones] ([Id])
);

