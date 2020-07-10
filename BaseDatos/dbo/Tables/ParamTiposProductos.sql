CREATE TABLE [dbo].[ParamTiposProductos] (
    [Id]          NVARCHAR (450) NOT NULL,
    [Codigo]      NVARCHAR (5)   NOT NULL,
    [Descripcion] NVARCHAR (150) NOT NULL,
    [Estado]      BIT            CONSTRAINT [DF_ParamTiposProductos_Estado] DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_ParamTiposProductos] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_ParamTiposProductos_Codigo]
    ON [dbo].[ParamTiposProductos]([Codigo] ASC);

