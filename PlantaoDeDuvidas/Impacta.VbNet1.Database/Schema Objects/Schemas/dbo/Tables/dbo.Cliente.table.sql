CREATE TABLE [dbo].[Cliente] (
    [Id]             INT          IDENTITY (1, 1) NOT NULL,
    [Nome]           VARCHAR (50) NOT NULL,
    [DataNascimento] DATETIME     NOT NULL,
    [Email]          VARCHAR (50) NULL,
    [Endereco]       VARCHAR (50) NOT NULL
);

