CREATE TABLE [dbo].[CommentaireRecette]
(
	[Id_recette] INT, 
	[Id_commentaire] INT, 
	PRIMARY KEY (Id_recette, Id_commentaire),
	FOREIGN KEY (Id_recette) REFERENCES Recette(Id_recette),
	FOREIGN KEY (Id_commentaire) REFERENCES Commentaire(Id_commentaire)
)
