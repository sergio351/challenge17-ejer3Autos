namespace Challenge17_Ejer3.Repositorio
{
    public interface IGenericRepository<T>where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int? id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(int? id);
    } 
}