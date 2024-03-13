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
    public class TempsService
    {
        private readonly ITempsRepository _tempsRepository;

        public TempsService(ITempsRepository tempsRepository)
        {
            _tempsRepository = tempsRepository;
        }

        public Temps? CreateTemps(TempsForm tempsForm)
        {
           
                Temps temps = tempsForm.ToTemps();

                return temps = _tempsRepository.CreateTemps(temps);
            
        }

        public bool DeleteTemps(int id_temps)
        {
            Temps? t = _tempsRepository.GetTempsById(id_temps);

            if (t is not null)
            {
                return _tempsRepository.DeleteTemps(t);
            }

            return false;
        }

        public Temps GetTempsById(int id_temps)
        {
            return _tempsRepository.GetTempsById(id_temps);
        }

        public bool UpdateTemps(UpdateTempsForm updateTempsForm)
        {
            Temps? t = _tempsRepository.GetTempsById(updateTempsForm.id_temps);

            if (t != null)
            {
                return _tempsRepository.UpdateTemps(t);
            }
            return false;
        }
    }
}
