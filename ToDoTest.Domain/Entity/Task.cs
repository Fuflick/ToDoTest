using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using ToDoTest.Domain.Enum;

namespace ToDoTest.Domain.Entity
{
    public class Task
    {
        private int _id;

        [Key]
        [BackingField(nameof(_id))]
        public int Id 
        { 
            get { return _id; }
            set { _id = value; }
        }
        
        public string? Body { get; set; }
        
        public string? TaskName { get; set; }
        
        public TaskType TypeofTask { get; set; }
        
        public DateTime SetTime { get; set; }

        public Task()
        {
        }
    }
}

