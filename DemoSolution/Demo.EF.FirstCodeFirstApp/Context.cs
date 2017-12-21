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

        public DbSet<Donator> Donators { get; set; }

        public DbSet<PayWay> PayWays { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            #region fluent API

            modelBuilder.Entity<Donator>().HasKey(a => a.DonatorId).ToTable("Donator");//映射到表Donators,DonatorId当作主键对待
            modelBuilder.Entity<Donator>().Property(a => a.DonatorId).HasColumnName("ID");
            modelBuilder.Entity<Donator>().Property(m => m.Name)
                    .IsRequired()//设置Name是必须的，即不为null,默认是可为null的
                    .IsUnicode()//设置Name列为Unicode字符，实际上默认就是unicode,所以该方法可不写
                    .HasMaxLength(10);//最大长度为10

            #endregion fluent API

            base.OnModelCreating(modelBuilder);
        }
    }
}