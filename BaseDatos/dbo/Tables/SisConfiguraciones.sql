CREATE TABLE [dbo].[SisConfiguraciones] (
    [Id]            NVARCHAR (450) NOT NULL,
    [SucursalId]    NVARCHAR (450) NULL,
    [Configuracion] NVARCHAR (150) NULL,
    [Valor]         NVARCHAR (50)  NULL,
    [Estado]        BIT            NULL,
    CONSTRAINT [PK_SisConfiguraciones] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_SisConfiguraciones_Sucursales] FOREIGN KEY ([SucursalId]) REFERENCES [dbo].[Sucursales] ([Id])
);

