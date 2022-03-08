using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlinkSwap2
{
    public class Usuario
    {
        public string Name { get; set; }
        public double[] Coins { get; set; } = new double[4];
        public string Email { get; set; }
        public string Wallet { get; set; }
        public string Cedula { get; set; }
        public double Amount { get; set; }
        
        public Usuario()
        {
            Name = "";
            Coins[0] = 0.17; Coins[1] = 1.5; Coins[2] = 0.17; Coins[3] = 0;
            Email = "";
            Wallet = "";
            Cedula = "";
            Amount = 0;
        }
        public Usuario(string name, double[] coin, string email, string wallet,string cedula, double amount)
        {
            Name = name;
            Coins = coin;
            Email = email;
            Wallet = wallet;
            Cedula = cedula;
            Amount = amount;
        }

    }
}

