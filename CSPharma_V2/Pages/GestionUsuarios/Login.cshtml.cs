using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DAL_CSPharmaV2.Models;
using System.Security.Cryptography.X509Certificates;
using System.Drawing.Text;
using CSPharma_V2.Models;

namespace CSPharma_V2.Pages.GestionUsuarios
{
    public class LoginModel : PageModel
    {
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
            Models.LogicaLogin(usuario, password);
            

        }

    }
}
