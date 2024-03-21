CREATE TABLE [dbo].[EtapesRecette]
(
	[Id_recette] INT NOT NULL,
	[Id_etapes] INT NOT NULL, 
	PRIMARY KEY (Id_recette, Id_etapes),
	FOREIGN KEY (Id_recette) REFERENCES Recette (Id_recette),
	FOREIGN KEY (Id_etapes) REFERENCES Etapes (Id_etapes)
)
