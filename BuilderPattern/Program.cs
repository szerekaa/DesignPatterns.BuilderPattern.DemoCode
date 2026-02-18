using BuilderPattern;
using BuilderPattern.ConcreteBuilders;

//Client

CarBuilder builder = new CarBuilder();
var director = new Director(builder);
director.MakesportsCar();
var car = builder.ReturnCar();
var manual = builder.ReturnManual();

Console.WriteLine(car.ToString());
Console.WriteLine(manual.ToString());

