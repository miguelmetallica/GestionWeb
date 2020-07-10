CREATE TABLE [dbo].[ParamCuentasVentas] (
    [Id]          NVARCHAR (450) NOT NULL,
    [Codigo]      NVARCHAR (5)   NOT NULL,
    [Descripcion] NVARCHAR (150) NOT NULL,
    [Estado]      BIT            CONSTRAINT [DF_ParamCuentasVentas_Estado] DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_ParamCuentasVentas] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_ParamCuentasVentas_Codigo]
    ON [dbo].[ParamCuentasVentas]([Codigo] ASC);

