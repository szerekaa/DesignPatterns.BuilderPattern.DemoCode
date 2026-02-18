

using BuilderPattern.CarParts;

namespace BuilderPattern.Products
{
    public class Car
    {
        public Car(int seatNumber, SportEngine engine, string gPS, string tripComputer)
        {
            SeatNumber = seatNumber;
            Engine = engine;
            GPS = gPS;
            TripComputer = tripComputer;
        }

        public int SeatNumber { get; }
        public SportEngine Engine { get; }
        public string GPS { get; }
        public string TripComputer { get; }

        public override string ToString()
        {
            return "Car with seta number: " + SeatNumber + ", Engine: " + Engine.VolumetricEfficiency + ", " + GPS + TripComputer;
        }
    }
}
