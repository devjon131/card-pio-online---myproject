using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace métodosdasclasses
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region mét simples
          //métodos m = new métodos();
         // m.cumprimentar();
          //m.somar(10, 5);
          //m.apresentar("joao", 20);
            #endregion

            #region mét parâmetros
           //nt valor1 = 100;
          //int valor2 = 100;
            #endregion


#region mét por valor e ref 
          //m.aumentarValor(valor1);
          //m.valorRef( ref valor2 );

          //Console.WriteLine(" o valor 1 é : " + valor1);
          //Console.WriteLine(" o valor 2 é : " + valor2);
            #endregion

            #region método com retorno de valores 
            //ring nomecompleto = m.MontaNome("joao", "ramos");
          //int codigochar = m.CodigoChar('a');
         //double pi = m.VALORPI();

          //Console.WriteLine(nomecompleto);
          //Console.WriteLine(codigochar);
          //Console.WriteLine(pi);
            #endregion 

            project p = new project();
            inicio:
            Console.Write("WRITE YOUR SERVICE --- ADM --- BUSINESS --- CEO ---");
            string service = Console.ReadLine();
            Console.ReadKey();

            if (service == "adm")
            {
                Console.WriteLine("PAINEL DO ADM DISPONÍVEL --------- ");
                Console.ReadKey();

                while (true)
                {
                    Console.Write("DIGITE SEU LOGIN :       ");
                    Console.ReadLine();
                    Console.Write("DIGITE SUA SENHA :       ");
                    Console.ReadLine();
                    Console.ReadKey();
                    Console.WriteLine("\nturamentos indisponíveis -\ncesso as consultas -\ncesso aos emails -\ncesso aos feedback");
                       
                    
                }
            } else if (service == "business")
            {
                int fat1 = p.faturamentos1();
                Console.WriteLine(" o faturamento 1 está disponível e é : " + fat1);
                Console.ReadKey();

            } else if (service == "ceo")
            {
                int fat1 = p.faturamentos1();
                int fat2 = p.faturamentos2();   
                int fat3 = p.faturamentos3();
                int somafat = p.somafatura();

                Console.WriteLine("o acesso de ceo permite visto do somatório de faturas : " + somafat);
                Console.ReadKey();
            }

       
            // o cumprimentar e somar são vázios, porém somar tem parâmetros descrito na classe criada de métodos.
            Console.ReadKey();
        }
    }
}
