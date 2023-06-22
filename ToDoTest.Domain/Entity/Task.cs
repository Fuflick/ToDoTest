using System.ComponentModel.DataAnnotations;
using ToDoTest.Domain.Enum;

namespace ToDoTest.Domain.Entity
{
    public class Task
    {
        [Key]
        public int Id { get; set; }
        
        public string? Body { get; set; }
        
        public string? Name { get; set; }
        
        public TaskType Type { get; set; }
        
        public DateTime DateTime { get; set; }

        public Task()
        {
            
        }
    }
}

