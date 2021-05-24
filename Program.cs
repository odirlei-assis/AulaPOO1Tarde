﻿using System;
using ExemploPOO1Tarde.Classes;

namespace ExemploPOO1Tarde
{
    class Program
    {
        static void Main(string[] args)
        {
            bool opcaoValida = false;

            do
            {
                Console.WriteLine($@"
Escolha um mètodo de pagamento:

B - boleto
C - Credito
D - Débito
X - Cancelar pagamento
            ");

                string opcao = Console.ReadLine().ToLower();

                switch (opcao)
                {
                    case "b":
                        Boleto b = new Boleto();
                        b.Registrar();
                        opcaoValida = true;
                        break;

                    case "c":
                        Credito c = new Credito();
                        Console.WriteLine(c.SalvarCartao());
                        c.Pagar();
                        opcaoValida = true;
                        break;

                    case "d":
                        Debito d = new Debito();
                        Console.WriteLine(d.SalvarCartao());
                        d.Pagar();
                        opcaoValida = true;
                        break;

                    case "x":
                        Pagamento p = new Pagamento();
                        Console.WriteLine(p.Cancelar());
                        opcaoValida = true;
                        break;

                    default:
                        Console.WriteLine("Opção de pagamento invalida!");
                        opcaoValida = false;
                        break;
                }

            } while (!opcaoValida);
        }
    }
}
