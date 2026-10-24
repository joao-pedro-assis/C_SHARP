using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Runtime.Remoting;
using System.Security.Cryptography.X509Certificates;

namespace API_CEP
{
    public class ApiCep
    {
        public async Task<string> WebService(string url)
        {
            using (var cliente = new HttpClient())
            {
                cliente.BaseAddress = new Uri(url);
                cliente.DefaultRequestHeaders.Accept.Clear();
                var Resposta = await cliente.GetAsync(url);
                if (Resposta.IsSuccessStatusCode)
                {
                    var dados = await Resposta.Content.ReadAsStringAsync();
                    return dados.ToString();
                }
                else return String.Empty;
            }
            
        }
        public async Task<dynamic> Pesquisar(string cep)
        {
            try
            {
                string site = String.Format("https://viacep.com.br/ws/{0}/json/", cep);
                string json = await WebService(site);
                if (json == string.Empty) return null;
                return JsonConvert.DeserializeObject<dynamic>(json);

            }
            catch (Exception) 
            {
                return null;
            }
        }
    }
}
