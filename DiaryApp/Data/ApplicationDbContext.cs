using DiaryApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DiaryApp.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }
    public DbSet<DiaryEntry> DiaryEntries  { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<DiaryEntry>().HasData(
            new DiaryEntry {Id = 1, Title = "First Diary Entry", Content = "First diary content", Created = new DateTime(2024, 1, 1)},
            new DiaryEntry {Id = 2, Title = "Second Diary Entry", Content = "Second diary content", Created = new DateTime(2024, 1, 2)},
            new DiaryEntry {Id = 3, Title = "Third Diary Entry", Content = "Third diary content", Created = new DateTime(2024, 1, 3)},
            new DiaryEntry {Id = 4, Title = "Fourth Diary Entry", Content = "Fourth diary content", Created = new DateTime(2024, 1, 4)}
        );
    }

}