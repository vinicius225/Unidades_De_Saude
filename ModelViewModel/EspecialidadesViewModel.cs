using Unidades_De_Saude.Data.Entities;
using System.ComponentModel.DataAnnotations;

namespace Unidades_De_Saude.ModelViewModel
{
    public class EspecialidadesViewModel : IModelViewModel<Especialidades>
    {

        public int Id { get; set; }

        [Display(Name ="Especialidade")]
        [Required(ErrorMessage ="Campo obrigátorio.")]
        public string Nome { get; set; }
        public string Descricao { get; set; } 
        public void GetDatabase(Especialidades obj)
        {
            throw new NotImplementedException();
        }

        public object GetListDatabase(List<Especialidades> obj)
        {
            List<EspecialidadesViewModel> especialidades = new List<EspecialidadesViewModel>();

            foreach(Especialidades objItem in obj)
            {
              EspecialidadesViewModel especialidade = new EspecialidadesViewModel() {
                    Id = objItem.id,
                    Nome = objItem.nome,
                    Descricao = objItem.descricao
                };
                especialidades.Add(especialidade);
            }
            return especialidades;
        }

        public void UpdateDatabse(Especialidades obj)
        {
            obj.id = Id;
            obj.nome = Nome;
            obj.descricao = Descricao;
        }
    }
}
