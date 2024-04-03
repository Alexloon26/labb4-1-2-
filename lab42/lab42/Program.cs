using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
namespace lab42.NewFolder
{
    class Program
    {
        static void Main()
        {

            Rose Rose1 = new Rose("RoseGaujard", "Red", 5, 40, 90, 6);
            Gortenz Gerbera1 = new Gortenz("GortenzPink,", "Pink", 4, 30, 70, "Purple");
            Gipsofil Gipsofil1 = new Gipsofil("GipsoElegant", "Purple", 3, 50, 140, 1);


            Acessory Acces1 = new Acessory("Бант", 30);


            Bouquet bouquet = new Bouquet(Acces1);
            bouquet.AddFlower(Rose1);
            bouquet.AddFlower(Gerbera1);
            bouquet.AddFlower(Gipsofil1);


            Console.WriteLine("Вартiсть букету: $" + bouquet.CalculateCost());


            bouquet.SortByFreshness();


            Flower foundFlower = bouquet.FindFlowerByStemLength(49, 51);
            if (foundFlower != null)
            {
                Console.WriteLine("Знайдено квiтку: " + foundFlower.Name);
            }
            else
            {
                Console.WriteLine("Квiтка не знайдена.");
            }
        }
    }
}