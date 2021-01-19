using _09.Album.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _09.Album.Models
{
    public class MinimumAgeHandler : AuthorizationHandler<MinimumAgeRequirement>
    {
        // UserManager được Inject qua khởi tạo
        private readonly UserManager<AppUser> _userManager;
        // Có Inject Logger để ghi log
        private readonly ILogger<MinimumAgeHandler> _logger;

        public MinimumAgeHandler(
            ILogger<MinimumAgeHandler> logger,
            AppDbContext appDbContext,
            UserManager<AppUser> userManager)
        {
            _userManager = userManager;
            _logger = logger;
        }
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, MinimumAgeRequirement requirement)
        {
            var user = _userManager.GetUserAsync(context.User).Result;
            if (user == null)
                return Task.CompletedTask;
            if (requirement.MinimumAge<18) return Task.CompletedTask;
             context.Succeed(requirement);
            return Task.CompletedTask;
        }
    }
}
