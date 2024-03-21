CREATE TABLE [dbo].[FavorisRecette]
(
	[Id_recette] INT, 
	[Id_favoris] INT, 
	PRIMARY KEY (Id_recette, Id_favoris),
	FOREIGN KEY (Id_recette) REFERENCES Recette (Id_recette),
	FOREIGN KEY (Id_favoris) REFERENCES Favoris (Id_favoris)

)
