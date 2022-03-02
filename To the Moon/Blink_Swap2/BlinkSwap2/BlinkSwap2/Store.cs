using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlinkSwap2
{
    
    public class Store
    {
        public string User { get; set; }
        public string Ruc { get; set; }
        public string Email { get; set; }
        public string Wallet { get; set; }
        public double Amount { get; set; }

        public Store()
        {
            User = "";
            Ruc = "";
            Email = "";
            Wallet = "";
            Amount = 0;
        }
        public Store(string user, string ruc, string email, string wallet, double amount)
        {
            User = user;
            Ruc = ruc;
            Email = email;
            Wallet = wallet;
            Amount = amount; 
        }

      

    }
}
