using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DAL_CSPharmaV2.Models;

namespace CSPharma_V2.Pages.EstadoEnvio
{
    public class ListEstadoEnvioModel : PageModel
    {
        private readonly DAL_CSPharmaV2.Models.CspharmaInformacionalContext _context;

        public ListEstadoEnvioModel(DAL_CSPharmaV2.Models.CspharmaInformacionalContext context)
        {
            _context = context;
        }

        public IList<TdcCatEstadosEnvioPedido> TdcCatEstadosEnvioPedido { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.TdcCatEstadosEnvioPedidos != null)
            {
                TdcCatEstadosEnvioPedido = await _context.TdcCatEstadosEnvioPedidos.ToListAsync();
            }
        }
    }
}
