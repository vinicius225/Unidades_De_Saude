namespace Unidades_De_Saude.ModelViewModel
{
    public interface IModelViewModel<T> where T : class
    {
        public void GetDatabase(T obj);
        public void UpdateDatabse(T obj);
        public Object GetListDatabase(List<T> obj);
    }
}
