using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TaskManagementApp.Models;

namespace TaskManagementApp.Data
{
    public class TaskManagementAppContext : DbContext
    {
        public TaskManagementAppContext (DbContextOptions<TaskManagementAppContext> options)
            : base(options)
        {
        }

        public DbSet<TaskManagementApp.Models.TaskModel> TaskModel { get; set; } = default!;
    }
}
