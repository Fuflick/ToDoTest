using System.ComponentModel.DataAnnotations;

namespace ToDoTest.Domain.Enum
{
    public enum TaskType
    {
        [Display(Name = "Favorite")]
        Favorite = 1,
        [Display(Name = "Common")]
        Common = 0
    }
}
