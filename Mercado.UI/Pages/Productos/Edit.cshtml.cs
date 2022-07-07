using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Mercado.UI.Data;
using Mercado.core.Models;

namespace Mercado.UI.Pages.Productos
{
    public class EditModel : PageModel
    {
        private readonly Mercado.UI.Data.MercadoContext _context;

        public EditModel(Mercado.UI.Data.MercadoContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Producto Producto { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Producto =  await _context.Producto.FindAsync(id);
            if (Producto == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync(int id)
        {
            var productoToUpdate = await _context.Producto.FindAsync(id);
            if (productoToUpdate == null)
            {
                return NotFound();
            }
            if (await TryUpdateModelAsync<Producto>(
            productoToUpdate,
                "producto",
            s => s.Nombre, s => s.Precio, s => s.Cantidad, s => s.Marca))
            {
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index");
            }
            return Page();
        }
    }
}
