using DAL_CSPharmaV2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel;

namespace CSPharma_V2.Pages.GestionUsuarios
{
    public class RegisterModel : PageModel
    {
        private CspharmaInformacionalContext dbcontext = new CspharmaInformacionalContext();


        [BindProperty]
        string usuario { get; set; }

        [BindProperty]
        string password { get; set; }

        [BindProperty]
        int rol { get; set; }

        public void OnGet()
        {
        }

        [HttpPost]
        public void PostUsuario()
        {
            dbcontext.Add(new DlkCatAccEmpleado(usuario, password, rol));
        }
    }
}
