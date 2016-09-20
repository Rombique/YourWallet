using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace YourWallet
{
    class DataClass
    {
        public int id { get; set; }
        public string bankName { get; set; }
        public float buyUSD { get; set; }
        public float sellUSD { get; set; }
        public float buyEUR { get; set; }
        public float sellEUR { get; set; }
        public float buyRUB { get; set; }
        public float sellRUB { get; set; }
        public DateTime date { get; set; }
    }
}
