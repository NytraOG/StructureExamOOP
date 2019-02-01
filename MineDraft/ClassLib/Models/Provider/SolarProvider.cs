namespace ClassLib.Models.Provider
{
    public class SolarProvider : ProviderBase
    {
        public SolarProvider(string id, float energyOutput, string type) : base(id, energyOutput)
        {
            Type = type.ToLower();
        }

        public string Type { get; }
    }
}
