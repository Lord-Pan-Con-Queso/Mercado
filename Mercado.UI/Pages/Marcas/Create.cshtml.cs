using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Mercado.UI.Data;
using Mercado.core.Models;

namespace Mercado.UI.Pages.Marcas
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
        public Marca Marca { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            var emptyMarca = new Marca();
            if (await TryUpdateModelAsync<Marca>(
            emptyMarca,
            "marca", //Prefijo para el valor del formulario.
            s => s.NombreMarca))
            {
                _context.Marca.Add(emptyMarca);
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index");
            }
            return Page();
        }
    }
}
