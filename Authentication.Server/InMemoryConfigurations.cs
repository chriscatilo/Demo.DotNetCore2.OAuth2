using IdentityServer4.Models;
using IdentityServer4.Test;
using System.Collections.Generic;

namespace Authentication.Server
{
    public static class InMemoryConfigurations
    {
        public static IEnumerable<ApiResource> ApiResources()
            => new[]
            {
                new ApiResource("demo-oauth2", "Demo OAuth2")
            };

        public static IEnumerable<Client> Clients()
            => new[]
            {
                new Client
                {
                    ClientId = "demo-oauth2",
                    ClientSecrets = new[] {new Secret("secret".Sha256())},
                    AllowedGrantTypes = GrantTypes.ResourceOwnerPasswordAndClientCredentials,
                    AllowedScopes = new[] {"demo-oauth2"}

                }
            };

        public static IEnumerable<TestUser> Users()
            => new[]
            {
                new TestUser
                {
                    SubjectId = "test-user-1",
                    Username = "test@foo.bar",
                    Password = "test-user-password"

                }
            };
    }
}
