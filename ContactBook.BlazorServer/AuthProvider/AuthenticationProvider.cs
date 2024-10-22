using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;

namespace ContactBook.BlazorServer.AuthProvider
{
    public class AuthenticationProvider : AuthenticationStateProvider
    {
        private readonly ILocalStorageService _localStorageService;
        private readonly JwtSecurityTokenHandler _jwtSecurityTokenHandler;

        public AuthenticationProvider(JwtSecurityTokenHandler jwtSecurityTokenHandler, ILocalStorageService localStorageService)
        {
            _jwtSecurityTokenHandler = jwtSecurityTokenHandler;
            _localStorageService = localStorageService;
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var user = new ClaimsPrincipal(new ClaimsIdentity());
            var getToken = await _localStorageService.GetItemAsync<string>("AuthJwtToken");
            if (getToken == null) 
            {
                return new AuthenticationState(user);
            }

            var token = _jwtSecurityTokenHandler.ReadJwtToken(getToken);
            var claims = token.Claims;
            user = new ClaimsPrincipal(new ClaimsIdentity(claims, "Jwt"));
            return new AuthenticationState(user);
        }


        public async Task LoggedIn(string email)
        {
            var usr = new ClaimsPrincipal(new ClaimsIdentity());
            var savedToken = await _localStorageService.GetItemAsync<string>("AuthJwtToken");
            var tokenContent = _jwtSecurityTokenHandler.ReadJwtToken(savedToken);
            var claims = tokenContent.Claims;
            usr = new ClaimsPrincipal(new ClaimsIdentity(claims, "jwtToken"));
            var authState = Task.FromResult(new AuthenticationState(usr));
            NotifyAuthenticationStateChanged(authState);
        }


        public async Task LoggedOut()
        {
            var usr = new ClaimsPrincipal(new ClaimsIdentity());
            var authState = Task.FromResult(new AuthenticationState(usr));
            NotifyAuthenticationStateChanged(authState);
        }

    }
}
