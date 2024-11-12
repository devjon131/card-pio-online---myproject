using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYENCAPS
{
    internal class faturamentos
    {
        private string cargo;
        private double fat;
        private int fat1 = 200000;
        private int fat2 = 50000000;
        private int somafats = 200000 + 5000000;


        public string Cargo
        {
            get { return cargo; }

            set
            {
                if (cargo == "CEO" || cargo == "ADM")
                {
                    Console.WriteLine("não é possível");
                }
                else
                {
                    Console.WriteLine("seja bem vindo, acesso aos faturamentos permitido");
                    Console.WriteLine(" o faturamento de janeiro é : " + fat1);
                    Console.WriteLine(" o faturamento de fevereiro é : " + fat2);
                    Console.WriteLine(" o lucro da empresa é :" + somafats);
                }


                }
        }
            
            public int Fat1 { get { return fat1; } }
            public int Fat2 { get { return fat2; } }
            public int Somafats { get { return somafats; } }
                
        
        
        
        }

    }







