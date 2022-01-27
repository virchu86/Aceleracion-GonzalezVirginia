namespace ChallengeIngreso.Disney
{
    public class Genero
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Imagen { get; set; }
   
        public ICollection<Pelicula_o_Serie> Pelicula_O_Series { get; set; }
    }
}
