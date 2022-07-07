using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

//Tabla Puente.
namespace Mercado.core.Models
{
    public class ProveedoresxMarcas
    {
        [Required]
        public int ProveedorId { get; set; }
        [Required]
        public int MarcaId { get; set; }
        public Proveedor? Proveedores { get; set; }
        public Marca? Marcas { get; set; }
    }
}
