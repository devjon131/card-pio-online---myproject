using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYENCAPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            faturamentos m = new faturamentos();

            Console.Write("DIGITE O CARGO OCUPADO NA EMPRESA:   ");
            string cargo = Console.ReadLine();

            if (cargo == "CEO")
            {
                m.Cargo = cargo;
                Console.ReadKey();
            }
            else
            {
                m.Cargo = cargo;
                Console.ReadKey();
            }

        }
    }
}
