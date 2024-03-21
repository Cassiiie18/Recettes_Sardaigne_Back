using DAL.Entities;
using DAL.Interfaces;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class EtapesRecetteService
    {
        private readonly IEtapesRecetteRepository _etapesRecetteRepository;


        public EtapesRecetteService(IEtapesRecetteRepository etapesRecetteRepository)
        {
            _etapesRecetteRepository = etapesRecetteRepository;
        }



        public IEnumerable<EtapesRecette> GetAllEtapesRecettes()
        {
            return _etapesRecetteRepository.GetAllEtapesRecettes();
        }

        //public bool DeleteEtapesRecette(int id_recette, int id_etapes)
        //{

        //}

        public EtapesRecette GetEtapesRecetteById(int id_recette, int id_etapes)
        {
            return _etapesRecetteRepository.GetEtapesRecetteById(id_recette, id_etapes);
        }


        public EtapesRecette? GetEtapesRecetteByName(string nom)
        {
            return _etapesRecetteRepository.GetEtapesRecetteByName(nom);
        }
    }
}
