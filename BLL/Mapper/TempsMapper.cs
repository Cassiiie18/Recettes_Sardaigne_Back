

namespace BLL.Mapper
{
    public static class TempsMapper
    {
        public static Temps ToTemps(this TempsForm tempsForm)
        {
            //return new Temps()
            //{
            //    temps_cuisson = new TimeOnlyPerso(tempsForm.temps_cuisson.Hour, tempsForm.temps_cuisson.Minute),
            //    temps_preparation = new TimeOnlyPerso(tempsForm.temps_preparation.Hour, tempsForm.temps_preparation.Minute),
            //    temps_total = new TimeOnlyPerso(tempsForm.temps_total.Hour, tempsForm.temps_total.Minute)
            //};

            return new Temps()
            {
                temps_cuisson_minutes = tempsForm.temps_cuisson_minutes,
                temps_preparation_minutes = tempsForm.temps_preparation_minutes,
                temps_total_minutes = tempsForm.temps_total_minutes
            };
        }
    }
}
