using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Temps
    {
        public int id_temps {  get; set; }
        
        public TimeSpan temps_cuisson { get; set; }

        public TimeSpan temps_preparation { get; set; }

        public TimeSpan temps_total { get; set; }
    }
}
