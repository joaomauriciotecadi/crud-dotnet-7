using Microsoft.EntityFrameworkCore;
using crud_dotnet_7.Models;

namespace crud_dotnet_7.Data;

public class TodoContext : DbContext 
{
    public TodoContext(DbContextOptions<TodoContext> options) : base(options)
    {
    }

    public DbSet<TodoItem> TodoItems {get; set;} = null!;
}