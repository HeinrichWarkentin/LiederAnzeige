CREATE TABLE lieder
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Titel] NVARCHAR(400) NOT NULL,
	[Titelnummer] INT NULL,
    [Liederbuch] NVARCHAR(400) NULL, 
    [Komponist] NVARCHAR(400) NULL, 
    [Übersetzer] NVARCHAR(400) NULL,
	[OriginalTitle] NVARCHAR(400) NULL, 
    [CopyRight] NVARCHAR(600) NULL, 
    [Kategorien] NVARCHAR(MAX) NULL, 
	[Pfad] NVARCHAR(MAX) NOT NULL

)
