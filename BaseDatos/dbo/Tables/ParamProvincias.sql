﻿CREATE TABLE [dbo].[ParamProvincias] (
    [Id]          NVARCHAR (450) NOT NULL,
    [Codigo]      NVARCHAR (5)   NOT NULL,
    [Descripcion] NVARCHAR (150) NOT NULL,
    [Estado]      BIT            CONSTRAINT [DF_ParamProvincias_Estado] DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_ParamProvincias] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_ParamProvincias_Codigo]
    ON [dbo].[ParamProvincias]([Codigo] ASC);

