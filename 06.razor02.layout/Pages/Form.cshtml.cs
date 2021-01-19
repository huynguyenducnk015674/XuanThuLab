using _06.razor02.layout.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace _06.razor02.layout.Pages
{
    public class FormModel : PageModel
    {
        [BindProperty]
        public CustomerInfo customerInfo { get; set; }
        readonly IWebHostEnvironment envir;
        readonly ILogger log;
        public string Message;
        public FormModel(IWebHostEnvironment envir, ILogger log)
        {
            this.envir = envir;
        }
        public void OnGet()
        {
        }
        public void OnPost()
        {
            if (ModelState.IsValid)
            {
                Message = "Data post ok !!!";
            }
            else
            {
                Message = "Data post not ok !!!";
            }
        }

    }
}
