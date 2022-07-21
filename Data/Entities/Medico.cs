using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Unidades_De_Saude.Data.Entities
{
    [Table("Medico")]
    public class Medico : EntityBase
    {
        public string nome { get; set; } = string.Empty;
        public string crm { get; set; } = string.Empty;
    }
}
