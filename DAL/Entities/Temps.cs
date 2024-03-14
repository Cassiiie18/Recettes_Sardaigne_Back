using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Temps
    {
        [JsonIgnore]
        public int id_temps {  get; set; }

        public TimeOnlyPerso temps_cuisson { get; set; }

        public TimeOnlyPerso temps_preparation { get; set; }

        public TimeOnlyPerso temps_total { get; set; }
    }

    public struct TimeOnlyPerso
    {
        public int Hour { get; set; }
        public int Minute { get; set; }

        public TimeOnlyPerso(int Hour, int Minute)
        {
            this.Minute = Minute;
            this.Hour = Hour;
        }
    }
}
