﻿using Microsoft.EntityFrameworkCore;
using ToDoTest.DAL.Interfaces;

namespace ToDoTest.DAL.Repositories;

public class TaskRepository : ITaskRepository
{
    private ApplicationDbContext _db;

    public TaskRepository(ApplicationDbContext db)
    {
        _db = db;
    }

    public bool Create(Task entity)
    {
        throw new NotImplementedException();
    }

    public Task Get(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Task>> Select()
    {
        return _db.Tasks!.ToListAsync();
    }

    public bool Delete(Task entity)
    {
        throw new NotImplementedException();
    }
    
    public Task GetByName(string Name)
    {
        throw new NotImplementedException();
    }
}