using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace BeyondCampaign.API.Models
{
    public class User : IdentityUser<int>
    {
        public ICollection<UserRole> UserRoles { get; set; }
    }
}