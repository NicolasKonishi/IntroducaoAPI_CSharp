using Microsoft.EntityFrameworkCore;
using WebAPI.Curso_DIO.Entities;

namespace WebAPI.Curso_DIO.Context
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options) {


        }
        public DbSet<Contato> Contatos {get; set;}
    }
}
