using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _06.razor02.layout.Pages.Shared.Components.MessagePage;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace _06.razor02.layout.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public IActionResult OnGet()
        {
            return ViewComponent("MessagePage", new MessagePage.Message
            {
                title = "Thông báo quan trọng",
                htmlcontent = "Đây là <strong>Nội dung HTML</strong>",
                secondwait = 5,
                urlredirect = "/"
            });
        }
    }
}
