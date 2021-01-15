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
            
            //false, pois conta e conta2 apontam para diferentes referências
            Console.WriteLine(conta == conta2);
            

            
            conta = conta2;
            //true, agora apontam para o mesmo objeto
            Console.WriteLine(conta == conta2);

            conta.saldo = 300;
            Console.WriteLine(conta.saldo);
            Console.WriteLine(conta2.saldo);



        }

    
    }
}
