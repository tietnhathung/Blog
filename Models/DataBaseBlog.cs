namespace Blog.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DataBaseBlog : DbContext
    {
        public DataBaseBlog() : base("name=DataBaseBlog")
        {
        }

        public virtual DbSet<Blog_category> Blog_category { get; set; }
        public virtual DbSet<Blog> Blogs { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<BLogCategory> BLogCategorys { get; set; }

        public class BLogCategory{
            public int BlogId {get;set;}
            public Blog Blog {get;set;}

            public int CategoryId {get;set;}
            public Category Category {get;set;}
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>()
                .Property(e => e.create_by)
                .IsUnicode(false);

            modelBuilder.Entity<Blog>()
                .HasMany(e => e.Blog_category)
                .WithOptional(e => e.Blog)
                .HasForeignKey(e => e.blog_id);

            modelBuilder.Entity<Category>()
                .HasMany(e => e.Blog_category)
                .WithOptional(e => e.Category)
                .HasForeignKey(e => e.category_id);

            modelBuilder.Entity<User>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<BLogCategory>().HasKey(sc => new {sc.BlogId,sc.CategoryId});
            modelBuilder.Entity<BLogCategory>()
                .HasOne<Blog>(sc => sc.Blog)
                .WithMany(s => s.BLogCategory)
                .HasForeignKey(sc => sc.BlogId);

            modelBuilder.Entity<BLogCategory>()
                .HasOne<Category>(sc => sc.Category)
                .WithMany(s => s.BLogCategory)
                .HasForeignKey(sc => sc.CategoryId);
        }
    }
}
