using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace testeApisul.Models
{
    /// <summary>
    /// faz a leitura do arquivo
    /// </summary>
    class LerArquivoJson
    {
        private string _arquivo;

        public LerArquivoJson(string arquivo)
        {
            this._arquivo = arquivo;
        }

        public List<ClElevador> LerArquivo()
        {
            string json = File.ReadAllText(_arquivo);
            List<ClElevador> _listElevador = JsonConvert.DeserializeObject<List<ClElevador>>(json);
            return _listElevador;
        }
    }
}
