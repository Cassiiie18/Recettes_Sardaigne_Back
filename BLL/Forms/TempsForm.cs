using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
