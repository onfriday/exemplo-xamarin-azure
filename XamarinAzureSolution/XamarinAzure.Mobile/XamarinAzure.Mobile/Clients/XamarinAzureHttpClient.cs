using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace XamarinAzure.Mobile.Clients
{
    sealed class XamarinAzureHttpClient
    {
        private static Lazy<XamarinAzureHttpClient> _Lazy = new Lazy<XamarinAzureHttpClient>(() => new XamarinAzureHttpClient());

        public static XamarinAzureHttpClient Current { get { return _Lazy.Value; } }

        private HttpClient _HttpClient;

        const string SERVER = "http://localhost:1202/";

        private XamarinAzureHttpClient()
        {
            this._HttpClient = new HttpClient();
            this._HttpClient.BaseAddress = new Uri(SERVER);
        }

        public bool Autenticado
        {
            get { return this._HttpClient.DefaultRequestHeaders.Authorization != null; }
        }

        public async void Logar(string pUsuario, string pSenha)
        {
            try
            {
                var _content = new FormUrlEncodedContent(new List<KeyValuePair<string, string>>()
                {
                    new KeyValuePair<string, string>("grant_type", "password"),
                    new KeyValuePair<string, string>("username", pUsuario),
                    new KeyValuePair<string, string>("password", pSenha),
                });

                using (var _response = await this._HttpClient.PostAsync("/token", _content))
                {
                    if (!_response.IsSuccessStatusCode)
                        throw new InvalidOperationException("");
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
