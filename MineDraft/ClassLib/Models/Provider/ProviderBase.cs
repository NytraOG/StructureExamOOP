namespace ClassLib.Models.Provider
{
    public class ProviderBase
    {
        private string providerId;
        private float energyOutput;

        public ProviderBase(string id, float energyOutput)
        {
            ProviderId = id;
            EnergyOutput = energyOutput;
        }

        public string ProviderId { get; set; }

        public float EnergyOutput
        {
            get => energyOutput;
            set
            {
                if (value >= 0 && value <= 10000)
                {
                    energyOutput = value;
                }
            }
        }
    }
}
