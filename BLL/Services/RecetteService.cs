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

        public RecetteService(IRecetteRepository recetteRepository)
        {
            _recetteRepository = recetteRepository;
        }

        public Recette? CreateRecette(RecetteForm recetteForm)
        {
            Recette? r = _recetteRepository.GetRecetteByName(recetteForm.nom);

            if (r == null)
            {
                Recette recette = recetteForm.ToRecette();

                return recette = _recetteRepository.CreateRecette(recette);
            }

            return null;
        }

        public bool DeleteRecette(int id_recette)
        {
            Recette? r = _recetteRepository.GetRecetteById(id_recette);

            if(r is not null)
            {
                return _recetteRepository.DeleteRecette(r);
            }

            return false; 
        }

        public IEnumerable<Recette> GetAllRecettes()
        {
            return _recetteRepository.GetAllRecettes();
        }

        public Recette GetRecetteById(int id_recette)
        {
            return _recetteRepository.GetRecetteById(id_recette);
        }

        public Recette GetRecetteByName(string nom)
        {
            return _recetteRepository.GetRecetteByName(nom);
        }

        public bool UpdateRecette(UpdateRecetteForm updateRecetteForm)
        {
            Recette? r = _recetteRepository.GetRecetteByName(updateRecetteForm.nom);

            if( r != null)
            {
                return _recetteRepository.UpdateRecette(r);
            }
            return false;
        }
    }
}
