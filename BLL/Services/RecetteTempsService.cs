using DAL.Interfaces;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class RecetteTempsService
    {
        private readonly IRecetteTempsRepository _recetteTempsRepository;


        public RecetteTempsService(IRecetteTempsRepository recetteTempsRepository)
        {
            _recetteTempsRepository = recetteTempsRepository;
        }


        public RecetteTemps GetRecetteTempsById(int id_recette)
        {
            return _recetteTempsRepository.GetRecetteTempsById(id_recette);
        }


        public RecetteTemps? GetRecetteTempsByName(string nom)
        {
            return _recetteTempsRepository.GetRecetteTempsByName(nom);
        }

        public IEnumerable<RecetteTemps> GetAllRecettesTemps()
        {
            return _recetteTempsRepository.GetAllRecettesTemps();
        }

        public bool DeleteRecetteTemps(int id_recette)
        {
            RecetteTemps? rt = _recetteTempsRepository.GetRecetteTempsById(id_recette);

            if (rt is not null)
            {
                return _recetteTempsRepository.DeleteRecetteTemps(rt);
            }

            return false;


        }

        //public bool UpdateRecetteTemps(RecetteTemps recetteTemps)
        //{
        //    RecetteTemps? rt = _recetteTempsRepository.GetRecetteTempsByName(updateRecetteForm.nom);

        //    if (r != null)
        //    {
        //        return _recetteTempsRepository.UpdateRecetteTemps(rt);
        //    }
        //    return false;
        //}


    }
}
