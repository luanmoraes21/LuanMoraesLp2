using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Empresa
{
    class Funcionário
    {
        public string email, nome;
        public double salario;
        private int registro;
        public int cpf
 
        {
            get { return this.cpf; }

        }

        public int nroRegistro
        
        {
            get { return this.registro; }

        }

          public Funcionário (string nome)
        {
            this.nome = nome;
        }

        public Funcionário (int registro)
          {
              this.registro = registro;
          }











    }
}
