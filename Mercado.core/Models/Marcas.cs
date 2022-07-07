using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Mercado.core.Models
{
    public class Marca
    {
        [Key]
        public int MarcaId { get; set; }
        [Required]
        [StringLength(25)]
        [Display(Name = "Nombre de la Marca")]
        public string? NombreMarca { get; set; }
        public virtual ICollection<ProveedoresxMarcas>? ProveedoresxMarcas { get; set; }
        public ICollection<Producto>? Productos { get; set; }
    }
}
