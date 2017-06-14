using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galpão_de_carros
{
    class Program
    {
      
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("quantos carros são?");
            n = Convert.ToInt32(Console.ReadLine());

            Carro[] luan = new Carro[n];

            
            for (int i = 0; i < n; i++)

            {
                luan[i] = new Carro();

                Console.WriteLine("\nInforme o modelo do carro");
                luan[i].modelo = Console.ReadLine();

                Console.WriteLine("\nInforme o número de km rodados");
                luan[i].quilometragem = double.Parse(Console.ReadLine());

                Console.WriteLine("\nInforme a potência do motor");
                luan[i].potencia = double.Parse(Console.ReadLine());

                Console.WriteLine("\nInforme o ano de fabricação");
                luan[i].ano = int.Parse(Console.ReadLine());        
            }
       
            
            for (int i = 0; i < n; i++)
           
            {
                Console.WriteLine(luan[i].Classificar());
            }
         }          
    }         
}



    

