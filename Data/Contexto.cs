using maximo_P1_A2.Models;
using Microsoft.EntityFrameworkCore;

namespace maximo_P1_A2.Data
{
     public class Contexto : DbContext
    {
        public  DbSet<Productos> Productos{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data source = Data\\Registro.db");
        }
    }
}