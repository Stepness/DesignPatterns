using AbstractFactory.Models;

namespace AbstractFactory.Factories;

public class EuropeanFactory : IAnimalFactory
{
    public IDog CreateDog()
    {
        return new EuropeanDoggo();
    }

    public ICat CreateCat()
    {
        return new EuropeanCat();
    }
}