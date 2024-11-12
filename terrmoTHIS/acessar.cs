using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace terrmoTHIS
{
    internal class acessar
    {

        string senha = "abc123";

        public bool login(string senha)
        {
            return this.senha ==senha;

            // para diferenciar a senha da classe e a senha do parâmetro se utiliza o termo THIS, ele faz referência a classe em questão.
        }


    }
}
