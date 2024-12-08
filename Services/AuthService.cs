using System.Net.Http.Json;

namespace AppDIGESETT.Services
{
    public class AuthService
    {
        private readonly HttpClient httpClient;

        public AuthService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<bool> LoginAsync(Credenciales credenciales)
        {
            var response = await httpClient.PostAsJsonAsync("api/auth/", credenciales);
            return response.IsSuccessStatusCode;
        }
    }

    public class Credenciales
    {
        public string Cedula { get; set; } ="";
        public string Clave { get; set; } = "";
    }
}
