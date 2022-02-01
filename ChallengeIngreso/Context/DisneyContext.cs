using ChallengeIngreso.Disney;
using Microsoft.EntityFrameworkCore;

namespace ChallengeIngreso.Context
{
    public class DisneyContext : DbContext

    {
        public DisneyContext(DbContextOptions<DisneyContext> options) : base(options)
        {
        }

        public DbSet<Personaje> Personajes { get; set; }
        public DbSet<Pelicula_o_Serie> Pelicula_O_Series { get; set; }
        public DbSet<Genero> Generos { get; set; }
        }
}
