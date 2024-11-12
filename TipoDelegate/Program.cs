using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoDelegate
{
    internal class Program
    {
        delegate void operacao (int num1, int  num2); 

        static void Main(string[] args)
        {
            matematica m = new matematica();

            operacao conta = null;


            conta += m.somar;
            conta += m.subtrair;
            conta += m.multiplicação;
            conta += m.divisao;

            // o delegate é uma espécie de variável que armazena referências colocadas em métodos.

            conta(10, 2);
            Console.ReadKey();

        }
    }
}
