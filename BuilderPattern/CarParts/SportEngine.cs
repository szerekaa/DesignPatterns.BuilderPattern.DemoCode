namespace BuilderPattern.CarParts
{
    public class SportEngine
    {
        public SportEngine(int indicatedPower, int brakePower, int frictionalPower, int volumetricEfficiency, int mechanicalEfficiency, int thermalEfficiency)
        {
            IndicatedPower = indicatedPower;
            BrakePower = brakePower;
            FrictionalPower = frictionalPower;
            VolumetricEfficiency = volumetricEfficiency;
            MechanicalEfficiency = mechanicalEfficiency;
            ThermalEfficiency = thermalEfficiency;
        }

        public int IndicatedPower { get; set; }
        public int BrakePower { get; set; }
        public int FrictionalPower { get; set; }
        public int VolumetricEfficiency { get; set; }
        public int MechanicalEfficiency { get; set; }
        public int ThermalEfficiency { get; set; }
    }
}
