using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Users
    {
        public int Id_user { get; set; }
        public string Email { get; set; }
        public string Pseudo {  get; set; }
        public string Mot_de_passe { get; set; }

    }
}
