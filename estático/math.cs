using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estático
{ // a classe estática serve para acessar uma classe sem precisar instancia-la, sendo acesso direto aos seus membros e métodos.
    // a classe estática não precisa do NEW.
    internal static class math
    {
        public static int taxa;

        public static int adicionar(int valor)
        
        {
            return valor + taxa;


        }

        public static int diminuir(int valor)
        {
            return valor - taxa;
        }
          



    }
}
