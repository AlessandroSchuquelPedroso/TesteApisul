using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testeApisul.Models
{
    class ClMetodos : IElevadorService
    {
        private List<ClElevador> _lisElevador = new List<ClElevador>();
        int[] andarArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
        Char[] periodoArray = {'M','V','N'};
        char[] elevadorArray = {'A','B','C','D','E'};

        public ClMetodos(List<ClElevador> listaElevadores)
        {
            this._lisElevador = listaElevadores;
        }

        public List<int> andarMenosUtilizado()
        {
            List<int> _listaMenosUtilizados = new List<int>();
            foreach (var item in andarArray)
            {
                bool andarMenosUtilizado = _lisElevador.Exists(x => x.Andar == item);

                if (andarMenosUtilizado == false)
                {
                    _listaMenosUtilizados.Add(item);
                }
                
            }

            return _listaMenosUtilizados;
            
        }

        public List<char> elevadorMaisFrequentado()
        {
            List<char> _listElevadorMaisFrequentado = new List<char>();
    
            foreach (var item in elevadorArray)
            {
                int conta = _lisElevador.Where(x => x.Elevador.Equals(item)).Count();
                if(conta > 8)
                {
                    _listElevadorMaisFrequentado.Add(item);
                }
            }

            return _listElevadorMaisFrequentado;
        }

        public List<char> elevadorMenosFrequentado()
        {
            List<char> _listElevadorMaisFrequentado = new List<char>();

            foreach (var item in elevadorArray)
            {
                int conta = _lisElevador.Where(x => x.Elevador.Equals(item)).Count();
                if (conta < 4)
                {
                    _listElevadorMaisFrequentado.Add(item);
                }
            }

            return _listElevadorMaisFrequentado;
        }

        public float percentualDeUsoElevadorA()
        {
            throw new NotImplementedException();
        }

        public float percentualDeUsoElevadorB()
        {
            throw new NotImplementedException();
        }

        public float percentualDeUsoElevadorC()
        {
            throw new NotImplementedException();
        }

        public float percentualDeUsoElevadorD()
        {
            throw new NotImplementedException();
        }

        public float percentualDeUsoElevadorE()
        {
            throw new NotImplementedException();
        }

        public List<char> periodoMaiorFluxoElevadorMaisFrequentado()
        {
            List<char> _listPeriodoMaisFrequentado = new List<char>();
            foreach (var item in periodoArray)
            {
                int conta = _lisElevador.Where(x => x.Turno.Equals(item)).Count();
                if (conta > 5)
                {
                    _listPeriodoMaisFrequentado.Add(item);
                }
            }

            return _listPeriodoMaisFrequentado;
        }

        public List<char> periodoMaiorUtilizacaoConjuntoElevadores()
        {
            throw new NotImplementedException();
        }

        public List<char> periodoMenorFluxoElevadorMenosFrequentado()
        {
            List<char> _listElevadorMaisFrequentado = new List<char>();

            foreach (var item in periodoArray)
            {
                int conta = _lisElevador.Where(x => x.Turno.Equals(item)).Count();
                if (conta < 5)
                {
                    _listElevadorMaisFrequentado.Add(item);
                }
            }

            return _listElevadorMaisFrequentado;
        }
    }
}
