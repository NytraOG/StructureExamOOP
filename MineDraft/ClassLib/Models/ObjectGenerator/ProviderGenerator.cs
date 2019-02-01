using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLib.Models.Provider;

namespace ClassLib.Models.ObjectGenerator
{
    public class ProviderGenerator
    {
        public static ProviderBase CreateProvider(List<string> arguments)
        {
            var type = arguments[2].ToLower();

            switch (type)
            {
                case "solar": return new SolarProvider(arguments[0], float.Parse(arguments[1]), type);
                case "pressure": return new PressureProvider(arguments[0], float.Parse(arguments[1]), type);
                default: throw new NotImplementedException("Unbekannter Providertyp! Versuchen Sie 'Solar' oder 'Pressure'.");
            }
        }
    }
}
