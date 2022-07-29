namespace AbstractFactory.Models;

public class EuropeanCat : ICat
{
    public string MakeSound()
    {
        return "Meow";
    }
}