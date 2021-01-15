using System;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            conta.titular = "Gabriela";
            conta.agencia = 863;
            conta.numero = 863546;


            ContaCorrente conta2 = new ContaCorrente();
            conta.titular = "Gabriela";
            conta.agencia = 863;
            conta.numero = 863546;
            
            Console.WriteLine(conta == conta2);
        
        }
    }
}
