using IdentityServer4.Models;
using IdentityServer4.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace IdentityServer.Identity
{
    public class ResourceOwnerPasswordValidator : IResourceOwnerPasswordValidator
    {
        public async Task ValidateAsync(ResourceOwnerPasswordValidationContext context)
        {
            // Dummy mock code
            switch (context.UserName)
            {
                case "bob":
                    if (context.Password == "bobpwd")
                    {
                        context.Result = new GrantValidationResult("514", "password");
                    }
                    break;

                case "jill":
                    if (context.Password == "jillpwd")
                    {
                        context.Result = new GrantValidationResult("515", "password");
                    }
                    break;

                default:
                    break;
            }

            if (context.Result == null)
            {
                context.Result = new GrantValidationResult(TokenRequestErrors.InvalidRequest);
            }
        }
    }
}
