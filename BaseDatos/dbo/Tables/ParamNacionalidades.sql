CREATE TABLE [dbo].[ParamNacionalidades] (
    [Id]          NVARCHAR (450) NOT NULL,
    [Codigo]      NVARCHAR (5)   NOT NULL,
    [Descripcion] NVARCHAR (150) NOT NULL,
    [Estado]      BIT            CONSTRAINT [DF_ParamNacionalidades_Estado] DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_ParamNacionalidades] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_ParamNacionalidades_Codigo]
    ON [dbo].[ParamNacionalidades]([Codigo] ASC);

