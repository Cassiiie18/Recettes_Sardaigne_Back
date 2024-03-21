CREATE TABLE [dbo].[UserRecette]
(
	[Id_recette] INT NOT NULL,
	[Id_user] INT NOT NULL, 
	PRIMARY KEY (Id_recette, Id_user),
	FOREIGN KEY (Id_recette) REFERENCES Recette(Id_recette),
	FOREIGN KEY (Id_user) REFERENCES Users (Id_user)
)
