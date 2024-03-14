CREATE TABLE [dbo].[Temps]
(
	[Id_temps] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
	[Temps_cuisson] INT NULL, 
	[Temps_preparation] INT NOT NULL, 
	[Temps_total] INT NOT NULL

)
