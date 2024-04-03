using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab42.NewFolder
{
    internal class Bouquet
    {
        private List<Flower> flowers;
        private List<Acessory> accessories;

        public Bouquet(Acessory accessory)
        {
            flowers = new List<Flower>();
            accessories = new List<Acessory>();
            accessories.Add(accessory);
        }

        public void AddFlower(Flower flower)
        {
            flowers.Add(flower);
        }

        public void AddAccessory(Acessory accessory)
        {
            accessories.Add(accessory);
        }

        public int CalculateCost()
        {
            int totalCost = flowers.Sum(flower => flower.price) + accessories.Sum(accessory => accessory.Price);
            return totalCost;
        }

        public void SortByFreshness()
        {
            flowers = flowers.OrderBy(flower => flower.FreshLvL).ToList();
            Console.WriteLine("Сортований букет:");
            foreach (Flower flower in flowers)
            {

                Console.WriteLine(flower);
            }
        }

        public Flower FindFlowerByStemLength(int min, int max)
        {
            return flowers.FirstOrDefault(flower => flower.Steblolenth >= min && flower.Steblolenth <= max);
        }
    }
}
