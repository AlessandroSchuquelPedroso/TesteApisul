using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testeApisul.Models;

namespace testeApisul
{
    class Program
    {
        static int AndarMenosUtilizado(ClMetodos _clmetados)
        {
            List<int> listAndaresMenosUtilizados = _clmetados.andarMenosUtilizado();
            int andarMenosUtiizado = 0;
            foreach (var item in listAndaresMenosUtilizados)
            {
                andarMenosUtiizado = item;
            }

            return andarMenosUtiizado;
        }
        static string ElevadorFrequentadoEPeriodo(ClMetodos claMetados)
        {
            string nomeElevador = String.Empty;
            string nomePeriodo = String.Empty;
            string nomes = String.Empty;
            List<Char> _listFrequentes = claMetados.elevadorMaisFrequentado();
            List<char> _lisPeriodoFrequentado = claMetados.periodoMaiorFluxoElevadorMaisFrequentado();

            nomeElevador = _listFrequentes[0].ToString();
            nomePeriodo = _lisPeriodoFrequentado[0].ToString();
            nomes = "Elevador: " + nomeElevador + ", " + "periodo: " + nomePeriodo;
            return nomes;
        }
        static string ElevadorMenosFrequentado(ClMetodos clMetados)
        {
            
            List<char> _listElevadorMenosFrequentado = clMetados.elevadorMenosFrequentado();

            string[] nomes = new string[2];

            for (int i = 0; i < _listElevadorMenosFrequentado.Count; i++)
            {
                nomes[i] =  _listElevadorMenosFrequentado[i].ToString();
            }

       

            return string.Join(",",nomes);
        }
        static string EleveadorMenosPeriodoFrequentado(ClMetodos clMetados)
        {
            List<char> _lisPeriodoMenosFrequentado = clMetados.periodoMenorFluxoElevadorMenosFrequentado();
            string[] nomes = new string[1];
            for (int i = 0; i < _lisPeriodoMenosFrequentado.Count; i++)
            {
                nomes[i] = _lisPeriodoMenosFrequentado[i].ToString();
            }
            return string.Join(",", nomes);
        }
        static void Main(string[] args)
        {

            string arquivojson = @"C:\apiJson\input.json";
            LerArquivoJson _lerArquivo = new LerArquivoJson(arquivojson);
            List<ClElevador> ListElevador = new List<ClElevador>();

            ListElevador = _lerArquivo.LerArquivo();
            ClMetodos _clMetados = new ClMetodos(ListElevador);


            Console.WriteLine($"(A) Qual é o andar menos utilizado pelos usuários: {AndarMenosUtilizado(_clMetados)}");
            Console.WriteLine($"(B) Qual é o elevador mais frequentado e o período que se encontra maior fluxo: {ElevadorFrequentadoEPeriodo(_clMetados)}");
            Console.WriteLine($"(C) Qual é o elevador menos frequentado e o período que se encontra menor fluxo: Elevador: {"{" + ElevadorMenosFrequentado(_clMetados) + "}"}, Periodo: {"{" + EleveadorMenosPeriodoFrequentado(_clMetados) + "}"}");

            Console.ReadLine();
        }
    }
}
