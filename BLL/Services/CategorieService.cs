using BLL.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class CategorieService
    {
        private readonly ICategorieRepository _categorieRepository;


        public CategorieService(ICategorieRepository categorieRepository)
        {
            _categorieRepository = categorieRepository;
        }

        public Categorie CreateCategorie(CategorieForm categorieForm)
        {
            Categorie categorie = categorieForm.ToCategorie();

            return categorie = _categorieRepository.CreateCategorie(categorie);
        }

        public IEnumerable<Categorie> GetAllCategories()
        {
            return _categorieRepository.GetAllCategories();
        }

        public Categorie GetCategorieById(int id_categorie)
        {
            return _categorieRepository.GetCategorieById(id_categorie);
        }
    }
}
