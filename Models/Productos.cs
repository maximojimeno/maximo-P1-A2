using System.ComponentModel.DataAnnotations;

namespace maximo_P1_A2.Models
{
    public class Productos
    {

        [Key]
        public int id { get; set; }

        [Required(ErrorMessage="La descripcion es requerida")]
        public string descripcion { get; set; }
        [Required(ErrorMessage="La Existencia de articulo es requerida")]
        public int existencia { get; set; }
        [Required(ErrorMessage="El costo de articulo es requerida")]
        public double costo { get; set; }
        [Required(ErrorMessage="El valor de inventario es requerido")]
        public double valorInventario { get; set; }
        
    }
}