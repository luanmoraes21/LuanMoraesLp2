using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Empresa
{
    class Gerente:Funcionário
    {
          public Gerente (double salario)
        {
            this.salario = (salario * 15) / 100;
        }
    }
}
