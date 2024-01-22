using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCurrencyBalance.Entidade
{
    internal class Account
    {
        public int NumberAccount { get; set; }
        public String NameAccount { get; set; }
        public double Saldo { get; set; }

        public void Depositar(double value)
        {
            Saldo += value;
        }
        public void Sacar(double value){
            Saldo -= value;
        }

        public override string ToString()
        {
            return "Conta " + NumberAccount + " " +
                   "Titular: " + NameAccount +" "+
                   "Saldo " + "$" + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
