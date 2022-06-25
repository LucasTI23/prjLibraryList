using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaLista
{
    public class ListaFuncoes
    {
        public static double Somar(List<double> lista)
        {
            double soma = 0;
            foreach (double num in lista)
            {
                soma += num;
            }
            return soma;
        }
        public static double Media(List<double> lista)
        {
            double soma = Somar(lista);
            return soma / lista.Count;
        }

    }
}
