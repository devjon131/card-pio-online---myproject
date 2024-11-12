using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesobj
{
    internal class pessoa
    {
// atributos ou campos da classe
        public string nome;
        public string sobrenome;
        public int data;


// void é método simples.
        public void cumprimentar()
        {

            Console.WriteLine(" olá, eu sou:" + nome + "  " + sobrenome);


        }


    }
}
