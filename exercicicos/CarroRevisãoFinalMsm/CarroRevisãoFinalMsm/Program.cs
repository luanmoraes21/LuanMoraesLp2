using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarroRevisãoFinalMsm
{
    class Program
    {
        struct Carro
        {
          
            public string Modelo;
            public int Ano;
            public int Potencia;
            public double Quilometragem;

        }



        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("quantos carros são?");
            n = Convert.ToInt32(Console.ReadLine());

            Carro[] luan = new Carro[n];

            string chamar;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Modelo");
                luan[i].Modelo = Console.ReadLine();

                Console.WriteLine("Quilometragem");
                luan[i].Quilometragem = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Cavalos");
                luan[i].Potencia = Convert.ToInt32(Console.ReadLine());

                chamar = classificar(luan[i]);

                Console.WriteLine(classificar(luan[i]));
            }
        }
        public static string classificar(Carro luan)
        {
            string classe, potencial;

            if (luan.Quilometragem <= 5000)
                classe = "novo";

            else if (luan.Quilometragem > 5000 && luan.Quilometragem < 30000)
                classe = "seminovo";

            else
                classe = "velho";

            if (luan.Potencia < 120)
                potencial = "popular";

            else if (luan.Potencia >= 120 && luan.Potencia <= 200)

                potencial = "forte";

            else
                potencial = "poteeeente";

            return string.Format("seu carro é um {0}-{1}-{2}", luan.Modelo, classe, potencial);
        }
    }
}
