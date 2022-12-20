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
        //Instânciando classe
        APIModel _model = new APIModel();

        public async Task<Bored> BuscarDadosApi()
        {
            return await _model.BuscaDadosApi();
        }

        public bool ValidarLogin(string usu, string senha)
        {
            return _model.ValidarLogin(usu, senha);
        }
    }
}
