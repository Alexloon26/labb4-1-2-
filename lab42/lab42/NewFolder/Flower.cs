using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab42.NewFolder
{
    internal class Flower
    {
        string name;
        internal int price;
        string colour;
        int freshLvL;
        int steblolenth;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int FreshLvL
        {
            set
            {
                if (value < 1 || value > 5)
                    Console.WriteLine("freshLvL має бути в діапазоні від 1 до 5");
                else
                    freshLvL = value;
            }
            get { return freshLvL; }
        }

        public int Steblolenth
        {
            set
            {
                if (value < 30 || value > 60)
                    Console.WriteLine("steblolenth має бути в діапазоні від 30 до 60");
                else
                    steblolenth = value;
            }
            get { return steblolenth; }
        }

        public Flower(string Name, string Colour, int FreshLvL, int Steblolenth, int Price)
        {
            name = Name;
            price = Price;
            colour = Colour;
            freshLvL = FreshLvL;
            steblolenth = Steblolenth;
        }
    }
}

