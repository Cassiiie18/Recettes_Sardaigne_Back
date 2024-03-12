CREATE TABLE [dbo].[Temps]
(
	[Id_temps] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
	[Temps_cuisson] TIME(0) NULL, 
	[Temps_preparation] TIME(0) NOT NULL, 
	[Temps_total] TIME(0) NOT NULL

)
