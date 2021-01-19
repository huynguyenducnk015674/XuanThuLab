using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _09.Album.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _09.Album.Pages
{
   
    public class TestAuthorized1Model : PageModel
    {
        private readonly IAuthorizationService _authorizationService;
        public TestAuthorized1Model(IAuthorizationService _authorizationService)
        {
            this._authorizationService = _authorizationService;
        }
        public async Task<IActionResult> OnGet()
        {
            var post = new Post()
            {
                UserID = "9970b55b-32de-4235-ac67-7ec299130613"
            };
            var rs = await _authorizationService.AuthorizeAsync(User, post, new CanUpdatePostRequirement(true, true));
            if (!rs.Succeeded) return Forbid();
            return Page();
        }
        
    }
}
