using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Centralita1
{
    public class BloggingContext : DbContext
    {
        public DbSet<Llamada> llamadas { get; set; }
       

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=base.db");
    }

    public class Llamada
    {
        public int ID { get; set; }

        public Llamada(string origen)
        {
            this.origen = origen;
        }

        public string origen { get; set; }
        public required string destino { get; set; }
        public int duracion { get; set; }
        public int costollamada { get; set; }        
        
    }

   
}