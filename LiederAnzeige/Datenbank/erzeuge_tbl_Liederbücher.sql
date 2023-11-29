CREATE TABLE [dbo].[Liederbücher] (
    [ID]           INT            IDENTITY(1,1)	NOT NULL,
    [Name]         NVARCHAR (100) NOT NULL,
    [Verlag]       NVARCHAR (100) NULL,
    [AnzahlLieder] INT            NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);

