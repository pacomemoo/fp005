using System;
using System.Collections.Generic;
using System.Text;

namespace fp005
{
    internal class proy05TC
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Titular: ");
                string titular = Console.ReadLine();
                Console.WriteLine("Saldo inicial: ");
                decimal si = decimal.Parse(Console.ReadLine());

                CuentaBancaria cb = new CuentaBancaria("Jose", 10000);

                Console.WriteLine(cb);
                cb.retirar(1800);
                cb.retirar(2300);
                Console.WriteLine(cb);
                Console.ReadKey();

                Console.WriteLine(cb);
                cb.depositar(1800);
                cb.depositar(2300);
                Console.WriteLine(cb);
                Console.ReadKey();
            }
    }
}
