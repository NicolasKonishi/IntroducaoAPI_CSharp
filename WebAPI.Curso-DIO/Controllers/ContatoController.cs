using Microsoft.AspNetCore.Mvc;
using WebAPI.Curso_DIO.Context;
using WebAPI.Curso_DIO.Entities;

namespace WebAPI.Curso_DIO.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContatoController:ControllerBase
    {
        private readonly AgendaContext _context;

        public ContatoController(AgendaContext context) { 
            
            _context = context;
        
        }
        [HttpPost]
        public IActionResult Create(Contato contato)
        {
            _context.Add(contato);
            _context.SaveChanges();
            return Ok(contato);
        }
    }
}
