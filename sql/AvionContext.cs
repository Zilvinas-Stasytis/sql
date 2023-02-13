using Microsoft.EntityFrameworkCore;
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aviabaze
{
    public class AvionContext : DbContext
    {
        public DbSet<Avion> Avions { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
    => options.UseSqlServer($"Server = localhost;Database = Aviabaze;Trusted_connection =True;Encrypt=false;");
    }
}
