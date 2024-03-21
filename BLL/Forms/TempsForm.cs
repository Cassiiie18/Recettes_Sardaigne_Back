

namespace BLL.Forms
{
    public class TempsForm
    {
        
        public int temps_cuisson_minutes;

        [Required]
        public int temps_preparation_minutes;

        [Required]
        public int temps_total_minutes;
    }
}
