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



    }
}
