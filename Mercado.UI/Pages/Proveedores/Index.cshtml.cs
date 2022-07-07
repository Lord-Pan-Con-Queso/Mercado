using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Mercado.UI.Data;
using Mercado.core.Models;

namespace Mercado.UI.Pages.Proveedores
{
    public class IndexModel : PageModel
    {
        private readonly Mercado.UI.Data.MercadoContext _context;

        public IndexModel(Mercado.UI.Data.MercadoContext context)
        {
            _context = context;
        }

        public IList<Proveedor> Proveedor { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Proveedor != null)
            {
                Proveedor = await _context.Proveedor.ToListAsync();
            }
        }
    }
}
