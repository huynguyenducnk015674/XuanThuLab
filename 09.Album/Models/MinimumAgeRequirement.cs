using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _09.Album.Models
{
    public class MinimumAgeRequirement : IAuthorizationRequirement
    {
        public int MinimumAge { get; }
        public int OpenTime { get; set; }
        public int CloseTime { get; set; }
        public MinimumAgeRequirement(int minimumAge)
        {
            MinimumAge = minimumAge;

        }
    }
}
