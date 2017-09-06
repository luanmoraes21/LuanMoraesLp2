using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Empresa
{
    class Empregado : Funcionário
    {
        public int DataEntrada { get; set; }
        public Gerente preda { get; set; }
    }
}
