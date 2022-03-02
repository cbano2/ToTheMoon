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
        public string Coin { get; set; }
        public string Email { get; set; }
        public string Wallet { get; set; }
        public double Amount { get; set; }

        public Usuario()
        {
            Name = "";
            Coin = "";
            Email = "";
            Wallet = "";
            Amount = 0;
        }
        public Usuario(string name, string coin, string email, string wallet, double amount)
        {
            Name = name;
            Coin = coin;
            Email = email;
            Wallet = wallet;
            Amount = amount;
        }

    }
}

