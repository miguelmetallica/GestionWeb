CREATE TABLE [dbo].[ParamEtiquetas] (
    [Id]          NVARCHAR (450) NOT NULL,
    [Codigo]      NVARCHAR (5)   NOT NULL,
    [Descripcion] NVARCHAR (150) NOT NULL,
    [Estado]      BIT            CONSTRAINT [DF_ParamEtiquetas_Estado] DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_ParamEtiquetas] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_ParamEtiquetas_Codigo]
    ON [dbo].[ParamEtiquetas]([Codigo] ASC);

