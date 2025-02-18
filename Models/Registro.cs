using System.ComponentModel.DataAnnotations;
using System.Timers;
namespace JimmyConcepcion_P1_AP1.Models
{
    public class Registro
    {
        [Key]
        public int AporteId { get; set; }
        public string Observacion { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio.")]
        public string Persona { get; set; }
        [Range(1, double.MaxValue, ErrorMessage = "El monto debe ser mayor que 0")]
        public Decimal Monto { get; set; }
        public DateTime Fecha { get; set; }


    }
}
