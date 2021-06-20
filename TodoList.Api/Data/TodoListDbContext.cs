using Microsoft.EntityFrameworkCore;
namespace TodoList.Api.Data
{
    public class TodoListDbContext : DbContext
    {
        public TodoListDbContext(DbContextOptions dbContext)
            : base(dbContext)
        {

        }
        public DbSet<Entity.Task> Tasks { get; set; }
    }
}
