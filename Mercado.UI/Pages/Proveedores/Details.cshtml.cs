﻿using System;
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
    public class DetailsModel : PageModel
    {
        private readonly Mercado.UI.Data.MercadoContext _context;

        public DetailsModel(Mercado.UI.Data.MercadoContext context)
        {
            _context = context;
        }

      public Proveedor Proveedor { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Proveedor == null)
            {
                return NotFound();
            }

            var proveedor = await _context.Proveedor.FirstOrDefaultAsync(m => m.ProveedorId == id);
            if (proveedor == null)
            {
                return NotFound();
            }
            else 
            {
                Proveedor = proveedor;
            }
            return Page();
        }
    }
}