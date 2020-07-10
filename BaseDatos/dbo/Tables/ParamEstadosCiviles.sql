﻿CREATE TABLE [dbo].[ParamEstadosCiviles] (
    [Id]          NVARCHAR (450) NOT NULL,
    [Codigo]      NVARCHAR (5)   NOT NULL,
    [Descripcion] NVARCHAR (150) NOT NULL,
    [Estado]      BIT            CONSTRAINT [DF_ParamEstadosCiviles_Estado] DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_ParamEstadosCiviles] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_ParamEstadosCiviles_Codigo]
    ON [dbo].[ParamEstadosCiviles]([Codigo] ASC);

