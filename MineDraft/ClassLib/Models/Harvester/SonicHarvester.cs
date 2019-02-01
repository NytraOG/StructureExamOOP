namespace ClassLib.Models.Harvester
{
    public class SonicHarvester : HarvesterBase
    {
        public SonicHarvester(string harvesterId, float oreOutput, float energyRequirement, string type, int sonicFactor) : base(harvesterId, oreOutput, energyRequirement)
        {
            Type = type.ToLower();
            SonicFactor = sonicFactor;
            EnergyRequirement /= sonicFactor;
        }

        public string Type { get; set; }

        public int SonicFactor { get; set; }

        public override float EnergyRequirement
        {
            get => energyRequirement;
            protected set
            {
                if (value <= 20000 && value >= 0)
                {
                    energyRequirement = value;
                }
            }
        }
    }
}
