using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab42.NewFolder
{
    internal class Gipsofil:Flower
    {
        double butonchikSize;
        public double ButonchikSize
        {
            set
            {
                if (value < 0.5 || value > 1.5)
                    Console.WriteLine("butonchikSize має бути в діапазоні від 0.5 до 1.5");
                else
                    butonchikSize = value;
            }
            get { return butonchikSize; }
        }

        public Gipsofil(string Name, string Colour, int FreshLvL, int Steblolenth, int Price, double ButonchikSize) : base(Name, Colour, FreshLvL, Steblolenth, Price)
        {
            this.ButonchikSize = ButonchikSize;
        }
    }
}
