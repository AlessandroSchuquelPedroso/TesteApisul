using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Helpers;

namespace testeApisul.Models
{
    class ClElevador
    {
        [JsonProperty("andar")]
        public int Andar { get; set; }

        [JsonProperty("elevador")]
        public char Elevador { get; set; }

       [JsonProperty("turno")]
        public char Turno { get; set; }
    }
}
