using BLL.Forms;
using BLL.Mapper;
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
    public class EtapesService
    {
        private readonly IEtapesRepository _etapesRepository;


        public EtapesService(IEtapesRepository etapesRepository)
        {
            _etapesRepository = etapesRepository;
        }

        public List<Etapes> GetAllEtapes()
        {
            return _etapesRepository.GetAllEtapes();
        }

        public Etapes CreateEtapes(EtapesForm etapeForm)
        {
       
                Etapes etapes  = etapeForm.ToEtapes();

                return etapes = _etapesRepository.CreateEtapes(etapes);

        }


        public bool DeleteEtapes(Etapes etapes)
        {
            return _etapesRepository.DeleteEtapes(etapes);
        }
    }
}
