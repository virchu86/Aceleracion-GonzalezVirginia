﻿namespace ChallengeIngreso.Disney
{
    public class Personaje
    {
        public int Id { get; set; }
        public string Imagen { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public decimal Peso { get; set; }
        public string Historia { get; set; }
        public ICollection<Pelicula_o_Serie> Pelicula_O_Series { get; set; }
    }
}
