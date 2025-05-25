using System.ComponentModel.DataAnnotations;

namespace HospitalSistema.Data
{
    public class Consulta
    {
        public int Id { get; set; }
        public int PacienteId { get; set; }
        public int MedicoId { get; set; }
        [Required(ErrorMessage = "El campo Fecha es obligatorio.")]
        [DataType(DataType.Date, ErrorMessage = "El formato de la fecha no es válido.")]
        public DateTime? Fecha { get; set; }
        [Required(ErrorMessage = "El campo Estado de Consulta es obligatorio.")]
        public string? Estado { get; set; }

        //Propiedades de navegación EF
        public virtual Paciente? Paciente { get; set; }
        public virtual Medico? Medico { get; set; }
    }
}