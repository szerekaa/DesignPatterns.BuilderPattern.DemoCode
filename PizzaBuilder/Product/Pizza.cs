namespace PizzaBuilder.Product
{
    public class Pizza
    {
        public string Size { get; }
        public string dough { get; }
        public string sauce { get; }
        public List<string> Toppings { get; }
        public bool ExtraCheese { get; } = false;

        public Pizza(string size, string dough, string sauce, List<string> toppings, bool extraCheese)
        {
            Size = size;
            this.dough = dough;
            this.sauce = sauce;
            Toppings = toppings;
            ExtraCheese = extraCheese;
        }

        public override string ToString()
        {
            return Size + " " + dough + " pizza with " + sauce + ", " + string.Join(", ", Toppings) +
                (ExtraCheese == true ? " and extra cheese. " : ".");
        }
    }
}