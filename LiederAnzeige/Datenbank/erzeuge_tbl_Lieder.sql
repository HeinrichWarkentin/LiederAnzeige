CREATE TABLE [dbo].[Lieder] (
    [ID]           INT            NOT NULL,
    [Titel]        NVARCHAR (100) NOT NULL,
    [Titelnummer]  NVARCHAR (100) NULL,
    [Liederbuch] NVARCHAR(100) NOT NULL,
    [DateiPfad] NVARCHAR(MAX) NOT NULL, 
    PRIMARY KEY CLUSTERED ([ID] ASC)
);

