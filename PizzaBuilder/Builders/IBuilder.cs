using PizzaBuilder.Product;

namespace PizzaBuilder.Builders
{
    public interface IBuilder
    {
        public IBuilder SetSize(string size);

        public IBuilder SetDough(string dough);

        public IBuilder SetSauce(string sauce);

        public IBuilder AddTopping(params string[] toppings);

        public IBuilder AddExtraCheese(bool extraCheese);

        public Pizza Build();
        public void Reset();
    }
}
