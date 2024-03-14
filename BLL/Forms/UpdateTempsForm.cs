using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Forms
{
    public class UpdateTempsForm
    {

        public int id_temps;
        
        public TimeOnly temps_cuisson;

        [Required]
        public TimeOnly temps_preparation;

        [Required]
        public TimeOnly temps_total;
    }
}
