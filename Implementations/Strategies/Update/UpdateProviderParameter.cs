using System.Collections.Generic;

namespace ConsoleApp3
{
    public class UpdateProviderParameter : IParameters
    {
        public List<Provider> ProvidersToUpdate { get; set; }
        public UpdateProviderParameter(List<Provider> providersToUpdate)
        {
            ProvidersToUpdate = providersToUpdate;
        }
    }
}
