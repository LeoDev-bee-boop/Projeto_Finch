using Projeto_Finch.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Finch.Controller
{
    public class APIController
    {
        public async Task<Bored> BuscaDadosApi()
        {
            APIModel model = new APIModel();
            return await model.BuscaDadosApi();
        }
    }
}
