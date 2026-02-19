using PizzaBuilder.Product;

namespace PizzaBuilder.Builders
{
    internal class ItalianBuilder : PizzaBuilderBase
    {
        public override Pizza Build()
        {
            if (toppings.Count > 10 && size == "Small")
                throw new Exception("Too many topppings for a small pizza");
            Pizza pizza = new(size, dough, sauce, toppings, extraCheese);
            Reset();
            return pizza;
        }
    }
}
