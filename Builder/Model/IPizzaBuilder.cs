namespace Builder.Model;

public interface IPizzaBuilder
{
    public void CreateBase();
    public void AddIngredients();
    public Pizza GetPizza();
}