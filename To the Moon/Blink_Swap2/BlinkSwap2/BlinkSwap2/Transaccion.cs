using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlinkSwap2
{
    
    public class Transaccion
    {
        public string Entrada { get; set; }
        public string Salida { get; set; }
        public string Time { get; set; }
        public double Amount { get; set; }

        public Transaccion()
        {
            Entrada = "";
            Salida = "";
            Time = "";
            Amount = 0;
        }
        public Transaccion(string entrada, string salida, string time, string wallet, double amount)
        {
            Entrada = entrada;
            Salida = salida;
            Time = time;
            Amount = amount;
        }
    }
}
