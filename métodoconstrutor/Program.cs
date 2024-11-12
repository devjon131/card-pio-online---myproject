using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace métodoconstrutor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            pessoa p1 = new pessoa();

            Console.WriteLine(p1.nome);
            Console.WriteLine(p1.sobrenome);
            Console.WriteLine(p1.nascimento);
            Console.WriteLine(p1.idade);

            Console.ReadKey();
        }
    }
}
