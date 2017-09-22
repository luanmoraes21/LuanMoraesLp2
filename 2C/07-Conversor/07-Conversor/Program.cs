using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Conversor
{
    class Program
    {
        static void Main(string[] args)
        {
            int escolheu = -1;

            while (escolheu != 0)
            {
                Console.WriteLine("Qual tipo de conversão será utilizado? ");

                Console.WriteLine("1- Kg > g");
                Console.WriteLine("2- g > Kg");
                Console.WriteLine("3- Kg > T");
                Console.WriteLine("4- T > Kg");
                Console.WriteLine("5- °C > °F");
                Console.WriteLine("6- °F > °C");
                Console.WriteLine("7- °K > °F");

                escolheu = int.Parse(Console.ReadLine());

                Console.WriteLine("Informe o valor a ser convertido: ");
                double valnum = double.Parse(Console.ReadLine());

                switch (escolheu)
                {
                    case 1:
                        Console.WriteLine("{0:0.0} g", Conversor.KgParaG(valnum));
                        break;
                    case 2:
                        Console.WriteLine("{0:0.0} kg", Conversor.GParaKg(valnum));
                        break;
                    case 3:
                        Console.WriteLine("{0:0.0} T", Conversor.KgParaT(valnum));
                        break;
                    case 4:
                        Console.WriteLine("{0:0.0} kg", Conversor.TParaKg(valnum));
                        break;
                    case 5:
                        Console.WriteLine("{0:0.0} ºF", Conversor.CparaF(valnum));
                        break;
                    case 6:
                        Console.WriteLine("{0:0.0} ºC", Conversor.FparaC(valnum));
                        break;
                    case 7:
                        Console.WriteLine("{0:0.0} ºC", Conversor.KparaF(valnum));
                        break;
        }
    }
}
