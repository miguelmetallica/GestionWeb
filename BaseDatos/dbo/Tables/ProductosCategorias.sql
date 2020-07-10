CREATE TABLE [dbo].[ProductosCategorias] (
    [Id]          NVARCHAR (450) NOT NULL,
    [ProductoId]  NVARCHAR (450) NULL,
    [CategoriaId] NVARCHAR (450) NULL,
    CONSTRAINT [PK_ProductosCategorias] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_ProductosCategorias_ParamCategorias] FOREIGN KEY ([CategoriaId]) REFERENCES [dbo].[ParamCategorias] ([Id]),
    CONSTRAINT [FK_ProductosCategorias_Productos] FOREIGN KEY ([ProductoId]) REFERENCES [dbo].[Productos] ([Id])
);

