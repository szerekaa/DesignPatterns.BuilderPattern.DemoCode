using PizzaBuilder;
using PizzaBuilder.Builders;

IBuilder builder = new ItalianBuilder();
Director director = new Director(builder);
director.MakeSpecialPizza("small", "sourdough", "garlic", true, ["ham", "mushrooms"]);
var italianpizza = builder.Build();
Console.WriteLine(italianpizza.ToString());

IBuilder builder2 = new MexicanBuilder();
Director director2 = new Director(builder2);
director2.MakeSpecialPizza("big", "white", "tomato", true, ["pepper", "onion", "corn"]);
var mexicanpizza = builder2.Build();
Console.WriteLine(mexicanpizza.ToString());


IBuilder builder3 = new ItalianBuilder();
Director director3 = new Director(builder3);
director3.MakeMargherita();
var italianpizza3 = builder3.Build();
Console.WriteLine(italianpizza3.ToString());