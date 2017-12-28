using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogAppDAL
{
    public class DBInitializer : DropCreateDatabaseAlways<BlogAppContext> // DropCreateDatabaseIfModelChanges<BlogAppContext> // 
    {
    }
}