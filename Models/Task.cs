using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace minimal_api.Models
{
    public class Task
    {
        public Guid Id { get; set; }

        public Guid CategoryId { get; set; }

        public string? Title { get; set; }

        public string? Description { get; set; }

        public Priority Priority { get; set; }

        public DateTime? DueDate { get; set; }

        public virtual Category? Category { get; set; }
    }
}

public enum Priority
{
    Low = 1,
    Medium = 2,
    High = 3
}