using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Empresa
{
    class Gerente : Funcionário
    {
          public void pagamento (double salario)
        {
            this.salario = (salario * 15) / 100;
        }
           public int registro { get; set; }

        public Gerente(int registro) : base(registro)

          {
              this.registro = registro;
          }

       
    }
}
