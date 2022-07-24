using Unidades_De_Saude.Data.Entities;
using System.ComponentModel.DataAnnotations;

namespace Unidades_De_Saude.ModelViewModel
{
    public class MedicoViewModel : IModelViewModel<Medico>
    {

        public int Id { get; set; }
        [Required(ErrorMessage ="Nome Obrigatorio")]
        public string Nome { get; set; } = string.Empty;
        [Required(ErrorMessage ="CRM obrigatorio")]
        public string CRM { get; set; } = string.Empty;
        public void GetDatabase(Medico obj)
        {
            this.Id = obj.id;
            this.Nome = obj.nome;
            this.CRM = obj.crm;
        }

        public object GetListDatabase(List<Medico> obj)
        {
            List<MedicoViewModel> medicos = new List<MedicoViewModel>();
            foreach (var item in obj)
            {
                medicos.Add(new MedicoViewModel {Nome = item.nome, CRM = item.nome, Id = item.id });
            }
            return medicos;
        }

        public void UpdateDatabse(Medico obj)
        {
           obj.id = this.Id;
           obj.nome = this.Nome;
           obj.crm = this.CRM;
        }

    }
}
