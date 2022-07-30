using Builder.Model;

var pizzaBuilder = new BufalaBuilder();

var waiter = new Waiter();
waiter.SetPizzaBuilder(pizzaBuilder);
waiter.Make();

var pizza = waiter.GetPizza();

foreach (var ingredient in pizza.ingredients)
{
    Console.WriteLine(ingredient);
}
