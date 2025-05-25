using HospitalSistema.Data;

namespace HospitalSistema.Repositorio
{
    public interface IRepositorioMedicos
    {
        Task<List<Medico>> GetAll();
        Task<Medico> Get(int id);
        Task Add(Medico medico);
        Task Update(Medico medico);
        Task Delete(int id);
    }
}
