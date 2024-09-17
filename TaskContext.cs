using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using minimal_api.Models;

namespace minimal_api
{
    public class TaskContext : DbContext
    {
        public DbSet<Models.Category> Categories { get; set; }
        public DbSet<Models.Task> Tasks { get; set; }
        public TaskContext(DbContextOptions<TaskContext> options) : base(options) { }
    }
}