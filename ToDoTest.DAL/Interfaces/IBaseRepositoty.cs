namespace ToDoTest.DAL.Interfaces;

public interface IBaseRepositoty<T>
{
    bool Create(T entity);

    T Get(int id);

    Task<List<Task>> Select();

    bool Deleate(T entity);
}