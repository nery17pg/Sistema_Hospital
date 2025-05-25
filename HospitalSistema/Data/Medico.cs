using System.ComponentModel.DataAnnotations;

namespace HospitalSistema.Data
{
    public class Medico
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo Nombre es obligatorio.")]
        [StringLength(100, ErrorMessage = "El campo Nombre no puede tener más de 100 caracteres.")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "El campo Especialidad es obligatorio.")]
        [StringLength(50, ErrorMessage = "El campo Especialidad no puede tener más de 50 caracteres.")]
        public string? Especialidad { get; set; }
        [Required(ErrorMessage = "El campo Consultorio es obligatorio.")]
        [Range(1, 30, ErrorMessage = "El consultorio no existe (1-30).")]
        public int Consultorio { get; set; }

        //Propiedades de navegación EF
        //virtual public ICollection<Paciente>? Pacientes { get; set; }
        public virtual ICollection<Consulta>? Consultas { get; set; }
    }
}