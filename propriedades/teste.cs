using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace propriedades
{
    internal class teste
    {
        // definição de um campo.
        // é padrão usar private ao invés de public e usar underline após a declaração.

        private string _nome;
        private string _sobrenome;
        private int _idade;

        // definição de uma propriedade:
        // get é retornar o valor predisposto e privado no campo, set é atribuir um novo valor.
        // observe que é propriedade pois falta parentêses, não é método.
        // get retorna o valor do campo.
        // a propriedade que não tem o set, fica restrita, só aceita valores padrões.
        public string Nome
        {
            get
            {
                return _nome;
            }

            set
            {
                _nome = value;
            }
        }
        public string Sobrenome { get; } = "ramos";
        // o get só vai permitir que o sobrenome ramos seja lido, ele restringe.

            public int Idade
        {
            get
            {
                return _idade;
            }
            set 
            {  if (value < 18)
                {
                    Console.WriteLine("NÃO É POSSÍVEL");
                } else
                {
                    _idade = value;
                }
            }


           

        }
    }
}


    

