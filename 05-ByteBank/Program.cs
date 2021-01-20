using System;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
           


            ContaCorrente conta1 = new ContaCorrente();
            conta1.titular = new Cliente();
            conta1.titular.nome = "Gabriela";
            conta1.titular.cpf = "123.456.789-10";
            conta1.titular.profissao = "Advogada";
            conta1.agencia = 863;
            conta1.numero = 863123;
            conta1.saldo = 100;
            
            
        }
    }
}
