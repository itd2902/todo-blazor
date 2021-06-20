using System;
using System.ComponentModel.DataAnnotations;
using TodoList.Api.Enum;

namespace TodoList.Api.Entity
{
    public class Task
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid? Assignee { get; set; }
        public DateTime CreatedDate { get; set; }
        public Priority Priority { get; set; }
        public Status MyProperty { get; set; }

    }
}
