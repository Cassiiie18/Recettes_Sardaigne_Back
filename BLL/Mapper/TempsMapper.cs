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
                temps_cuisson = tempsForm.temps_cuisson,
                temps_preparation = tempsForm.temps_preparation,
                temps_total = tempsForm.temps_total,
            };
        }
    }
}
