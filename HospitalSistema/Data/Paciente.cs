using System.ComponentModel.DataAnnotations;

namespace HospitalSistema.Data
{
    public class Paciente
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo Nombre es obligatorio.")]
        [StringLength(100, ErrorMessage = "El campo Nombre no puede tener más de 100 caracteres.")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "El campo Fecha de Nacimiento es obligatorio.")]
        [DataType(DataType.Date, ErrorMessage = "El formato de la fecha no es válido.")]
        public DateTime? Nacimiento { get; set; }
        [Required(ErrorMessage = "El campo Correo es obligatorio.")]
        [EmailAddress(ErrorMessage = "El formato del correo electrónico no es válido.")]
        [StringLength(100, ErrorMessage = "El campo Correo no puede tener más de 100 caracteres.")]
        public string? Correo { get; set; }
        [Required(ErrorMessage = "El campo Teléfono es obligatorio.")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "El campo Teléfono debe contener exactamente 10 dígitos.")]
        public string? Telefono { get; set; }

        //Propiedades de navegación EF
        //public int MedicoId { get; set; }
        //virtual public Medico? Medico { get; set; }
        public virtual ICollection<Consulta>? Consultas { get; set; }
    }
}