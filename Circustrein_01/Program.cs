using Circustrein_01;
using System.Drawing;

List<Animal> animals = new List<Animal>
{
    new Animal("Bird", false, SizePoint.Small),
    new Animal("Rabbit", false, SizePoint.Small),
    new Animal("Fox", true, SizePoint.Small),
    new Animal("Snake", true, SizePoint.Small),
    new Animal("Monkey1", false, SizePoint.Medium),
    new Animal("Monkey2", false, SizePoint.Medium),
    new Animal("Monkey3", false, SizePoint.Medium),
    new Animal("Monkey4", false, SizePoint.Medium),
    new Animal("Donkey", false, SizePoint.Medium),
    new Animal("Wolf1", true, SizePoint.Medium),
    new Animal("Wolf2", true, SizePoint.Medium),
    new Animal("Horse", false, SizePoint.Large),
    new Animal("Tiger", true, SizePoint.Large),
    new Animal("Elephant1", false, SizePoint.Large),
    new Animal("Elephant2", false, SizePoint.Large),
    new Animal("Elephant3", false, SizePoint.Large),
    new Animal("Lion", true, SizePoint.Large),
    new Animal("Bear", true, SizePoint.Large)
};

List<Train> trainWagons = new List<Train>();

foreach (var animal in animals)
{
    bool added = false;
    foreach(var wagon in trainWagons)
    {
        if (wagon.TryAddAnimal(animal))
        {
            added = true; break;
        }
    }
    if (!added)
    {
        var newWagon = new Train();
        newWagon.TryAddAnimal(animal);
        trainWagons.Add(newWagon);
    }
}

int wagonNumber = 1;
foreach (var wagon in trainWagons)
{
    Console.WriteLine($"Wagon {wagonNumber}:");
    foreach (var animal in wagon.Animals)
    {
        Console.WriteLine($"- {animal.AnimalName} ({animal.SizePoint})");
    }
    wagonNumber++;
}

