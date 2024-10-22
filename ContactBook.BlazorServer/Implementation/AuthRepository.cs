using System.Net.Http.Headers;
using System.Text;
using System.Text.Json.Serialization;
using Blazored.LocalStorage;
using ContactBook.BlazorServer.AuthProvider;
using ContactBook.BlazorServer.DTOs;
using ContactBook.BlazorServer.EndPoints;
using ContactBook.BlazorServer.Services;
using Newtonsoft.Json;

namespace ContactBook.BlazorServer.Implementation
{
    public class AuthRepository : IAuthRepository
    {

        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ILocalStorageService _localStorageService;
        private readonly AuthenticationProvider _authenticationProvider;

        public AuthRepository(AuthenticationProvider authenticationProvider, IHttpClientFactory httpClientFactory, ILocalStorageService localStorageService)
        {
            _httpClientFactory = httpClientFactory;
            _localStorageService = localStorageService;
            _authenticationProvider = authenticationProvider;
        }


        public async Task<bool> Register(UserDTO dto)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, StaticEndpoints.AuthRegisterEndpoint)
            {
                Content = new StringContent(JsonConvert.SerializeObject(dto), Encoding.UTF8, "application/json")
            };
            var client = _httpClientFactory.CreateClient();
            HttpResponseMessage response = await client.SendAsync(request);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> Login(LoginDto dto)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, StaticEndpoints.AuthLoginEndpoint)
            {
                Content = new StringContent(JsonConvert.SerializeObject(dto), Encoding.UTF8, "application/json")
            };
            var client = _httpClientFactory.CreateClient();
            HttpResponseMessage response = await client.SendAsync(request);
            if (!response.IsSuccessStatusCode)
            {
                return false;
            }
            var content = await response.Content.ReadAsStringAsync();
            var Apiresponse = JsonConvert.DeserializeObject<ResponseDto>(content);

            await _localStorageService.SetItemAsync("AuthJwtToken", Apiresponse.TokenString);
            await _localStorageService.SetItemAsync("Email", Apiresponse.Email);
            // change auth state of app
            await ((AuthenticationProvider)_authenticationProvider).LoggedIn(Apiresponse.Email);
            client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("bearer", Apiresponse.TokenString);
            // return response.IsSuccessStatusCode;
            return true;
        }

        public async Task Logout()
        {
            await _localStorageService.RemoveItemAsync("AuthJwtToken");
            //change auth state
            await ((AuthenticationProvider)_authenticationProvider).LoggedOut();
           
        }
    }
}
