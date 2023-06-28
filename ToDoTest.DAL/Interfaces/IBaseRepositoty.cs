namespace ToDoTest.DAL.Interfaces;

public interface IBaseRepositoty<T>
{
    bool Create(T entity);

    T Get(int id);

    Task<List<T>> Select();

    bool Deleate(T entity);
}