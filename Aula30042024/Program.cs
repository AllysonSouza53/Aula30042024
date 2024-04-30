using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula30042024
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //    String[] nome = { "João", "Maria", "Pedro" };
            //    Console.WriteLine("Digite  um numero de 0 a 2: ");
            //    int i = int.Parse(Console.ReadLine());
            //    Console.WriteLine(" O nome selecionado foi: " +
            //    nome[i]);
            //    Console.ReadKey();
            //--------------------------------------------------------------------------------

            Console.Write("Digite o numero de um mês: ");
            String[] mes = { "ERROr. Mês não existente", "Janeiro", " Fevereiro", "Março", "Abril","Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("Mês escolhido: "+ mes[i]);
            Console.ReadKey();

        }
    }
}
