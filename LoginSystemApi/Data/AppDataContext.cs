using LoginSystemApi.Models;
using Microsoft.EntityFrameworkCore;

namespace LoginSystemApi.Data;

public class AppDataContext : DbContext
{
    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlite("DataSource=app.db;Cache=Shared");
    }
}