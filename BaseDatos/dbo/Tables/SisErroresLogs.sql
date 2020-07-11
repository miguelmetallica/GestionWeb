CREATE TABLE [dbo].[SisErroresLogs] (
    [Id]            NVARCHAR (450)  NOT NULL,
    [FechaHora]     DATETIME        NOT NULL,
    [Modulo]        NVARCHAR (500)  NOT NULL,
    [ErrorMessage]  NVARCHAR (4000) NOT NULL,
    [ErrorSeverity] INT             NOT NULL,
    [ErrorState]    INT             NOT NULL,
    CONSTRAINT [PK_SisErroresLogs] PRIMARY KEY CLUSTERED ([Id] ASC)
);




GO
CREATE NONCLUSTERED INDEX [IX_SisErroresLogs]
    ON [dbo].[SisErroresLogs]([FechaHora] DESC);

