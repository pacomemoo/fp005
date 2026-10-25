using System;
using System.Collections.Generic;
using System.Text;

namespace fp005
{
    internal class CuentaBancaria
    {
        private string titulo;
        private decimal saldo;

        public CuentaBancaria(string titular, decimal saldo)
        {
            this.Titular = titular;
            this.Saldo = saldo;
        }

        public string Titular { get => titulo; set => titulo = value; }
        public decimal Saldo { get => saldo; set => saldo = value; }

        public override string ToString()
        {
            return $"Titular:{Titular} saldo:{Saldo}";
        }

        public void retirar(decimal monto)
        {
            if (monto > saldo)
            {
                Console.WriteLine("Saldo insuficiente");
                return;
            }

            saldo = saldo - monto;

        }

        public void depositar(decimal monto)
        {
            if (monto < 0)
            {
                Console.WriteLine("Saldo suficiente");
                return;
            }

            saldo = saldo + monto;

        }
    }
}