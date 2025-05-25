using HospitalSistema.Data;

namespace HospitalSistema.Repositorio
{
    public interface IRepositorioConsultas
    {
        Task<List<Consulta>> GetAll();
        Task<Consulta> Get(int id);
        Task Add(Consulta consulta);
        Task Update(Consulta consulta);
        Task Delete(int id);
    }
}
