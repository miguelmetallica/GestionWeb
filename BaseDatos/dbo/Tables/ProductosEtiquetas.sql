CREATE TABLE [dbo].[ProductosEtiquetas] (
    [Id]          NVARCHAR (450) NOT NULL,
    [ProductoId]  NVARCHAR (450) NULL,
    [EtiquetasId] NVARCHAR (450) NULL,
    CONSTRAINT [PK_ProductosEtiquetas] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_ProductosEtiquetas_ParamEtiquetas] FOREIGN KEY ([EtiquetasId]) REFERENCES [dbo].[ParamEtiquetas] ([Id]),
    CONSTRAINT [FK_ProductosEtiquetas_Productos] FOREIGN KEY ([ProductoId]) REFERENCES [dbo].[Productos] ([Id])
);

