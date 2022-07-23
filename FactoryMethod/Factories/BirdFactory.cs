using FactoryMethod.Models;

namespace FactoryMethod.Factories;

public class BirdFactory : AnimalFactory
{
    public override IAnimal Create()
    {
        return new Bird();
    }
}