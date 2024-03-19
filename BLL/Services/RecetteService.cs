using BLL.Forms;
using BLL.Mapper;
using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class RecetteService
    {
        private readonly IRecetteRepository _recetteRepository;
        private readonly ITempsRepository _tempsRepository;

        public RecetteService(IRecetteRepository recetteRepository, ITempsRepository tempsRepository)
        {
            _recetteRepository = recetteRepository;
            _tempsRepository = tempsRepository;
        }

        public Recette? CreateRecette(RecetteForm recetteForm)
        {
            Recette? r = _recetteRepository.GetRecetteByName(recetteForm.nom);
            //Temps? t = _tempsRepository.GetTempsById(temps.id_temps);

            if (r != null)
            {
                Recette recette = recetteForm.ToRecette();

                return recette = _recetteRepository.CreateRecette(recette);
            }

            return null;
        }

        #region Autres

        //public bool DeleteRecette(int id_recette)
        //{
        //    Recette? r = _recetteRepository.GetRecetteById(id_recette);

        //    if(r is not null)
        //    {
        //        return _recetteRepository.DeleteRecette(r);
        //    }

        //    return false; 
        //}

        //public IEnumerable<Recette> GetAllRecettes()
        //{
        //    return _recetteRepository.GetAllRecettes();
        //}

        //public Recette GetRecetteById(int id_recette)
        //{
        //    return _recetteRepository.GetRecetteById(id_recette);
        //}

        //public bool UpdateRecette(UpdateRecetteForm updateRecetteForm)
        //{
        //    Recette? r = _recetteRepository.GetRecetteByName(updateRecetteForm.nom);

        //    if( r != null)
        //    {
        //        return _recetteRepository.UpdateRecette(r);
        //    }
        //    return false;
        //}


        #endregion



        public Recette GetRecetteByName(string nom)
        {
            return _recetteRepository.GetRecetteByName(nom);
        }


    }
}
