using Unidades_De_Saude.Data;
using Unidades_De_Saude.Data.Entities;
using Unidades_De_Saude.Repositories.Interfaces;

namespace Unidades_De_Saude.Repositories
{
    public interface IMedicoRepository : IRepositoryBase<Medico>
    {
        void AddEspecialidade(Especialidades especialidades);
        void UpdateEspecialidade(Especialidades especialidades);
        void DeleteEspecialidade(int id);
        Especialidades GetEspecialidade(int id);
        List<Especialidades> GetEspecialidades();
    }
}
