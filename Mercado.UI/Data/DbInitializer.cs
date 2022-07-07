using Mercado.core.Models;

namespace Mercado.UI.Data
{
    public static class DbInitializer
    {
        public static void Initialize(MercadoContext context)
        {
            // Busca Productos.
            if (context.Producto.Any())
            {
                return;
            }
        }
    }
}
