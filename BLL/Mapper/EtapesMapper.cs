

namespace BLL.Mapper
{
    public static class EtapesMapper
    {
        public static Etapes ToEtapes(this EtapesForm etapesForm)
        {
            return new Etapes
            {
                Description = etapesForm.Description
            };
        }
            
        
    }
}

