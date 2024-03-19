﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Forms
{
    public class UpdateRecetteTempsForm
    {
        
        public string nom { get; set; }

        
        public int nombre_personnes { get; set; }

        
        public string photo { get; set; }

        public string gamme_prix { get; set; }

        public string difficulte { get; set; }

        public int id_temps;

        public int temps_cuisson_minutes { get; set; }

        [Required]
        public int temps_preparation_minutes { get; set; }

        [Required]
        public int temps_total_minutes { get; set; }
    }
}