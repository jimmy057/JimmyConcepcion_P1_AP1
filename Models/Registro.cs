using System.ComponentModel.DataAnnotations;
namespace JimmyConcepcion_P1_AP1.Models
{
    public class Registro
    {
        [Key]
        public int Id { get; set; }
        public string Nombres { get; set; }

    }
}
