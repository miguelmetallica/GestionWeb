CREATE TABLE [dbo].[ParamCondicionesIva] (
    [Id]          NVARCHAR (450) NOT NULL,
    [Codigo]      NVARCHAR (5)   NOT NULL,
    [Descripcion] NVARCHAR (150) NOT NULL,
    [Estado]      BIT            CONSTRAINT [DF_ParamCondicionesIva_Estado] DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_ParamCondicionesIva] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_ParamCondicionesIva_Codigo]
    ON [dbo].[ParamCondicionesIva]([Codigo] ASC);

