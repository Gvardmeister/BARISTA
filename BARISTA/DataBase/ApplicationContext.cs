using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace BARISTA.DataBase
{
    internal class ApplicationContext : DbContext
    {
        public ApplicationContext() : base("ApplicationContextDB")
        {
            Database.CreateIfNotExists();
        }

       //public DbSet<BARISTA> BARISTAS { get; set; }
    }
}
