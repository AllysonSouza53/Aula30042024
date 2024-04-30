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

            //Console.Write("Digite o numero de um mês: ");
            //String[] mes = { "ERROr. Mês não existente", "Janeiro", " Fevereiro", "Março", "Abril","Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };
            //int i = int.Parse(Console.ReadLine());
            //Console.WriteLine("Mês escolhido: "+ mes[i]);
            //Console.ReadKey();
            //-----------------------------------------------------------------------------------

            //String[] nome = new String[3];
            //Console.Write("Digite o primeiro nome: ");
            //nome[0] = Console.ReadLine();
            //Console.Write("Digite o segundo nome: ");
            //nome[1] = Console.ReadLine();
            //Console.Write("Digite o terceiro nome: ");
            //nome[2] = Console.ReadLine();

            //Console.WriteLine("primeiro nome: "+ nome[0]);
            //Console.WriteLine("segundo nome: "+ nome[1]);
            //Console.WriteLine("terceiro nome: " + nome[2]);

            //Console.ReadKey();
            //--------------------------------------------------------------------------------------

            //String[] nome = new String[5];

            //for (int i = 0; i<=4;i++)
            //{
            //    Console.Write("digite o nome do aluno: ");
            //    nome[i] = Console.ReadLine();
            //}

            //for(int j = 0; j<=4;j++)
            //{
            //    Console.WriteLine(" Aluno: "+ nome[j]);
            //}
            //Console.ReadKey();
            //---------------------------------------------------------------------------------------

            //entrada

            String[] nome = new String[5];
            double[] v = new double[5];
            double[] vc = new double[5];
            int i = 0;

            for ( int c = 0; c <1;)
            {
            Console.Write("Digite o primeiro nome: ");
            nome[i] = Console.ReadLine();
            Console.Write("Valor de vendas: ");
            v[i] = double.Parse(Console.ReadLine());

            //processamento
            if (v[i] <= 20000.00)
            {
                vc[i] = v[i] * (5 / 100);

            }
                else if (v[i] <= 40000.00)
                  {
                      vc[i] = v[i] * (6 / 100);
                  }
                    else 
                        {
                               vc[i] = v[i] * (7 / 100);
                        }

                Console.Clear();

                Console.Write("Deseja continuar: ");
                string r = Console.ReadLine().ToUpper();
                 
                if (r == "N")
                {
                    c++;
                }

                Console.Clear();
                i++;
            }
            for ( int s = 1 ; s<=i; s++)
            {
                Console.WriteLine("Vendendor: " + nome[s]);
                Console.WriteLine("Comição: " + vc[s]);
                Console.WriteLine("------------------------------------------------------------------------");
            }

            Console.ReadKey();

        }
    }
}
