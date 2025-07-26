using Microsoft.EntityFrameworkCore;
using BlogProject.Models;

namespace BlogProject.Data
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogEntry> BlogEntries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // User unique constraints
            modelBuilder.Entity<User>()
                .HasIndex(u => u.Username)
                .IsUnique()
                .HasDatabaseName("IX_Users_Username");

            modelBuilder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique()
                .HasDatabaseName("IX_Users_Email");

            // Blog unique constraint ve cascade delete
            modelBuilder.Entity<Blog>()
                .HasIndex(b => new { b.OwnerId, b.Slug })
                .IsUnique()
                .HasDatabaseName("uniq_blog_owner_id_slug");

            modelBuilder.Entity<Blog>()
                .HasOne(b => b.Owner)
                .WithMany(u => u.Blogs)
                .HasForeignKey(b => b.OwnerId)
                .OnDelete(DeleteBehavior.Cascade);

            // BlogEntry unique constraint ve cascade delete
            modelBuilder.Entity<BlogEntry>()
                .HasIndex(be => new { be.BlogId, be.Slug })
                .IsUnique()
                .HasDatabaseName("uniq_blog_message_blog_id_slug");

            modelBuilder.Entity<BlogEntry>()
                .HasOne(be => be.Blog)
                .WithMany(b => b.BlogEntries)
                .HasForeignKey(be => be.BlogId)
                .OnDelete(DeleteBehavior.Cascade);

            // DateTime default values for SQLite
            modelBuilder.Entity<BlogEntry>()
                .Property(be => be.CreatedAt)
                .HasDefaultValueSql("datetime('now')");

            modelBuilder.Entity<BlogEntry>()
                .Property(be => be.UpdatedAt)
                .HasDefaultValueSql("datetime('now')");
        }
    }
}