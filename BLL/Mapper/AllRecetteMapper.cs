namespace BLL.Mapper
{
    public static class AllRecetteMapper
    {

        public static RecetteTemps ToAllRecetteTemps(this RecetteTempsForm recetteTempsForm)
        {
            return new RecetteTemps()
            {
                nom = recetteTempsForm.nom,
                nombre_personnes = recetteTempsForm.nombre_personnes,
                photo = recetteTempsForm.photo,
                gamme_prix = recetteTempsForm.gamme_prix,
                difficulte = recetteTempsForm.difficulte,

                temps_cuisson_minutes = recetteTempsForm.temps_cuisson_minutes,
                temps_preparation_minutes = recetteTempsForm.temps_preparation_minutes,
                temps_total_minutes = recetteTempsForm.temps_total_minutes,


    };
        }

    }
}
