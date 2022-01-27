namespace ChallengeIngreso.Disney
{
    public class Pelicula_o_Serie
    {
        public int Id { get; set; }
        public string Imagen { get; set; }
        public string Titulo { get; set; }
        public DateTime Fecha { get; set; }
        public int Calificacion { get; set; }

        public Genero Genero { get; set; }
        public ICollection<Personaje> Personajes { get; set; }
    }
}
