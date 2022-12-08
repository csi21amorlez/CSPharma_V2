using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DAL_CSPharmaV2.Models;

namespace CSPharma_V2.Pages.EstadoPago
{
    public class ListEstadoPagoModel : PageModel
    {
        private readonly DAL_CSPharmaV2.Models.CspharmaInformacionalContext _context;

        public ListEstadoPagoModel(DAL_CSPharmaV2.Models.CspharmaInformacionalContext context)
        {
            _context = context;
        }

        public IList<TdcCatEstadosPagoPedido> TdcCatEstadosPagoPedido { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.TdcCatEstadosPagoPedidos != null)
            {
                TdcCatEstadosPagoPedido = await _context.TdcCatEstadosPagoPedidos.ToListAsync();
            }
        }
    }
}
