using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Mercado.UI.Data;
using Mercado.core.Models;

namespace Mercado.UI.Pages.Productos
{
    public class CreateModel : PageModel
    {
        private readonly Mercado.UI.Data.MercadoContext _context;

        public CreateModel(Mercado.UI.Data.MercadoContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Producto Producto { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            var emptyProducto = new Producto();
            if (await TryUpdateModelAsync<Producto>(
            emptyProducto,
            "producto", //Prefijo para el valor del formulario.
            s => s.Nombre, s => s.Precio, s => s.Cantidad, s => s.Marca))
            {
                _context.Producto.Add(emptyProducto);
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index");
            }
            return Page();
        }
    }
}
