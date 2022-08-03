using Microsoft.EntityFrameworkCore;
using Unidades_De_Saude.Data;

namespace Unidades_De_Saude.Repositories.Interfaces
{
    public abstract class RepositoryBase<TEntity>  : IRepositoryBase<TEntity> where TEntity : class 
    {
        private readonly ApplicationDbContext _applicationDb;

        public RepositoryBase(ApplicationDbContext applicationDb)
        {
            _applicationDb = applicationDb;
        }
        public  void Add(TEntity obj)
        {
            _applicationDb.Add(obj);
            _applicationDb.SaveChanges();
        }
        public void Update(TEntity obj)
        {
            _applicationDb.Entry(obj).State = EntityState.Modified;
            _applicationDb.SaveChanges();
        }
        public IEnumerable<TEntity> GetAll ()
        {
            return _applicationDb.Set<TEntity>().ToList();
        }
        public TEntity GetById (int id)
        {
            return _applicationDb.Set<TEntity>().Find(id);
        }


    }
}
