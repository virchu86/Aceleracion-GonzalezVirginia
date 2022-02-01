using ChallengeIngreso.Context;
using ChallengeIngreso.Disney;
using Microsoft.AspNetCore.Mvc;

namespace ChallengeIngreso.Controllers
{
    [ApiController]
    [Route(template: "api/[controller]")]

    public class PersonajeControllers : ControllerBase
    {
        private readonly DisneyContext _context;
        public PersonajeControllers(DisneyContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Personajes.ToList());
        }
        [HttpPost]
        public IActionResult Post(Personaje personaje)
        {
            _context.Personajes.Add(personaje);
            _context.SaveChanges();
            return Ok(_context.Personajes.ToList());

        }
        [HttpPut]
        public IActionResult Put(Personaje personaje)
        {
            if (_context.Personajes.FirstOrDefault(x: personaje => x.Id == personaje.Id)
                == null) return BadRequest("El personaje no existe");
            var internalPersonaje = _context.Personajes.Find(personaje.Id);

            internalPersonaje.Nombre = personaje.Nombre;
            internalPersonaje.Imagen = personaje.Imagen;
            _context.SaveChanges();
            return Ok(_context.Personajes.ToList());

        }
        [HttpDelete]
        [Route (template:"{id}")]
        public IActionResult Delete (int id)
        {
            if (_context.Personajes.FirstOrDefault(x: personaje => x.Id == id)
                == null) return BadRequest(error: "El personaje no existe");
            var internalPersonaje = _context.Personajes.Find(id);
            _context.Personajes.Remove(internalPersonaje);
            _context.SaveChanges();
            return Ok(_context.Personajes.ToList());

        }
    }
}
