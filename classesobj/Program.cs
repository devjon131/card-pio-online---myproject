using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace classesobj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region classes e objetos.
            minhaclasse mclasse = new minhaclasse();
            minhaclasse m2 = null;
            outraclasse outra = new outraclasse();
            #endregion 

            pessoa p1 = new pessoa();
            p1.nome = "joao";
            p1.sobrenome = " ramos";
            p1.data = 1999;


            pessoa p2 = new pessoa()
            {
                nome = "eliza",
                sobrenome = "almeida",
                data = 1998

            };
            Console.WriteLine("pessoa 1 :  " + p1.nome);
            Console.WriteLine("pessoa 1 :  " + p1.sobrenome);
            Console.WriteLine("pessoa 1 :  " + p1.data);
            p1.cumprimentar();
            Console.WriteLine();
            Console.WriteLine("pessoa 2 :  " + p2.nome);
            Console.WriteLine("pessoa 2 :  " + p2.nome);
            Console.WriteLine("pessoa 2 :  " + p2.nome);
            p2.cumprimentar();
            Console.ReadKey();

            // p1 e p2 são objetos diferentes mas provenientes da mesma classe PESSOA.
        }
    }

    class minhaclasse
    {



    }




}
