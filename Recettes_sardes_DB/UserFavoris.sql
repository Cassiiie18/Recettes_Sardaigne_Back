CREATE TABLE [dbo].[UserFavoris]
(
	[Id_user] INT, 
	[Id_favoris] INT, 
	PRIMARY KEY (Id_user, Id_favoris),
	FOREIGN KEY (Id_user) REFERENCES Users (Id_user),
	FOREIGN KEY (Id_favoris) REFERENCES Favoris (Id_favoris)
)
