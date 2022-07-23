namespace FactoryMethod.Models;

public class Bird : IAnimal
{
    public string Move()
    {
        return "I fly";
    }
}