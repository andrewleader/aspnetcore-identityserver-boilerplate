using IdentityServer4;
using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityServer.Identity
{
    /// <summary>
    /// Clients are applications, like a mobile app and a web app
    /// </summary>
    public static class Clients
    {
        public static Client[] GetClients()
        {
            return new Client[]
            {
                new Client()
                {
                    ClientId = "testClientUwp",
                    ClientName = "Example UWP client application",
                    AllowedGrantTypes = GrantTypes.ResourceOwnerPassword,
                    AllowOfflineAccess = true, // Offline access needed to receive refresh token
                    AllowedScopes = new string[]
                    {
                        Scopes.ParentsRead
                    },
                    RequireClientSecret = false,
                    RequireConsent = false
                }
            };
        }
    }
}
