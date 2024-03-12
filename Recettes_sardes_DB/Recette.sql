CREATE TABLE [dbo].[Recette]
(
	[Id_recette] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[Nom] VARCHAR(50) NOT NULL, 
	[Nombre_personnes] INT NOT NULL, 
	[Photo] VARCHAR(2100) NOT NULL,
	[Id_temps] INT NOT NULL,
	[Id_prix] INT NOT NULL, 
	[Id_difficulte] INT NOT NULL, 
	[Id_categorie] INT NOT NULL, 
	FOREIGN KEY (Id_temps) REFERENCES Temps(Id_Temps), 
	FOREIGN KEY (Id_prix) REFERENCES Prix(Id_prix), 
	FOREIGN KEY (Id_difficulte) REFERENCES Difficulte(Id_difficulte), 
	FOREIGN KEY (Id_categorie) REFERENCES Categorie(Id_categorie)
)
