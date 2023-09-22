using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein_01
{
    public enum SizePoint
    {
        Small = 1,
        Medium =3,
        Large = 5
    }

    public class Animal
    {

        public string AnimalName { get; set; }
        public bool EatsMeat { get; set; }
        public SizePoint SizePoint { get; set;}

        public Animal(string animalName, bool eatsMeat, SizePoint sizePoint) 
        {
            AnimalName = animalName;
            EatsMeat = eatsMeat;
            SizePoint = sizePoint;
        }

    }
}
