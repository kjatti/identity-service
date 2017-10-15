using System.Collections.Generic;
using IdentityServer4.Models;

namespace identity_service
{

    public class ApiConfiguration
    {
        public static IEnumerable<ApiResource> ApiResources => new List<ApiResource>{
        new ApiResource("api1", "My API")
        };

        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>
    {
        new Client
        {
            ClientId = "client",

            // no interactive user, use the clientid/secret for authentication
            AllowedGrantTypes = GrantTypes.ClientCredentials,

            // secret for authentication
            ClientSecrets =
            {
                new Secret("secret".Sha256())
            },

            // scopes that client has access to
            AllowedScopes = { "api1" }
        }
    };
        }
    }

}