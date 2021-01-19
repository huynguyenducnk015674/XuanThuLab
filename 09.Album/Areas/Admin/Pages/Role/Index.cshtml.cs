using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace _09.Album.Areas.Admin.Pages.Role
{
    public class IndexModel : PageModel
    {
        private readonly RoleManager<IdentityRole> _roleManager;

        public IndexModel(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }
        public List<IdentityRole> roles 
        {
            set;get;
        }
      
        [TempData] // Sử dụng Session lưu thông báo
        public string StatusMessage { get; set; }

        public async Task<IActionResult> OnGet()
        {

            roles = await _roleManager.Roles.ToListAsync();
            if (roles == null) roles = new List<IdentityRole>();
            return Page();
        }
    }
}
