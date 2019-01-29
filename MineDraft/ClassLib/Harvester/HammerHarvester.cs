using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Harvester
{
    public class HammerHarvester : HarvesterBase
    {
        private string type;

        public HammerHarvester(string harvesterId, float oreOutput, float energyRequirement) : base(harvesterId, oreOutput, energyRequirement)
        {
            Type = "hammer";
            EnergyRequirement = energyRequirement * 2;
            OreOutput = oreOutput * 3;

        }

        public string Type { get; }

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
