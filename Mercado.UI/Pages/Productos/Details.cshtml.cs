using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Mercado.UI.Data;
using Mercado.core.Models;

namespace Mercado.UI.Pages.Productos
{
    public class DetailsModel : PageModel
    {
        private readonly Mercado.UI.Data.MercadoContext _context;

        public DetailsModel(Mercado.UI.Data.MercadoContext context)
        {
            _context = context;
        }

      public Producto Producto { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Producto == null)
            {
                return NotFound();
            }
            //Las siguientes líneas sirven para que se muestren los detalles de la marca del producto también.
            var producto = await _context.Producto
                .Include(s => s.Marca)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.ProductoId == id);

            if (producto == null)
            {
                return NotFound();
            }
            else 
            {
                Producto = producto;
            }
            return Page();
        }
    }
}
