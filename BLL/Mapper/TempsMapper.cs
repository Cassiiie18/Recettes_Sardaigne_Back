using BLL.Forms;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Mapper
{
    public static class TempsMapper
    {
        public static Temps ToTemps(this TempsForm tempsForm)
        {
            return new Temps()
            {
                temps_cuisson = new TimeOnlyPerso(tempsForm.temps_cuisson.Hour, tempsForm.temps_cuisson.Minute),
                temps_preparation = new TimeOnlyPerso(tempsForm.temps_preparation.Hour, tempsForm.temps_preparation.Minute),
                temps_total = new TimeOnlyPerso(tempsForm.temps_total.Hour, tempsForm.temps_total.Minute)
            };
        }
    }
}
