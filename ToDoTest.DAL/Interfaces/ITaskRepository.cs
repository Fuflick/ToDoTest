namespace ToDoTest.DAL.Interfaces;

public interface ITaskRepository : IBaseRepositoty<Task>
{
    Task GetByName(string Name);
}