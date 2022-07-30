using System.Xml.Schema;

namespace Builder.Model;

public class Waiter
{
    private IPizzaBuilder _pizzaBuilder;

    public void SetPizzaBuilder(IPizzaBuilder pizzaBuilder)
    {
        _pizzaBuilder = pizzaBuilder;
    }
    
    public void Make()
    {
        _pizzaBuilder.CreateBase();
        _pizzaBuilder.AddIngredients();
    }

    public Pizza GetPizza()
    {
        return _pizzaBuilder.GetPizza();
    }
}