using System.ComponentModel.DataAnnotations;
namespace JimmyConcepcion_P1_AP1.Models
{
    public class Registro
    {
        [Key]
        public int AporteId { get; set; }
        public string Observacion { get; set; }
        public string Personas { get; set; }
        public int Monto { get; set; }
        public DateTime Fecha { get; set; }


    }
}
