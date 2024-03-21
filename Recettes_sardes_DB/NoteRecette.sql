CREATE TABLE [dbo].[NoteRecette]
(
	[Id_recette] INT NOT NULL,
	[Id_note] INT NOT NULL, 
	PRIMARY KEY(Id_recette, Id_note),
	FOREIGN KEY (Id_recette) REFERENCES Recette(Id_recette),
	FOREIGN KEY (Id_note) REFERENCES Note(Id_note)
)
