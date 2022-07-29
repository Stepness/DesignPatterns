using AbstractFactory.Factories;
using AbstractFactory.Models;

const Breeds breedConfiguration = Breeds.Asian;


IAnimalFactory animalFactory = breedConfiguration switch
{
    Breeds.Asian => new AsianFactory(),
    Breeds.European => new EuropeanFactory()
};

CreateAnimals(animalFactory);




void CreateAnimals(IAnimalFactory factory)
{
    Console.WriteLine(factory.CreateCat().MakeSound());
    Console.WriteLine(factory.CreateDog().MakeSound());
}