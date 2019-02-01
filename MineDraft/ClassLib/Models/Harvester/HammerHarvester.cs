namespace ClassLib.Models.Harvester
{
    public class HammerHarvester : HarvesterBase
    {
        private string type;

        public HammerHarvester(string harvesterId, float oreOutput, float energyRequirement, string type) : base(harvesterId, oreOutput, energyRequirement)
        {
            Type = type;
            EnergyRequirement *= 2;
            OreOutput *= 3;
        }

        public string Type { get; set; }

        public override float EnergyRequirement
        {
            get => energyRequirement;
            protected set => energyRequirement = value;
        }

        public override float OreOutput
        {
            get => oreOutput;
            protected set => oreOutput = value;
        }
    }
}
