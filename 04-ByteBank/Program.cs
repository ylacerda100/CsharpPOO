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

            Console.WriteLine(conta.saldo);
            conta.Sacar(200);
            Console.WriteLine(conta.saldo);

        }
    }
}
