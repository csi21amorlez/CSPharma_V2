using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DAL_CSPharmaV2.Models;

namespace CSPharma_V2.Pages.GestionUsuarios
{
    public class RegisterUsuarioModel : PageModel
    {
        private readonly DAL_CSPharmaV2.Models.CspharmaInformacionalContext _context;

        public RegisterUsuarioModel(DAL_CSPharmaV2.Models.CspharmaInformacionalContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public DlkCatAccEmpleado DlkCatAccEmpleado { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.DlkCatAccEmpleados.Add(DlkCatAccEmpleado);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
