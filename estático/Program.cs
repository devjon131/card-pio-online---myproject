using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estático
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region classes estáticas
            //math.taxa = 10;
            //int valor = math.adicionar(100);

            //onsole.WriteLine("valor 1 é: " + valor);
            //onsole.ReadKey();

            #endregion

            pessoa.MaiorIdade = 21;

            pessoa p1 = new pessoa();

            p1.nome = "joao";
            p1.idade = pessoa.calcularidade(1999);

            Console.WriteLine(p1.nome);
            Console.WriteLine(p1.idade); 

            Console.ReadKey();


        }
    }
}
