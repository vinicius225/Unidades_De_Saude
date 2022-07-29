using Unidades_De_Saude.Data;
using Unidades_De_Saude.Data.Entities;

namespace Unidades_De_Saude.Repositories.Interfaces
{
    public class MedicoRepository : RepositoryBase<Medico>, IMedicoRepository
    {
        private readonly ApplicationDbContext _applicationDb;
        public MedicoRepository(ApplicationDbContext applicationDb) : base(applicationDb)
        {
            _applicationDb = applicationDb;
        }

        public void AddEspecialidade(Especialidades especialidades)
        {
            _applicationDb.Add(especialidades);
            _applicationDb.SaveChanges();
        }

        public void DeleteEspecialidade(int id)
        {
            var especialidade = _applicationDb.Set<Especialidades>().FirstOrDefault(e => e.id == id);
            especialidade.situation = Utilites.HelpersEnum.Situation.Deleted;
        }

        public Especialidades GetEspecialidade(int id)
        {
            throw new NotImplementedException();
        }

        public List<Especialidades> GetEspecialidades()
        {
            throw new NotImplementedException();
        }

        public void UpdateEspecialidade(Especialidades especialidades)
        {
            throw new NotImplementedException();
        }
    }
}
