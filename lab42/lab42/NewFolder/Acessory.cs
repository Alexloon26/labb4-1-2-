using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab42.NewFolder
{
    internal class Acessory
    {
        string name;
        public int Price { get; set; }

        public Acessory(string Name, int Price)
        {
            name = Name;
            this.Price = Price;
        }
    }
}
