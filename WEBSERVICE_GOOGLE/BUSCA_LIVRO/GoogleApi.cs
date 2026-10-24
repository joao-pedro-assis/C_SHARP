using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
namespace BUSCA_LIVRO
{
    public class GoogleApi
    {
        public async Task<string> WebService(string url) 
        {
            using (var cliente = new HttpClient()) 
            {
                cliente.BaseAddress = new Uri(url);
                cliente.DefaultRequestHeaders.Clear();
                var Resposta = await cliente.GetAsync(url);
                if (Resposta.IsSuccessStatusCode)
                {
                    var dados = await Resposta.Content.ReadAsStringAsync();
                    return dados.ToString();
                }
                else return String.Empty;
            }
        }
        public async Task<dynamic> Books (string cod)
        {
            string url = String.Format("https://www.googleapis.com/books/v1/volumes?q=isbn:{0}",cod);
            try
            {
                dynamic dados;
                string json = await WebService(url);
                if (json != string.Empty)
                {
                    dados = JsonConvert.DeserializeObject(json);
                    return dados;
                }
                else return null;             
            }
            catch (Exception)
            {
                return null;
            }
            
        }
    }
}
