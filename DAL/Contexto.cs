using JimmyConcepcion_P1_AP1.Models;
using Microsoft.EntityFrameworkCore;


namespace JimmyConcepcion_P1_AP1.DAL
{
    public class Contexto: DbContext
    {
        public DbSet<Registro> Registro { get; set; }
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

    }
}
