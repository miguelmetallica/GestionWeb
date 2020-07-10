CREATE TABLE [dbo].[Clientes] (
    [Id]                NVARCHAR (450) NOT NULL,
    [Codigo]            NVARCHAR (10)  NOT NULL,
    [Apellido]          NVARCHAR (150) NULL,
    [Nombre]            NVARCHAR (150) NULL,
    [RazonSocial]       NVARCHAR (300) NOT NULL,
    [TipoDocumentoId]   NVARCHAR (450) NOT NULL,
    [NroDocumento]      NVARCHAR (11)  NOT NULL,
    [CuilCuit]          NVARCHAR (11)  NOT NULL,
    [Foto]              NVARCHAR (MAX) NULL,
    [FechaNacimiento]   DATETIME       NULL,
    [EstadoCivilId]     NVARCHAR (450) NULL,
    [NacionalidadId]    NVARCHAR (450) NULL,
    [esPersonaJuridica] BIT            CONSTRAINT [DF_Clientes_esPersonaJuridica] DEFAULT ((0)) NOT NULL,
    [ProvinciaId]       NVARCHAR (450) NULL,
    [Localidad]         NVARCHAR (250) NULL,
    [CodigoPostal]      NVARCHAR (10)  NULL,
    [Calle]             NVARCHAR (500) NULL,
    [CalleNro]          NVARCHAR (10)  NULL,
    [PisoDpto]          NVARCHAR (100) NULL,
    [OtrasReferencias]  NVARCHAR (500) NULL,
    [Telefono]          NVARCHAR (15)  NULL,
    [Celular]           NVARCHAR (15)  NULL,
    [Email]             NVARCHAR (150) NULL,
    [Estado]            BIT            NOT NULL,
    [FechaAlta]         DATETIME       NOT NULL,
    [UsuarioAlta]       NVARCHAR (500) NOT NULL,
    CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Clientes_ParamEstadosCiviles] FOREIGN KEY ([EstadoCivilId]) REFERENCES [dbo].[ParamEstadosCiviles] ([Id]),
    CONSTRAINT [FK_Clientes_ParamNacionalidades] FOREIGN KEY ([NacionalidadId]) REFERENCES [dbo].[ParamNacionalidades] ([Id]),
    CONSTRAINT [FK_Clientes_ParamProvincias] FOREIGN KEY ([ProvinciaId]) REFERENCES [dbo].[ParamProvincias] ([Id]),
    CONSTRAINT [FK_Clientes_ParamTiposDocumentos] FOREIGN KEY ([TipoDocumentoId]) REFERENCES [dbo].[ParamTiposDocumentos] ([Id])
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_Clientes_CuilCuit]
    ON [dbo].[Clientes]([CuilCuit] ASC);

