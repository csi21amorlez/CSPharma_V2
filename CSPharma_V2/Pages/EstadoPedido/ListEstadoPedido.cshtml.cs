using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DAL_CSPharmaV2.Models;

namespace CSPharma_V2.Pages.EstadoPedido
{
    public class ListEstadoPedidoModel : PageModel
    {
        private readonly DAL_CSPharmaV2.Models.CspharmaInformacionalContext _context;

        public ListEstadoPedidoModel(DAL_CSPharmaV2.Models.CspharmaInformacionalContext context)
        {
            _context = context;
        }

        public IList<TdcTchEstadoPedido> TdcTchEstadoPedido { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.TdcTchEstadoPedidos != null)
            {
                TdcTchEstadoPedido = await _context.TdcTchEstadoPedidos
                .Include(t => t.CodEstadoDevolucionNavigation)
                .Include(t => t.CodEstadoEnvioNavigation)
                .Include(t => t.CodEstadoPagoNavigation).ToListAsync();
            }
        }
    }
}
