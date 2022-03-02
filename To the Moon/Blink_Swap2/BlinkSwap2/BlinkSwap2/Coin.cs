using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlinkSwap2
{
    public class Coin
    {
        public double Btc { get; set; }
        public double Eth { get; set; }
        public double Sol { get; set; }

        public Coin()
        {
            Btc = 44.666;
            Eth = 3.007;
            Sol = 103.98;

        }
        public Coin(double btc, double eth, double sol)
        {
            Btc = btc;
            Eth = eth;
            Sol = sol;
        }

    }
}
