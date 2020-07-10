CREATE TABLE [dbo].[ParamCategorias] (
    [Id]          NVARCHAR (450) NOT NULL,
    [Codigo]      NVARCHAR (5)   NOT NULL,
    [Descripcion] NVARCHAR (150) NOT NULL,
    [ParentId]    NVARCHAR (450) NULL,
    [Estado]      BIT            CONSTRAINT [DF_ParamCategorias_Estado] DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_ParamCategorias] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_ParamCategorias_Codigo]
    ON [dbo].[ParamCategorias]([Codigo] ASC);

