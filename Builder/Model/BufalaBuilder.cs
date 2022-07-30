namespace Builder.Model;

public class BufalaBuilder : IPizzaBuilder
{
    private Pizza pizza;
    
    public void CreateBase()
    {
        pizza = new Pizza();
    }

    public void AddIngredients()
    {
        pizza.ingredients.Add("Tomato");
        pizza.ingredients.Add("Bufala");
    }
    
    public Pizza GetPizza()
    {
        return pizza;
    }
}