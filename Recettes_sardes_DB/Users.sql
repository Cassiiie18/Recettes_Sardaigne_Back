﻿CREATE TABLE [dbo].[Users]
(
	[Id_user] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
	[Email] NVARCHAR(50) NOT NULL UNIQUE, 
	[Pseudo] NVARCHAR(50) NOT NULL UNIQUE, 
	[Mot_de_passe] NVARCHAR(32) NOT NULL
)
