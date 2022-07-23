namespace FactoryMethod.Models;

public class Dog : IAnimal
{
    public string Move()
    {
        return "I walk";
    }
}