namespace Blog.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DataBaseBlog : DbContext
    {
        public DataBaseBlog()
            : base("name=DataBaseBlog")
        {
        }

        public virtual DbSet<Blog> Blogs { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>()
                .Property(e => e.create_by)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.ID)
                .IsUnicode(false);
        }
    }
}
