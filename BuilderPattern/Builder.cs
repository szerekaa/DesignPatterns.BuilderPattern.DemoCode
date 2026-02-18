using BuilderPattern.CarParts;

namespace BuilderPattern
{
    public interface Builder
    {
        public void Reset();
        public Builder SetSeats(int seatnumber);
        public Builder SetEngine(SportEngine engine);
        public Builder SetTripComputer(string computer);
        public Builder SetGPS(string gps);
    }
}
