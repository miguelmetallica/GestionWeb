CREATE TABLE [dbo].[SisNumeraciones] (
    [Id]         NVARCHAR (450) NOT NULL,
    [SucursalId] NVARCHAR (450) NOT NULL,
    [Parametro]  NVARCHAR (150) NOT NULL,
    [Numero]     NUMERIC (10)   NOT NULL,
    CONSTRAINT [PK_SisNumeraciones] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_SisNumeraciones_Sucursales] FOREIGN KEY ([SucursalId]) REFERENCES [dbo].[Sucursales] ([Id])
);

