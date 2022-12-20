using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Finch
{
    public class Login
    {
        [JsonProperty("usuario")]
        public string Usuario { get; set; }
        [JsonProperty("senha")]
        public string Senha { get; set; }
    }
}
