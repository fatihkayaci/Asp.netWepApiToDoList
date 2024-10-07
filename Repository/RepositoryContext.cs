using Microsoft.EntityFrameworkCore;
namespace ToDoList.Repository
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<ToDoList.Models.ToDoList> toDoLists { get; set; }
    }
}
