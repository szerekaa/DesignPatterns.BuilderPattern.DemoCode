using PizzaBuilder.Product;

namespace PizzaBuilder.Builders
{
    public abstract class PizzaBuilderBase : IBuilder
    {
        protected string size = "Medium";
        protected string dough = "Thin";
        protected string sauce = "Tomato";
        protected List<string> toppings = new();
        protected bool extraCheese = false;

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
            this.toppings.Append(toppings.ToString());
            return this;
        }

        public IBuilder AddExtraCheese(bool extraCheese)
        {
            this.extraCheese = extraCheese;
            return this;
        }

        public abstract Pizza Build();


        public void Reset()
        {
            toppings.Clear();
            extraCheese = false;
        }
    }
}
