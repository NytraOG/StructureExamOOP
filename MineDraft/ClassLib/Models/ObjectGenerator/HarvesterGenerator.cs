using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLib.Models.Harvester;

namespace ClassLib.Models.ObjectGenerator
{
    public class HarvesterGenerator
    {
        public static HarvesterBase CreateHarvester(List<string> arguments)
        {
            var type = arguments[3].ToLower();

            switch (type)
            {
                case "hammer": return new HammerHarvester(arguments[0], float.Parse(arguments[1]), float.Parse(arguments[2]), type);
                case "sonic": return new SonicHarvester(arguments[0], float.Parse(arguments[1]), float.Parse(arguments[2]), type, int.Parse(arguments[4]));
                default: throw new NotImplementedException("Unbekannter Harvestertyp! Probieren Sie 'Hammer' oder 'Sonic'.");
            }
        }
    }
}
