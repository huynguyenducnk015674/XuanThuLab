using _06.razor02.layout.Models;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;

namespace _06.razor02.layout.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
        // Handler gọi khi truy vấn bằng HTTP POST
        public void OnPost()
        {
            // Microsoft.AspNetCore.Http.Extensions -> GetDisplayUrl
            Console.WriteLine(Request.GetDisplayUrl());
            var route = Request.RouteValues;
            var req = Request;
            Redirect("privacy");
        }
        [BindProperty]
        public string Email { get; set; }
        [BindProperty(Name = "username")]
        public string UserId { get; set; }
        [BindProperty(SupportsGet = true)]
        public int ProductId { get; set; }
        [BindProperty]
        public string Color { get; set; }
        [BindProperty(SupportsGet = true)]
        public Product product { get; set; }
    }
}
