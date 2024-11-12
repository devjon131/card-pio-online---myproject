using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace métodoconstrutor
{
    internal class pessoa
    {


        public string nome;
        public string sobrenome;
        public int nascimento;
        public int idade;

            // o método construtor sempre recebe o nome da classe que ele esta sendo utilizado.
            // é um método que é sempre PUBLIC.
            // o método construtor é uma espécie de resposta padrão para um objeto que será instanciado no método main.


        public pessoa ()
        {

            nome = "desconhecido";
            sobrenome = "nenhum";
            nascimento = 0;
            idade = 0;

 
        }
        public pessoa(string nome, string sobrenome, int nascimento)
        {

            this.nome = nome;
            this.sobrenome = sobrenome;
           this.nascimento = nascimento;
            this.idade = 


        }   

        private int idade ()
        {
            return 2024 - nascimento;
        }
    }   



}
