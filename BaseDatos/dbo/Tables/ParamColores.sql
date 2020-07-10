CREATE TABLE [dbo].[ParamColores] (
    [Id]          NVARCHAR (450) NOT NULL,
    [Codigo]      NVARCHAR (5)   NOT NULL,
    [Descripcion] NVARCHAR (150) NOT NULL,
    [Color]       NVARCHAR (50)  NOT NULL,
    [Estado]      BIT            CONSTRAINT [DF_ParamColores_Estado] DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_ParamColores] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_ParamColores_Codigo]
    ON [dbo].[ParamColores]([Codigo] ASC);

