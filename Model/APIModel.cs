using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection;
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

        public bool ValidarLogin(string usu, string senha)
        {
            var path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),"Configs", "Config.json");
            Login login;

            if (File.Exists(path))
            {
                using (StreamReader r = new StreamReader(path))
                {
                    string json = r.ReadToEnd();
                    login = JsonConvert.DeserializeObject<Login>(json);                    
                }

                if (usu == login.Usuario &&
                    senha == login.Senha)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
