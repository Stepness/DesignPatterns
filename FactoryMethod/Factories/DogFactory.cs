using FactoryMethod.Models;

namespace FactoryMethod.Factories;

public class DogFactory : AnimalFactory
{
    public override IAnimal Create()
    {
        return new Dog();
    }
}