CREATE TABLE [dbo].[UstensilesRecette]
(
	[Id_recette] INT,
	[Id_ustensiles] INT, 
	PRIMARY KEY (Id_recette, Id_ustensiles),
	FOREIGN KEY (Id_recette) REFERENCES Recette(Id_recette), 
	FOREIGN KEY (Id_ustensiles) REFERENCES Ustensiles(Id_ustensiles)
)
