using System;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            conta.titular = "Gabriela";
            conta.agencia = 863;
            conta.numero = 863546;
            conta.saldo = 400;

            ContaCorrente conta2 = new ContaCorrente();
            conta2.titular = "João";
            conta2.agencia = 864;
            conta2.numero = 863557;
            conta2.saldo = 100;

            conta.Transferir(300, conta2);
            Console.WriteLine(conta.saldo);
            Console.WriteLine(conta2.saldo);

        }

        
    }
}
