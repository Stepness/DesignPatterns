using AbstractFactory.Models;

namespace AbstractFactory.Factories;

public interface IAnimalFactory
{
    public IDog CreateDog();
    public ICat CreateCat();
}