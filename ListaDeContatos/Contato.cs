using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeContatos
{
    internal class Contato
    {
        // declaração de variaveis.
        private string nome;
        private string sobrenome;
        private string telefone;

        // Propiedades. são os métodos "get" e "set".
        // get = leitura
        // set = definição
        // é possivel ser somente leitura, ou somente definição
        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                sobrenome = value;
            }

        }
        public string Telefone
        {
            get
            {
                return sobrenome;

            }
            set
            {
                if (value.Length == 13)
                {
                    telefone = value;

                }
                else
                {
                    telefone = "(00) 000-000";
                }
            }
        }
    }
}




    
