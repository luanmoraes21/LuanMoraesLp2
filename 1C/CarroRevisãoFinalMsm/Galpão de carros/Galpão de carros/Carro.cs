using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galpão_de_carros
{
        class Carro
        {
        public string modelo;
        public double quilometragem;
        public double potencia, novo;
        public int ano;
      
        public  string classificar()
        {
            string classe, potencial;

            if (quilometragem <= 5000)
                classe = "novo";

            else if (quilometragem > 5000 && quilometragem < 30000)
                classe = "seminovo";

            else
                classe = "velho";

            if (potencia < 120)
                potencial = "popular";

            else if (potencia >= 120 && potencia <= 200)

                potencial = "forte";

            else
                potencial = "poteeeente";

            return string.Format("seu carro é um {0}-{1}-{2}", modelo, classe, potencial);
}
     }
}
