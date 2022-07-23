
using FactoryMethod;
using FactoryMethod.Factories;
using FactoryMethod.Models;

var birdFactory = new BirdFactory();
var doggoFactory = new DogFactory();

TypeOfMovementPrinter(doggoFactory);
TypeOfMovementPrinter(birdFactory);

void TypeOfMovementPrinter(AnimalFactory animal)
{
    Console.WriteLine(animal.TypeOfMovement());
}