using System.ComponentModel.DataAnnotations;
using static Unidades_De_Saude.Utilites.HelpersEnum;

namespace Unidades_De_Saude.Data.Entities
{
    public class EntityBase
    {
        [Key]
        public int id { get; set; }
        public Situation situation { get; set; } = Situation.Activate;
        public DateTime created { get; set; } = DateTime.Now;
        public DateTime updated { get; set; }
    }
}
