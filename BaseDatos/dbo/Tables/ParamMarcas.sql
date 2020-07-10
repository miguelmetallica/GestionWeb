CREATE TABLE [dbo].[ParamMarcas] (
    [Id]          NVARCHAR (450) NOT NULL,
    [Codigo]      NVARCHAR (5)   NOT NULL,
    [Descripcion] NVARCHAR (150) NOT NULL,
    [Estado]      BIT            CONSTRAINT [DF_ParamMarcas_Estado] DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_ParamMarcas] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_ParamMarcas_Codigo]
    ON [dbo].[ParamMarcas]([Codigo] ASC);

