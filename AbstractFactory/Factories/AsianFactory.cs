using AbstractFactory.Models;

namespace AbstractFactory.Factories;

public class AsianFactory : IAnimalFactory
{
    public IDog CreateDog()
    {
        return new AsianDoggo();
    }

    public ICat CreateCat()
    {
        return new AsianCat();
    }
}