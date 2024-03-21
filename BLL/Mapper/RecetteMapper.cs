

namespace BLL.Mapper
{
    public static class RecetteMapper
    {
        public static Recette ToRecette(this RecetteForm recetteForm)
        {
            return new Recette()
            {
                nom = recetteForm.nom,
                nombre_personnes = recetteForm.nombre_personnes,
                photo = recetteForm.photo,
                gamme_prix = recetteForm.gamme_prix,
                difficulte = recetteForm.difficulte,
                temps = recetteForm.temps,
                
            };
        }
    }
}
