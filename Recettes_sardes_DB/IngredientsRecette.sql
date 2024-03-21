CREATE TABLE [dbo].[IngredientsRecette]
(
	[Id_recette] INT, 
	[Id_ingredients] INT, 
	[Quantite] INT, 
	PRIMARY KEY (Id_recette, Id_ingredients),
	FOREIGN KEY (Id_recette) REFERENCES Recette (Id_recette), 
	FOREIGN KEY (Id_ingredients) REFERENCES Ingredients (Id_ingredients)
)
