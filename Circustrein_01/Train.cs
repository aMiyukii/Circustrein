using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein_01
{
    public class Train
    {
        public List<Animal> Animals = new List<Animal>();
        public List<Train> TrainWagons = new List<Train>();
        public int Points {  get; set; }

        public bool TryAddAnimal(Animal animal)
        {
            if (CanAddAnimal(animal))
            {
                Animals.Add(animal);
                Points += (int)animal.SizePoint;
                return true;
            }
            return false;
        }

        private bool CanAddAnimal(Animal animal)
        {
            if (animal.EatsMeat)
            {
                foreach (var inputtedAnimal in Animals)
                {
                    if ((int)inputtedAnimal.SizePoint >= (int)animal.SizePoint)
                    {
                        return false;
                    }
                }   
            }

            if (Points + (int)animal.SizePoint <= 10)
            {
                return true;
            }
            return false;
        }
    }
}
