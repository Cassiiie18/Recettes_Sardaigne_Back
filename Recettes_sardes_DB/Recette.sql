CREATE TABLE [dbo].[Recette]
(
	[Id_recette] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[Nom] VARCHAR(50) NOT NULL, 
	[Nombre_personnes] INT NOT NULL, 
	[Photo] VARCHAR(2100) NOT NULL,
	[Gamme_prix] VARCHAR(50) NOT NULL, 
	[Difficulte] VARCHAR(50) NOT NULL,
	[Id_temps] INT NOT NULL,
	FOREIGN KEY (Id_temps) REFERENCES Temps(Id_Temps), 
)
