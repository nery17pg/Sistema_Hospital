using Microsoft.EntityFrameworkCore;
using HospitalSistema.Data;
using HospitalSistema.Repositorio;

namespace HospitalSistema.Repositorio
{
    public class RepositorioPacientes : IRepositorioPacientes
    {
        private readonly DBHospitalSistemaContext _context;

        public RepositorioPacientes(DBHospitalSistemaContext context)
        {
            _context = context;
        }

        public async Task Add(Paciente paciente)
        {
            await _context.Pacientes.AddAsync(paciente);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var paciente = await _context.Pacientes.FindAsync(id);
            _context.Pacientes.Remove(paciente!);
            await _context.SaveChangesAsync();
        }

        public async Task<Paciente> Get(int id)
        {
            return await _context.Pacientes.FindAsync(id);
        }

        public async Task<List<Paciente>> GetAll()
        {
            return await _context.Pacientes.Include(_ => _.Consultas).AsNoTracking().ToListAsync();
            //return await _context.Pacientes.AsNoTracking().ToListAsync(); /*AsNoTracking es para que no siga*/
        }

        public async Task Update(Paciente paciente)
        {
            _context.Pacientes.Update(paciente!);
            await _context.SaveChangesAsync();
        }
    }
}
