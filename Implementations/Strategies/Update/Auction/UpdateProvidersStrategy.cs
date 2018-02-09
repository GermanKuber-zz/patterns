using System.Collections.Generic;

namespace ConsoleApp3
{
    public class UpdateProvidersStrategy : IUpdateStrategy<Auction, UpdateProviderParameter>
    {
        public void Execute(Auction updatingEntity, UpdateProviderParameter parameter)
        {

            updatingEntity.RoundAuctionsStatus.UpdateProviders(parameter.ProvidersToUpdate);

            updatingEntity.Status = updatingEntity.Status.UpdateProviders(parameter.ProvidersToUpdate);
        }

    }

    public class UpdateProviderParameter : IParameters
    {
        public List<Provider> ProvidersToUpdate { get; set; }
        public UpdateProviderParameter(List<Provider> providersToUpdate)
        {
            ProvidersToUpdate = providersToUpdate;
        }
    }
}
