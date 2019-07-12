using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityServer.Identity
{
    public static class Resources
    {
        public static IdentityResource[] GetIdentityResources()
        {
            return new IdentityResource[] {
                new IdentityResources.OpenId(), // Required
                new IdentityResources.Profile(),
                new IdentityResources.Email(),
                new IdentityResource {
                    Name = "role",
                    UserClaims = new List<string> {"role"}
                }
            };
        }

        public static ApiResource[] GetApiResources()
        {
            return new ApiResource[] {
                new ApiResource {
                    Name = "testAPI",
                    DisplayName = "Test API",
                    Description = "Test API surface",
                    UserClaims = new List<string> {},
                    ApiSecrets = new List<Secret> {new Secret("testApiSecret".Sha256())},
                    Scopes = new List<Scope> {
                        new Scope(IdentityServer4.IdentityServerConstants.StandardScopes.OpenId),
                        new Scope(IdentityServer4.IdentityServerConstants.StandardScopes.Profile),
                        new Scope(Scopes.ParentsRead),
                        new Scope(Scopes.ParentsWrite)
                    }
                }
            };
        }
    }
}
