using iTasks.models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace iTasks
{
    public class iTasksContext:DbContext
    {
        public DbSet<Users> Users { get; set; }
        public DbSet<Tasks> Tasks { get; set; } 
        public DbSet<TaskType> TaskTypes { get; set; }
              
        
    }
}
