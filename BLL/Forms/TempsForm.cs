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
        
        public TimeSpan temps_cuisson;

        [Required]
        public TimeSpan temps_preparation;

        [Required]
        public TimeSpan temps_total;
    }
}
