using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJETO_50_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor = CARDÁPIO_ONLINE.valormínimo(5);
            int PF = CARDÁPIO_ONLINE.valorpf(20);
            int pfit = CARDÁPIO_ONLINE.valorfit(30);
            int refr = CARDÁPIO_ONLINE.REFRI(5);
            int sobrem = CARDÁPIO_ONLINE.sobrem(12);
            string login = CARDÁPIO_ONLINE.login("joaomeiida@gmail.com");
            string endereço = CARDÁPIO_ONLINE.end("rua 529, casa 56 - conj ceará II");
            int somaPF = CARDÁPIO_ONLINE.somat(25);
            int chavepix = CARDÁPIO_ONLINE.chavepix(00422617325);



            Console.WriteLine("BEM VINDO AO QUICK CHOOSE! - FAÇA SEU PEDIDO. ");
            Console.WriteLine("RESTAURANTE ABERTO DE 09:00 AS 21:00.");
            Console.WriteLine("O PEDIDO MÍNIMO ACEITO É :" + valor + "$");
            Console.ReadKey();
        inicio:
            Console.WriteLine("PRATO FEITO" + PF + "$");
            Console.WriteLine("PRATO FIT" + pfit + "$");
            Console.WriteLine("REFRIGERANTES APARTIR DE " + refr + "$");
            Console.WriteLine("SOBREMESAS APARTIR DE " + sobrem + "$");
            Console.ReadKey();
            Console.Write("DIGITE O SEU PEDIDO:       ");
            string pedido = Console.ReadLine();
            if (pedido == "PRATO FEITO")
            {
                Console.Write("ESCOLHA SUA PROTEÍNA\n" + "FRANGO\n" + "PEIXE ASSADO\n" + "CARNE ASSADA\n");
                string proteína = Console.ReadLine();
                Console.Write("ESCOLHA SUA GUARNIÇÃO:\n" + "BAIÃO\n" + "ARROZ\n" + "MACARRONADA\n");
                string guarni = Console.ReadLine();
                Console.Write("ESCOLHA SEU ACOMPANHAMENTO:\n" + "FAROFA\n" + "SALADA VERDE\n" + "VINAGRETE\n");
                string acomp = Console.ReadLine();
                Console.WriteLine("O SEU PEDIDO É : " + proteína + "," + guarni + " E " + acomp);
                Console.WriteLine("O TOTAL DO SEU PEDIDO + TAXA É : " + somaPF);
                Console.ReadKey();

                Console.Write(" IR PARA A COMPRA ----");
                string ir = Console.ReadLine();
                if (ir == "ir")
                {
                login:
                    Console.Write("CONFIRME SEU LOGIN\n:" + login);
                    if (login == "joaomeiida@gmail.com")
                    {
                        Console.WriteLine("\nENDEREÇO CADASTRADO\n:" + endereço);
                        Console.ReadKey();
                        Console.Write("finalizar compra? ");
                        string finalizar = Console.ReadLine();
                        if (finalizar == "sim")
                        {
                            Console.Write("TIPO DE PAGAMENTO : DÉBITO -- CRÉDITO -- PIX -- NA ENTREGA ");
                            string pag = Console.ReadLine();
                            if (pag == "DÉBITO")
                            {
                                Console.Write("SELECIONE O CARTÃO:   VISA -- MASTER -- ELO -- ALIMENTAÇÃO");
                                string cartao = Console.ReadLine();
                                Console.WriteLine("COMPRA FINALIZADA - VOCÊ SERÁ REDIRECIONADO.");

                            }
                            else if (pag == "CRÉDITO")
                            {
                                Console.Write("SELECIONE O CARTÃO:   VISA -- MASTER -- ELO -- ALIMENTAÇÃO");
                                string cartao = Console.ReadLine();
                                Console.WriteLine("COMPRA FINALIZADA - VOCÊ SERÁ REDIRECIONADO.");
                            }
                            else if (pag == "PIX")
                            {
                                Console.WriteLine("A CHAVE PIX É O CPF DO ESTABELECIMENTO : " + chavepix);
                                Console.WriteLine("ENVIAR COMPROVANTE AO WHATSAPP.");
                            }
                            else if (pag == "NA ENTREGA")
                            {
                                Console.Write("TROCO PARA ? ");
                                int troco = int.Parse(Console.ReadLine());
                                Console.WriteLine("VOCÊ SERÁ REDIRECIONADO");
                            }
                            else { goto login; }
                        } else
                        {
                            Console.WriteLine("CONTINUAR COMPRANDO ---");
                            goto inicio;
                        }

                    }





                }
            }
        }
    