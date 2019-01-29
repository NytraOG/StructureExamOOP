using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Harvester
{
    public class SonicHarvester : HarvesterBase
    {
        public SonicHarvester(string harvesterId, float oreOutput, float energyRequirement, int sonicFactor) : base(harvesterId, oreOutput, energyRequirement)
        {
            SonicFactor = sonicFactor;
        }

        public int SonicFactor { get; set; }

        public override float EnergyRequirement
        {
            get => energyRequirement;
            protected set
            {
                if (value <= 20000 && value >= 0)
                {
                    energyRequirement = value / SonicFactor;
                }
            }
        }
    }
}
