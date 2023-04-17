using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Model;

namespace PersonaApp.Controllers
{
        [Route("api/[controller]")]
        [ApiController]
        public class PersonaController : ControllerBase
        {

            private FacultadContext _context;


            public PersonaController(FacultadContext flashCardsContext)
            {
                _context = flashCardsContext;
            }

            [HttpGet]
            public async Task<IEnumerable<Persona>> Get() => await _context.Personas.ToListAsync();


            [HttpPost]
            public async Task<ActionResult<Persona>> Post(Persona persona)
            {
                _context.Personas.Add(persona);
                await _context.SaveChangesAsync();

                return CreatedAtAction(nameof(Get), new { id = persona.CI }, persona);
            }

            [HttpGet("{id}")]
            public async Task<ActionResult<Persona>> Get(string id)
            {
                var persona = await _context.Personas.FindAsync(id);
                return persona == null ? NotFound() : Ok(persona);
            }

            [HttpPut("{id}")]
            public async Task<ActionResult<Persona>> Put(string id, Persona persona)
            {
                if (id != persona.CI) return BadRequest();

                _context.Entry(persona).State = EntityState.Modified;

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException) when (!FlashCardExists(id))
                {
                    return NotFound();
                }

                return CreatedAtAction(nameof(Get), new { id = persona.CI }, persona);
            }

            [HttpDelete("{id}")]
            public async Task<ActionResult<Persona>> Delete(string id)
            {
                var persona = await _context.Personas.FindAsync(id);
                if (persona == null) return NotFound();

                _context.Personas.Remove(persona);
                await _context.SaveChangesAsync();

                return Ok(persona);
            }

            private bool FlashCardExists(string id)
            {
                return _context.Personas.Any(persona => persona.CI == id);
            }

        }
    }

