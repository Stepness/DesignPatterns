using FactoryMethod.Models;

namespace FactoryMethod.Factories;

public abstract class AnimalFactory
{
    public abstract IAnimal Create();

    public string TypeOfMovement()
    {
        return Create().Move();
    }
}
