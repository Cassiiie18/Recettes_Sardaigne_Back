CREATE TABLE [dbo].[Temps]
(
	[Id_temps] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
	[Temps_cuisson_minutes] INT NULL, 
	[Temps_preparation_minutes] INT NOT NULL, 
	[Temps_total_minutes] INT NOT NULL

)
