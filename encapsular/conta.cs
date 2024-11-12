using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace encapsular
{
    internal class conta
        // encapsular é separar de forma isolada, esconder ou omitir dados importantes do código geral.
    {
        private string _cliente;
        private double _saldo;
        private double _taxa = 10;
        // a taxa ta privada exatamente pra modificar somente quem tem acesso a classe.

        public string Cliente {  get { return _cliente; } 
            set 
            
            { 
                if (value != "ramos" && value != "paulo")
                {
                    _cliente = "visitantes";
                    _saldo = 0;
                }else 
                {
                    _cliente = value;
                }

                
            }
        }
        public double Saldo { get { return _saldo; } 
          private  set 
            {
                _saldo = value;

            }
        
        }


        public void Sacar(double valor)
        {

            // o  encapsulamento permite ter acesso ao método e fazer modificações diretas em taxas específicas.
            //valor += 10;
            valor += _taxa;
            _saldo -= valor;
        }

        public void Depositar(double valor)
        { 
            _saldo += valor;
        }



    }
}
