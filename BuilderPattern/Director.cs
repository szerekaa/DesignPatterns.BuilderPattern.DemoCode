using BuilderPattern.CarParts;

namespace BuilderPattern
{
    public class Director
    {
        Builder _builder;
        public Director(Builder builder) => this._builder = builder;

        public void MakeSpecialOrderCar(SportEngine sportEngine, string computer, string gps, int seats)
        {
            _builder.SetEngine(sportEngine)
                .SetTripComputer(computer)
                .SetGPS(gps)
                .SetSeats(seats);
        }
        public void MakeSUV()
        {
            _builder.SetEngine(new SportEngine(1000, 1000, 10, 10, 10, 10))
             .SetTripComputer("SUV computer")
             .SetGPS("Suv gps")
             .SetSeats(5);
        }

        public void MakesportsCar()
        {
            _builder.SetEngine(new SportEngine(50000, 50000, 10, 10, 10, 10))
             .SetTripComputer("sports car computer")
             .SetGPS("sports car gps")
             .SetSeats(5);

        }
    }
}
