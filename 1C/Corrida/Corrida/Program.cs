using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corrida
{
    class Program
    {
        static void Main(string[] args)
        {
            int numcomp;
            double menortempo = 67179097;
            string vencedor = "";


            Console.WriteLine("são quantos competidores?");
            numcomp = int.Parse(Console.ReadLine());


            Competidor[] competidores = new Competidor[numcomp];

            for (int i = 0; i < numcomp; i++)
            {

                Console.WriteLine("Qual é o nome do seu competidor");
                competidores[i] = new Competidor();
                competidores[i].nome = Console.ReadLine();

            }


            for (int i = 0; i < numcomp; i++)
            {

                Console.WriteLine("Qual é o primeiro tempo do competidor");
                competidores[i].t1 = double.Parse(Console.ReadLine());
            }


            for (int i = 0; i < numcomp; i++)
            {

                Console.WriteLine("Qual é o segundo tempo do competidor");
                competidores[i].t2 = double.Parse(Console.ReadLine());
            }


            for (int i = 0; i < numcomp; i++)
            {

                Console.WriteLine("Qual é o terceiro tempo do competidor");
                competidores[i].t3 = double.Parse(Console.ReadLine());
            }

            for (int i = 0; i < numcomp; i++)
            {
                if (competidores[i].CalcularTempo() < menortempo)
                {
                    vencedor = competidores[i].nome;
                    menortempo = competidores[i].CalcularTempo();
                }
            }

            Console.WriteLine("O vencedor foi {0}", vencedor);
        }
    }
}
