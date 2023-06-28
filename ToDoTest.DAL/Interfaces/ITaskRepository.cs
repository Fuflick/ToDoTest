namespace ToDoTest.DAL.Interfaces;

public interface ITaskRepository : IBaseRepository<Task>
{
    Task GetByName(string name);
}