using BlogAppDAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace BlogAppDAL
{
    public class BlogAppContext : DbContext
    {
        public BlogAppContext()
            : base("name=BlogAppConn")
        {
        }

        public virtual DbSet<Blog> Blogs { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Database.CreateIfNotExists();
            //modelBuilder.Entity<User>().Property(a=>a.UserName).HasColumnAnnotation("")
        }

        public static void InitDBBase()
        {
            Database.SetInitializer(new DBInitializer());
        }
    }
}