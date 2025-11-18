using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormApiE_Commerce
{
    public class ApiClient
    {
        public string? Token { get; set; }
        public HttpClient Client { get; private set; }

        public ApiClient()
        {
            Client = new HttpClient();
        }

        public void EstablecerToken(string token)
        {
            Token = token;
            Client.DefaultRequestHeaders.Authorization =
                new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
        }
    }
}
