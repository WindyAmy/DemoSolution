using System.Data.Common;
using System.Data.Entity;

namespace Demo.EF.FirstCodeFirstApp
{
    public class Context : DbContext
    {
        public Context()
            : base("name=demoDB")
        {
        }

        public Context(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
        }

        /// <summary>
        /// 使用已存在的连接
        /// </summary>
        /// <param name="con"></param>
        public Context(DbConnection con)
            : base(con, contextOwnsConnection: false)
        {
        }

        public DbSet<Donator> Donators { get; set; }

        public DbSet<PayWay> PayWays { get; set; }
        public DbSet<Person> Persons { get; set; }
        //public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            #region 1.0 fluent API配置 直接注解

            //modelBuilder.Entity<Donator>().HasKey(a => a.DonatorId).ToTable("Donator");//映射到表Donators,DonatorId当作主键对待
            //modelBuilder.Entity<Donator>().Property(a => a.DonatorId).HasColumnName("ID");
            //modelBuilder.Entity<Donator>().Property(m => m.Name)
            //        .IsRequired()//设置Name是必须的，即不为null,默认是可为null的
            //        .IsUnicode()//设置Name列为Unicode字符，实际上默认就是unicode,所以该方法可不写
            //        .HasMaxLength(10);//最大长度为10

            #endregion 1.0 fluent API配置 直接注解

            #region #region 2.0 fluent API配置 配置类

            modelBuilder.Configurations.Add(new DonatorMap());
            //modelBuilder.Configurations.Add(new StudentMap());

            #endregion #region 2.0 fluent API配置 配置类

            //modelBuilder.Entity<Employee>().Map(m =>
            //{
            //    m.MapInheritedProperties();
            //    m.ToTable("Employees");
            //});

            //modelBuilder.Entity<Vendor>().Map(m =>
            //{
            //    m.MapInheritedProperties();
            //    m.ToTable("Vendors");
            //});
            modelBuilder.Configurations.Add(new DonatorViewInfoMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}