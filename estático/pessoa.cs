﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estático
{
    internal class pessoa
    {
        public static int MaiorIdade = 18;


        public string nome;
        public int idade;
        public void apresentar() 
        
        {
            Console.WriteLine("olá eu sou : " + nome);
        }

        public static int calcularidade(int anonascimento)
        {
            return DateTime.Now.Year - anonascimento;
        }



    }
}
