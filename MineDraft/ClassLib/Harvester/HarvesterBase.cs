using System;

namespace ClassLib.Harvester
{
    public class HarvesterBase
    {
        protected float oreOutput;
        protected float energyRequirement;

        public HarvesterBase(string harvesterId, float oreOutput, float energyRequirement)
        {
            HarvesterId = harvesterId;
            OreOutput = oreOutput;
            EnergyRequirement = energyRequirement;
        }

        public string HarvesterId { get; set; }

        public virtual float OreOutput
        {
            get => oreOutput;
            protected set
            {
                if (value >= 0)
                {
                    oreOutput = value;
                }
                else
                {
                    throw new Exception("Ore Oreput can't be negative!");
                }
            }
        }

        public virtual float EnergyRequirement
        {
            get => energyRequirement;
            protected set {
                if (value <= 20000 && value >= 0)
                {
                    energyRequirement = value;
                }
                else
                {
                    throw new Exception("Too much energy!");
                }
            }
        }
    }
}
