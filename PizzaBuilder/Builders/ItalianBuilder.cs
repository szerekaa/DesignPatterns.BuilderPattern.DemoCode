using PizzaBuilder.Product;

namespace PizzaBuilder.Builders
{
    internal class ItalianBuilder : IBuilder
    {
        public string size;
        public string dough;
        public string sauce;
        public List<string> Toppings = new();
        public bool ExtraCheese;

        public IBuilder SetSize(string size)
        {
            this.size = size;
            return this;
        }

        public IBuilder SetDough(string dough)
        {
            this.dough = dough;
            return this;
        }

        public IBuilder SetSauce(string sauce)
        {
            this.sauce = sauce;
            return this;
        }

        public IBuilder AddTopping(params string[] toppings)
        {
            foreach (string topping in toppings)
            {
                Toppings.Add(topping);
            }
            return this;
        }

        public IBuilder AddExtraCheese(bool extraCheese)
        {
            ExtraCheese = extraCheese;
            return this;
        }

        public Pizza Build()
        {
            if (Toppings.Count > 10 && size == "Small")
                throw new Exception("Too many topppings for a small pizza");
            Pizza pizza = new(size, dough, sauce, Toppings, ExtraCheese);
            Reset();
            return pizza;
        }

        public void Reset()
        {
            Toppings = new();
            ExtraCheese = false;
        }
    }
}
