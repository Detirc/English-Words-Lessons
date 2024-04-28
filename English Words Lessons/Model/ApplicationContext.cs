using Microsoft.EntityFrameworkCore;

namespace English_Words_Lessons.Model
{
    internal class ApplicationContext : DbContext
    {
        public DbSet<Word> Words { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=englishwords.db");

        }

    }
}
