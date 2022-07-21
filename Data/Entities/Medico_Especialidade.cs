using System.ComponentModel.DataAnnotations.Schema;

namespace Unidades_De_Saude.Data.Entities
{
    [Table("medico_especialidade")]
    public class Medico_Especialidade : EntityBase
    {
        public int id_medico { get; set; }
        public int id_especialidade { get; set; }

        #region Foreingkey
        [ForeignKey("id_medico")]
        public virtual Medico Medico { get; set; }

        [ForeignKey("id_especialidade")]
        public virtual Especialidades Especialidadecs { get; set; }

        #endregion
    }
}
