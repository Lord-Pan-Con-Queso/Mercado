using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Para hacer el formateo de datos.
using System.ComponentModel.DataAnnotations;

namespace Mercado.core.Models
{
    public class Producto
    {
        [Key]
        public int ProductoId { get; set; }
        [Required]
        [StringLength(25)]
        [Display(Name = "Nombre del Producto")]
        public string? Nombre { get; set; }
        public int Precio { get; set; }
        public int Cantidad { get; set; }
        //1 producto tiene 1 Marca.
        public ICollection<Marca>? Marca { get; set; }
    }
}
//Relación del .UI con el .Core - Mercado.UI/Agregar/Referencia del Proyecto/Mercado.core
//Compilar antes de agregar el scaffold.
//Luego scaffolding en Mercado.UI/Pages/Productos
//En contexto apretar el + para que cree un contexto por defecto (sacarle el UI) y lo va a crear dentro de UI.data(no deberia estar ahi pero luego se cambia) y luego Agregar (si pide agregar algo desde paquetes agregamos el que pida).
