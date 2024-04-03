using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab42.NewFolder
{
    internal class Rose: Flower
    {
        double rosecritist;
        public double Rosecritist
        {
            set
            {
                if (value < 3 || value > 6)
                    Console.WriteLine("rosecritist має бути в діапазоні від 3 до 6");
                else
                    rosecritist = value;
            }
            get { return rosecritist; }
        }

        public Rose(string Name, string Colour, int FreshLvL, int Steblolenth, int Price, double Rosecritist) : base(Name, Colour, FreshLvL, Steblolenth, Price)
        {
            this.Rosecritist = Rosecritist;
        }
    }
}
