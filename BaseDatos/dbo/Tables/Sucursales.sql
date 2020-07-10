CREATE TABLE [dbo].[Sucursales] (
    [Id]               NVARCHAR (450) NOT NULL,
    [Codigo]           NVARCHAR (5)   NOT NULL,
    [Nombre]           NVARCHAR (150) NOT NULL,
    [ProvinciaId]      NVARCHAR (450) NULL,
    [Localidad]        NVARCHAR (250) NULL,
    [CodigoPostal]     NVARCHAR (10)  NULL,
    [Calle]            NVARCHAR (500) NULL,
    [NroCalle]         NVARCHAR (10)  NULL,
    [PisoDpto]         NVARCHAR (100) NULL,
    [OtrasReferencias] NVARCHAR (500) NULL,
    [Estado]           BIT            CONSTRAINT [DF_Sucursales_Estado] DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_Sucursales] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Sucursales_ParamProvincias] FOREIGN KEY ([ProvinciaId]) REFERENCES [dbo].[ParamProvincias] ([Id])
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_Sucursales_Codigo]
    ON [dbo].[Sucursales]([Codigo] ASC);

