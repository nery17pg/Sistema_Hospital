using Microsoft.EntityFrameworkCore;
using HospitalSistema.Repositorio;
using HospitalSistema.Data;

namespace HospitalSistema.Repositorio
{
    public class RepositorioConsultas : IRepositorioConsultas
    {
        private readonly DBHospitalSistemaContext _context;

        public RepositorioConsultas(DBHospitalSistemaContext context)
        {
            _context = context;
        }

        public async Task Add(Consulta consulta)
        {
            await _context.Consultas.AddAsync(consulta);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var consulta = await _context.Consultas.FindAsync(id);
            _context.Consultas.Remove(consulta!);
            await _context.SaveChangesAsync();
        }

        public async Task<Consulta> Get(int id)
        {
            return await _context.Consultas.FindAsync(id);
        }

        public async Task<List<Consulta>> GetAll()
        {
            //return await _context.Consultas.AsNoTracking().ToListAsync(); /*AsNoTracking es para que no siga*/
            //return await _context.Consultas.Include(_ => _.Paciente).AsNoTracking().ToListAsync();
            //return await _context.Consultas.Include(_ => _.Medico).AsNoTracking().ToListAsync();
            return await _context.Consultas.Include(_ => _.Paciente).Include(_ => _.Medico).AsNoTracking().ToListAsync();
        }

        public async Task Update(Consulta consulta)
        {
            _context.Consultas.Update(consulta);
            await _context.SaveChangesAsync();
        }
    }
}
