CREATE TABLE [dbo].[SisComprobantesNumeraciones] (
    [Id]         NVARCHAR (450) NOT NULL,
    [SucursalId] NVARCHAR (450) NOT NULL,
    [Letra]      CHAR (1)       NOT NULL,
    [PuntoVenta] INT            NOT NULL,
    [Numero]     NUMERIC (10)   NOT NULL,
    CONSTRAINT [PK_SisComprobantesNumeraciones] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_SisComprobantesNumeraciones_Sucursales] FOREIGN KEY ([SucursalId]) REFERENCES [dbo].[Sucursales] ([Id])
);

