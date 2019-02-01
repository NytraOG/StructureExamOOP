using System.Collections.Generic;
using ClassLib.Models.Harvester;
using ClassLib.Models.ObjectGenerator;
using ClassLib.Models.Provider;

namespace ClassLib.Business_Logic
{
    public class DraftManager
    {
        private Dictionary<string, HarvesterBase> harvesterList = new Dictionary<string, HarvesterBase>();
        private Dictionary<string, ProviderBase> providerList = new Dictionary<string, ProviderBase>();

        public string RegisterHarvester(List<string> arguments)
        {
            var newHarvester = HarvesterGenerator.CreateHarvester(arguments);
            harvesterList.Add(newHarvester.HarvesterId, newHarvester);
            return "Neuen Harvester erfolgreich registriert.";
        }

        public string RegisterProvider(List<string> arguments)
        {
            var newProvider = ProviderGenerator.CreateProvider(arguments);
            providerList.Add(newProvider.ProviderId, newProvider);
            return "Neuen Provider erfolgreich registriert.";
        }

        public string Day()
        {
            return "";
        }

        public string Mode(List<string> arguments)
        {
            return "";
        }

        public string Check(List<string> arguments)
        {
            return "";
        }

        public string ShutDown()
        {
            return "";
        }
    }
}
