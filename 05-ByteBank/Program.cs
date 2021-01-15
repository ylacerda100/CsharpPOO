using System;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente c1 = new Cliente();
            c1.nome = "Gabriela";
            c1.cpf = "123.456.789-10";
            c1.profissao = "Advogada";


            ContaCorrente conta1 = new ContaCorrente();
            conta1.titular = c1;
            
        }
    }
}
