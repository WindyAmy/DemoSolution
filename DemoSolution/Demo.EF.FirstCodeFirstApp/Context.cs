using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.EF.FirstCodeFirstApp
{
    public class Context : DbContext
    {
        public Context()
            : base("name=FirstCodeFirstApp")
        {
        }

        public DbSet<Donator> Donators { get; set; }
    }
}
