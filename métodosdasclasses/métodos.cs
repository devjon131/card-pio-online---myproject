using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace métodosdasclasses
{
    internal class métodos
    {
        // método simples 

        public void cumprimentar()
        {
            Console.WriteLine("olá seja bem vindo");
        }
        // métodos com parâmetros


        public void somar(int num1, int num2)
        {
            int resultado = num1 + num2;
            Console.WriteLine("a soma é :  " + resultado);


        }

        public void apresentar(string nome, int idade)
        {
            Console.WriteLine(" meu nome é:   " + nome + " e tenho" + idade);
        }

        // passagem de parâmetros por valor.

        public void aumentarValor(int valor)
        {
            valor += 10;
            Console.WriteLine(" valor final(por valor) é: " + valor);
        }

        // passagem de parâmetros por referência.

        public void valorRef(ref int valor)
        {
            valor += 10;
            Console.WriteLine(" valor final (por referência ) é " + valor);


        }
        // método com retorno de valores.

        public string MontaNome (string nome, string sobrenome)
        {
            string nomeCompleto = nome + "   " + sobrenome;
            return nomeCompleto;



            // return é o que vai retornar o tipo declarado no public, como foi public string tem que ser retornado uma string;
            // o retorno é independente do parâmetro, os dois não são necessariamente dependentes um do outro.
        }

        public int CodigoChar (char caractere)
        {
            //int cdigo = (int)caractere;    
            // essa conversão não precisa ser feita porque já é feita de maneira implícita.

            return caractere;

        }

        public double VALORPI()
        {

            return 3.1415;
        }

        // a sobrecarga de métodos nada mais é do que dar uma assinatua diferente para o mesmo método, ou seja, parâmetros diferentes.




    }
}
