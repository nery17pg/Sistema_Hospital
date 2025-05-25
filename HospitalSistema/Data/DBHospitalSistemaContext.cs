using HospitalSistema.Data;
using Microsoft.EntityFrameworkCore;

namespace HospitalSistema.Data
{
    public class DBHospitalSistemaContext : DbContext
    {
        public DBHospitalSistemaContext(
                      DbContextOptions<DBHospitalSistemaContext>
            options) : base(options)
        {

        }

        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Consulta> Consultas { get; set; }
    }
}
