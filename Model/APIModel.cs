using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Finch.Model
{
    public class APIModel
    {
        public async Task<Bored> BuscaDadosApi()
        {
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync("http://www.boredapi.com/api/activity/");
            var jsonString = await response.Content.ReadAsStringAsync();

            Bored jsonObject = JsonConvert.DeserializeObject<Bored>(jsonString);

            return jsonObject;
        }
    }
}
