
using MinimalApi.Models;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace MinimalApi.Context
{
    public class TodoDbContext : DbContext
    {
        public TodoDbContext(DbCompiledModel options) : base(options)
        {
        }

        public DbSet<ToDoItem> TodoItems { get; set; }
    }
}
