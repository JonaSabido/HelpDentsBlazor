using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace HelpDentsProyecto.Data.Auth
{
    public class AuthStateProviderFalse : AuthenticationStateProvider
    {
        public async override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            await Task.Delay(3000);
            var identity = new ClaimsIdentity();

            return await Task.FromResult(new AuthenticationState(new ClaimsPrincipal(identity)));
        }
    }
}
