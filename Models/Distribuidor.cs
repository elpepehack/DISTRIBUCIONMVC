using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
namespace T2_PILCO_JOSEE.Models
{


    public class Distribuidor
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del distribuidor es obligatorio")]
        [StringLength(100, ErrorMessage = "El nombre no puede exceder 100 caracteres")]
        public string NombreDistribuidor { get; set; }

        [Required(ErrorMessage = "La razón social es obligatoria")]
        [StringLength(200, ErrorMessage = "La razón social no puede exceder 200 caracteres")]
        public string RazonSocial { get; set; }

        [Required(ErrorMessage = "El teléfono es obligatorio")]
        [RegularExpression(@"^[0-9\s\+\-\(\)]{7,20}$",
            ErrorMessage = "Formato de teléfono inválido")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "El año de inicio de operación es obligatorio")]
        [Range(1900, 3000, ErrorMessage = "El año debe estar entre 1900 y 3000")]
        public int AnioInicioOperacion { get; set; }

        [Required(ErrorMessage = "El contacto es obligatorio")]
        [StringLength(100, ErrorMessage = "El contacto no puede exceder 100 caracteres")]
        public string Contacto { get; set; }
    }
}
