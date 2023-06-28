using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using ToDoTest.Domain.Enum;

namespace ToDoTest.Domain.Entity
{
    public class Task
    {
        private int _id;

        [Key]
        [Column("TaskId")]
        public int Id
        {
            get; set;
        }
        
        public string? Body { get; set; }
        
        public string? TaskName { get; set; }
        
        public TaskType TypeofTask { get; set; }
        
        public DateTime SetTime { get; set; }

        /*private int GetId()
        {
            return _id;
        }

        private void SetId(int val)
        {
            _id = val;
        }*/
        
        public Task()
        {
        }
    }
}

