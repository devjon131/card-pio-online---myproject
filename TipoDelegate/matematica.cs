using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoDelegate
{
    internal class matematica
    {

        public void somar(int n1, int n2)
        {
            Console.WriteLine("a soma é : " + (n1 + n2));   

        }
        public void subtrair(int n1, int n2) 
        
        {
         Console.WriteLine(" a subtração é : " + (n1 - n2));
        
        }
        public void multiplicação(int n1, int n2)

        {

            Console.WriteLine(" a multiplicação é : " + (n1 * n2));
        }

        public void divisao(int n1, int n2) 
        
        { 
        Console.WriteLine(" a divisão é : " + (n1 / n2));   


        
        }
  
    }  
}
