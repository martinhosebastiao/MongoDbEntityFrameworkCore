using Microsoft.EntityFrameworkCore;
using MongoDB.EntityFrameworkCore.Extensions;
using MongoDbWithEFApi.Entities;

namespace MongoDbWithEFApi.Persistences;

public class MongoDbContext : DbContext
{
    public MongoDbContext(DbContextOptions options) : base(options) { }

    public DbSet<Summary> Summaries { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Summary>().ToCollection("summaries");

        base.OnModelCreating(modelBuilder);
    }
}
