using BLL.Forms;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
