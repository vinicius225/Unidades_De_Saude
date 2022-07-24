using System.ComponentModel.DataAnnotations.Schema;

namespace Unidades_De_Saude.Data.Entities
{
    [Table("Especialidade")]
    public class Especialidades : EntityBase
    {
        public string nome  { get; set; } = string.Empty;
        public string descricao { get; set; }
    }
}
