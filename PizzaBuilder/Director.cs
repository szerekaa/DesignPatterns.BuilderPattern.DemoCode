
using PizzaBuilder.Builders;

namespace PizzaBuilder
{
    public class Director
    {
        public IBuilder _builder;
        public Director(IBuilder builder) => this._builder = builder;

        public void MakeSpecialPizza(string size, string dough, string sauce, bool ExtraCheese, params string[] toppings)
        {
            _builder.SetSize(size);
            _builder.SetDough(dough);
            _builder.SetSauce(sauce);
            _builder.AddTopping(toppings);
            _builder.AddExtraCheese(ExtraCheese);
        }

        public void MakeMargherita()
        {
            _builder.SetSize("Medium");
            _builder.SetDough("Thin");
            _builder.SetSauce("Tomato");
            _builder.AddTopping("Mozzarella", "Basil");
            _builder.AddExtraCheese(false);
        }

        public void MakeMProsciutoFunghi()
        {
            _builder.SetSize("Medium");
            _builder.SetDough("Thin");
            _builder.SetSauce("Tomato");
            _builder.AddTopping("Mozzarella", "Ham", "Mushrooms");
            _builder.AddExtraCheese(false);
        }
    }
}
