CREATE TABLE [dbo].[CategorieRecette]
(
	[Id_recette] INT, 
	[Id_categorie] INT, 
	PRIMARY KEY (Id_recette, Id_categorie),
	FOREIGN KEY (Id_recette) REFERENCES Recette (Id_recette),
	FOREIGN KEY (Id_categorie) REFERENCES Categorie (Id_categorie)
)
