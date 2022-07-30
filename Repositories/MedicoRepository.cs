using Microsoft.EntityFrameworkCore;
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

            _applicationDb.Entry(especialidade).State = EntityState.Modified;
            _applicationDb.SaveChanges();
        }

        public Especialidades GetEspecialidade(int id)
        {
            return _applicationDb.Set<Especialidades>().FirstOrDefault(a=> a.id == id);
        }

        public List<Especialidades> GetEspecialidades()
        {
            return _applicationDb.Set<Especialidades>().ToList();
        }

        public void UpdateEspecialidade(Especialidades especialidades)
        {
            _applicationDb.Entry(especialidades).State = EntityState.Modified;
            _applicationDb.SaveChanges();
        }
    }
}
