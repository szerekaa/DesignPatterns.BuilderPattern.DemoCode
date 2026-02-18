using BuilderPattern.CarParts;
using BuilderPattern.Products;

namespace BuilderPattern.ConcreteBuilders
{
    internal class ManualBuilder : Builder
    {
        private int SeatNumber;
        private SportEngine Engine;
        private string GPS;
        private string TripComputer;

        public void Reset()
        {
            Engine = null;
            SeatNumber = 0;
            GPS = "";
            TripComputer = "";

        }

        public Car ReturnCar()
        {
            return new Car(SeatNumber, Engine, GPS, TripComputer);
        }

        public Manual ReturnManual()
        {
            return new Manual(SeatNumber, Engine, GPS, TripComputer);
        }

        public Builder SetGPS(string gps)
        {
            GPS = gps;
            return this;
        }

        public Builder SetTripComputer(string computer)
        {
            TripComputer = computer;
            return this;
        }

        Builder Builder.SetEngine(SportEngine engine)
        {
            Engine = engine;
            return this;

        }

        Builder Builder.SetSeats(int seatnumber)
        {
            SeatNumber = seatnumber;
            return this;
        }
    }
}
