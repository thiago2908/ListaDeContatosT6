using ListaDeContatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Principal;
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
                nome = value;
            }

        }

        public string Sobrenome
        {
            set
            {
                sobrenome = value;
            }
            get
            {
                return sobrenome;
            }
        }

        public Contato()
        {
            Nome = "Thiago";
            Sobrenome = "rocha";
            Telefone = "(11) 95555-666";
        }
        //sobrecargab do método construido.

        public Contato(string nome, string sobrenome, string telefone)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Telefone = telefone;
        }
        // Tostring() pertence a classe object.
        // todas as classes são filhas de object (Herança)
        // "override" sobrenome o metodo

        public string Telefone
        {
            get
            {
                return telefone;

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
        //construtor de classe.
        //todas aas classes são filhas de object (Herança)
        //"overrrido" sobrenome o metodo da classe pai (polimorfismo).

        public override string ToString()
        {
            //Inicializa a variavel como vazia.
            string saida = string.Empty;
            saida += String.Format("{0} {1}", Nome, Sobrenome);
            saida += String.Format("({0}) {1}-{2}");
            Telefone.Substring(0, 2);
            Telefone.Substring(2, 5);
            Telefone.Substring(7, 4);

            return saida;


        }
    }
}












