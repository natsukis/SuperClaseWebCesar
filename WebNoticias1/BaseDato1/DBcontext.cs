using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDato1.Tablas
{
    public class DBcontext : DbContext
    {
       
            public DBcontext()
                : base("name=Context")
            {

            }
            
            public DbSet<User> User { get; set; }

            public DbSet<News> News { get; set; }
            


        

    }
}
