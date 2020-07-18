﻿CREATE TABLE [dbo].[Productos] (
    [Id]                  NVARCHAR (450)  NOT NULL,
    [Codigo]              NVARCHAR (20)   NOT NULL,
    [Producto]            NVARCHAR (150)  NOT NULL,
    [TipoProductoId]      NVARCHAR (450)  NULL,
    [DescripcionCorta]    NVARCHAR (500)  NULL,
    [DescripcionLarga]    NVARCHAR (4000) NULL,
    [Peso]                NUMERIC (18, 2) NULL,
    [DimencionesLongitud] NUMERIC (18, 2) NULL,
    [DimencionesAncho]    NUMERIC (18, 2) NULL,
    [DimencionesAltura]   NUMERIC (18, 2) NULL,
    [PrecioCompra]        NUMERIC (18, 2) NULL,
    [CuentaVentaId]       NVARCHAR (450)  NULL,
    [CuentaCompraId]      NVARCHAR (450)  NULL,
    [UnidadMedidaId]      NVARCHAR (450)  NULL,
    [MarcaId]             NVARCHAR (450)  NULL,
    [Imagen]              NVARCHAR (MAX)  NULL,
    [Visible]             BIT             NULL,
    [PrecioNormal]        NUMERIC (18, 2) NULL,
    [PrecioRebajado]      NUMERIC (18, 2) NULL,
    [EstadoInventarioId]  NVARCHAR (450)  NULL,
    [Estado]              BIT             NOT NULL,
    [FechaAlta]           DATETIME        NOT NULL,
    [UsuarioAlta]         NVARCHAR (450)  NOT NULL,
    CONSTRAINT [PK_Productos] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Productos_ParamCuentasCompras] FOREIGN KEY ([CuentaCompraId]) REFERENCES [dbo].[ParamCuentasCompras] ([Id]),
    CONSTRAINT [FK_Productos_ParamCuentasVentas] FOREIGN KEY ([CuentaVentaId]) REFERENCES [dbo].[ParamCuentasVentas] ([Id]),
    CONSTRAINT [FK_Productos_ParamEstadosInventario] FOREIGN KEY ([EstadoInventarioId]) REFERENCES [dbo].[ParamEstadosInventario] ([Id]),
    CONSTRAINT [FK_Productos_ParamMarcas] FOREIGN KEY ([MarcaId]) REFERENCES [dbo].[ParamMarcas] ([Id]),
    CONSTRAINT [FK_Productos_ParamTiposProductos] FOREIGN KEY ([TipoProductoId]) REFERENCES [dbo].[ParamTiposProductos] ([Id]),
    CONSTRAINT [FK_Productos_ParamUnidadesMedidas] FOREIGN KEY ([UnidadMedidaId]) REFERENCES [dbo].[ParamUnidadesMedidas] ([Id])
);
