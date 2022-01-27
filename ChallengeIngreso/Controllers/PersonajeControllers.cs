using ChallengeIngreso.Context;
using ChallengeIngreso.Disney;
using Microsoft.AspNetCore.Mvc;

namespace ChallengeIngreso.Controllers
{
    [ApiController]
    [Route(template:"api/[controller]")]

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
            return Ok (_context.Personajes.ToList()); 
        }
        [HttpPost]
        public IActionResult Post(Personaje personaje)
        {
            _context.Personaje.Add(personaje);
            //_context.SaveChanges();

            return Ok();
        }


    }
}
