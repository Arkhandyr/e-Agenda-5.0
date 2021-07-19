CREATE TABLE [dbo].[TBTAREFA] (
    [Id]            INT           IDENTITY (1, 1) NOT NULL,
    [Titulo]        VARCHAR (500) NOT NULL,
    [DataCriacao]   DATETIME      NOT NULL,
    [DataConclusao] DATETIME      NULL,
    [Prioridade]    INT           NOT NULL,
    [Percentual]    INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

