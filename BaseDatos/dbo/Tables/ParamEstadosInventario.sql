﻿CREATE TABLE [dbo].[ParamEstadosInventario] (
    [Id]          NVARCHAR (450) NOT NULL,
    [Codigo]      NVARCHAR (5)   NOT NULL,
    [Descripcion] NVARCHAR (150) NOT NULL,
    [Estado]      BIT            CONSTRAINT [DF_ParamEstadosInventario_Estado] DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_ParamEstadosInventario] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_ParamEstadosInventario_Codigo]
    ON [dbo].[ParamEstadosInventario]([Codigo] ASC);

