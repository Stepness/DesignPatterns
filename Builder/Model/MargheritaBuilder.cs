namespace Builder.Model;

public class MargheritaBuilder : IPizzaBuilder
{
    private Pizza pizza;
    
    public void CreateBase()
    {
        pizza = new Pizza();
    }

    public void AddIngredients()
    {
        pizza.ingredients.Add("Tomato");
        pizza.ingredients.Add("Mozzarella");
    }

    public Pizza GetPizza()
    {
        return pizza;
    }

}