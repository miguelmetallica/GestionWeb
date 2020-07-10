CREATE TABLE [dbo].[ParamUnidadesMedidas] (
    [Id]          NVARCHAR (450) NOT NULL,
    [Codigo]      NVARCHAR (5)   NOT NULL,
    [Descripcion] NVARCHAR (150) NOT NULL,
    [Estado]      BIT            CONSTRAINT [DF_ParamUnidadesMedidas_Estado] DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_ParamUnidadesMedidas] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_ParamUnidadesMedidas_Codigo]
    ON [dbo].[ParamUnidadesMedidas]([Codigo] ASC);

