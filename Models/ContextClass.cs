using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace toDo.Models
{
    public class ContextClass:DbContext
    {
        public ContextClass(DbContextOptions<ContextClass> options):base(options)
        {

        }
        public DbSet<ItemClass> TodoItems { get; set; }
    }
}
