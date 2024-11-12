using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsular
{
    internal class Program
    {
        static void Main(string[] args)
        {

            conta c = new conta();

            c._cliente = "RAMOS";
           // c._saldo = 100;

            // operação depósito 
            double valor = 100;
            c.Depositar(valor);

            //operação saque
            
            double valor2 = 50;
            c.Sacar(valor2); 

            // saldo atual do usuário

            Console.WriteLine("o cliente é:" + c._cliente);
            Console.WriteLine("o saldo é:" + c._saldo);
            Console.ReadKey();

           

        }
    }
}
