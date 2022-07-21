using System.ComponentModel.DataAnnotations;

namespace Unidades_De_Saude.Data.Entities
{
    public class EntityBase
    {
        [Key]
        public int id { get; set; }
        public DateTime created { get; set; } = DateTime.Now;
        public DateTime updated { get; set; }
    }
}
