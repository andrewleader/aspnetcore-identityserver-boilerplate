using IdentityServer4.Models;
using IdentityServer4.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityServer.Identity
{
    public class UserProfileService : IProfileService
    {
        public async Task GetProfileDataAsync(ProfileDataRequestContext context)
        {
            // TODO: Get the account info and return the data
            if (context.RequestedClaimTypes.Any())
            {
                //if (context.)
            }
        }

        public async Task IsActiveAsync(IsActiveContext context)
        {
            // Determines if user should be allowed to complete login
            // TODO: Should check that the account exists (it could have been deleted)
            
            context.IsActive = true;
        }
    }
}
