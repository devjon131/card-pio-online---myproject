using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace terrmoTHIS
{
    internal class Program
    {
        static void Main(string[] args)
        {

            acessar a = new acessar();

            if (a.login("abc123"))
            {
                Console.WriteLine("acess alowed");
                Console.ReadKey();
            } else
            {
                Console.WriteLine("acess denied");
            }
        }
    }
}
