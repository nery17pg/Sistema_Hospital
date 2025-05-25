using HospitalSistema.Data;

namespace HospitalSistema.Repositorio
{
    public interface IRepositorioPacientes
    {
        Task<List<Paciente>> GetAll();
        Task<Paciente> Get(int id);
        Task Add(Paciente paciente);
        Task Update(Paciente paciente);
        Task Delete(int id);
    }
}
