using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab42.NewFolder
{
    internal class Gortenz:Flower
    {
        string VnutrishnyColor;

        public Gortenz(string Name, string Colour, int FreshLvL, int Steblolenth, int Price, string VnutrishnyColor) : base(Name, Colour, FreshLvL, Steblolenth, Price)
        {
            this.VnutrishnyColor = VnutrishnyColor;
        }
    }
}
