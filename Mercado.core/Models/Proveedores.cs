using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Mercado.core.Models
{
    public class Proveedor
    {
        [Key]
        public int ProveedorId { get; set; }
        [Required]
        [StringLength(25)]
        [Display(Name = "Nombre del Proveedor")]
        public string? NombreProveedor { get; set; }
        [StringLength(15)]
        [Display(Name = "Numero de Teléfono")]
        public string? Tel { get; set; }
        [StringLength(30)]
        [Display(Name = "Dirección del Proveedor")]
        public string? Direccion { get; set; }
        //La siguiente línea sirve para que proveedoresxmarcas lo pueda acceder.
        public virtual ICollection<ProveedoresxMarcas>? ProveedoresxMarcas { get; set; }
    }
}
