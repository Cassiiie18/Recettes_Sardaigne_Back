using DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Forms
{
    public class RecetteForm
    {
        [Required]
        public string nom {  get; set; }

        [Required]
        public int nombre_personnes {  get; set; }

        [Required]
        public string photo {  get; set; }


        [Required]
        public string gamme_prix { get; set; }


        [Required]
        public string difficulte { get; set; }

        public Temps Chocapic { get; set; }

    }
}
