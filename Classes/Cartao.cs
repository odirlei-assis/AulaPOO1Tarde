using System;

namespace ExemploPOO1Tarde.Classes
{
    public abstract class Cartao : Pagamento
    {
        public string Bandeira;
        public string Numero;
        public string Titular;
        public string Cvv;

        public string SalvarCartao(){
            Console.WriteLine("Digite a bandeira do cartão");
            Bandeira = Console.ReadLine();

            Console.WriteLine("Digite o numero do cartão");
            Numero = Console.ReadLine();

            Console.WriteLine("Digite o titular do cartão");
            Titular = Console.ReadLine();

            Console.WriteLine("Digite o CVV do cartão");
            Cvv = Console.ReadLine();

            return $"Cartão de numero {Numero} salvo com sucesso!";
        }
    }
}