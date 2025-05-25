using Microsoft.EntityFrameworkCore;
using HospitalSistema.Data;
using HospitalSistema.Repositorio;

namespace HospitalSistema.Repositorio
{
    public class RepositorioMedicos : IRepositorioMedicos
    {
        private readonly DBHospitalSistemaContext _context;

        public RepositorioMedicos(DBHospitalSistemaContext context)
        {
            _context = context;
        }

        public async Task Add(Medico medico)
        {
            await _context.Medicos.AddAsync(medico);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var medico = await _context.Medicos.FindAsync(id);
            _context.Medicos.Remove(medico!);
            await _context.SaveChangesAsync();
        }

        public async Task<Medico> Get(int id)
        {
            return await _context.Medicos.FindAsync(id);
        }

        public async Task<List<Medico>> GetAll()
        {
            return await _context.Medicos.Include(_ => _.Consultas).AsNoTracking().ToListAsync();
            //return await _context.Medicos.AsNoTracking().ToListAsync(); /*AsNoTracking es para que no siga*/
        }

        public async Task Update(Medico medico)
        {
            _context.Medicos.Update(medico!);
            await _context.SaveChangesAsync();
        }
    }
}
