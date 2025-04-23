using appweb1.data;
using appweb1.model;
using appweb1.Pages;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _ctx;
        public IndexModel(AppDbContext ctx)
        {
            this._ctx=ctx;
        }

        public List<Cliente> Clientes {get; set;}
        public void OnGet()
        {
            Clientes = _ctx.Clientes.ToList();

         
        }
    }
}
