

namespace DAL.Entities
{
    public class Temps
    {
        //[JsonIgnore]
        public int id_temps { get; set; }

        public int temps_cuisson_minutes { get; set; }
        public int temps_preparation_minutes { get; set; }
        public int temps_total_minutes { get; set; }

        //public TimeOnlyPerso temps_cuisson { get; set; } 

        //public TimeOnlyPerso temps_preparation { get; set; } 

        //public TimeOnlyPerso temps_total { get; set; } 


        //public Temps(int id_temps, TimeOnlyPerso temps_cuisson, TimeOnlyPerso temps_preparation, TimeOnlyPerso temps_total)
        //{
        //    this.id_temps = id_temps;
        //    this.temps_cuisson = temps_cuisson;
        //    this.temps_preparation = temps_preparation;
        //    this.temps_total = temps_total;

        //}

        public Temps() { }




    }

    //public struct TimeOnlyPerso
    //{
    //    public int Hour { get; set; }
    //    public int Minute { get; set; }

    //    public TimeOnlyPerso(int Hour, int Minute)
    //    {
    //        this.Minute = Minute;
    //        this.Hour = Hour;
    //    }
    //}
}

