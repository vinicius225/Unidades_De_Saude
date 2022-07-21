using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Unidades_De_Saude.Data.Entities;

namespace Unidades_De_Saude.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        DbSet<Medico> Medicos { get; set; }
        DbSet<Especialidades> Especialidades { get; set; }
    }
}