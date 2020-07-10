CREATE TABLE [dbo].[ParamComprobantesTipos] (
    [Id]          NVARCHAR (450) NOT NULL,
    [Codigo]      NVARCHAR (5)   NOT NULL,
    [Descripcion] NVARCHAR (150) NOT NULL,
    [Abrevitura]  NVARCHAR (5)   NULL,
    [Estado]      BIT            NULL,
    CONSTRAINT [PK_ComprobantesTipos] PRIMARY KEY CLUSTERED ([Id] ASC)
);

