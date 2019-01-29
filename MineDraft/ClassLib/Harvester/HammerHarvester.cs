using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Harvester
{
    public class HammerHarvester : HarvesterBase
    {
        public HammerHarvester(string harvesterId, float oreOutput, float energyRequirement) : base(harvesterId, oreOutput, energyRequirement)
        {
        }

        public override float EnergyRequirement
        {
            get => energyRequirement;
            protected set => energyRequirement = value * 2;
        }

        public override float OreOutput
        {
            get => oreOutput;
            protected set => oreOutput = value * 3;
        }
    }
}
