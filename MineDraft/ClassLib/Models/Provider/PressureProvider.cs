namespace ClassLib.Models.Provider
{
    public class PressureProvider : ProviderBase
    {
        public PressureProvider(string id, float energyOutput, string type) : base(id, energyOutput)
        {
            Type = type.ToLower();
            EnergyOutput *= 1.5f;
        }

        public string Type { get; }
    }
}
