namespace ToDoTest.DAL.Interfaces;

public interface IBaseRepository<T>
{
    bool Create(T entity);

    T Get(int id);

    Task<List<T>> Select();

    bool Delete(T entity);
}