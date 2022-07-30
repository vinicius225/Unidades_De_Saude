using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Unidades_De_Saude.Data.Entities;
using Unidades_De_Saude.ModelViewModel;

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
        DbSet<Medico_Especialidade> Medico_Especialidades { get; set; }
        public DbSet<Unidades_De_Saude.ModelViewModel.MedicoViewModel>? MedicoViewModel { get; set; }
        public DbSet<Unidades_De_Saude.ModelViewModel.EspecialidadesViewModel>? EspecialidadesViewModel { get; set; }
    }
}