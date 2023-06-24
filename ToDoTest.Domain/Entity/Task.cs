using System.ComponentModel.DataAnnotations;
using ToDoTest.Domain.Enum;

namespace ToDoTest.Domain.Entity
{
    public class Task
    {
        [Key]
        public int Id { get; set; }
        
        public string? Body { get; set; }
        
        public string? TaskName { get; set; }
        
        public TaskType TypeofTask { get; set; }
        
        public DateTime SetTime { get; set; }

        public Task()
        {
            
        }
    }
}

