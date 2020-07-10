CREATE TABLE [dbo].[Ubicaciones] (
    [Id]          NVARCHAR (450) NOT NULL,
    [Codigo]      NVARCHAR (5)   NOT NULL,
    [Descripcion] NVARCHAR (150) NOT NULL,
    [SucursalId]  NVARCHAR (450) NOT NULL,
    [Estado]      BIT            CONSTRAINT [DF_Ubicaciones_Estado] DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_Ubicaciones] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Sucursales_Sucursales] FOREIGN KEY ([SucursalId]) REFERENCES [dbo].[Sucursales] ([Id])
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_Ubicaciones_Codigo]
    ON [dbo].[Ubicaciones]([Codigo] ASC);

