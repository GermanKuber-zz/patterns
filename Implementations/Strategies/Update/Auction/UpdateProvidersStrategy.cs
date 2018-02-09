using System.Collections.Generic;
using Entities;
using Entities.Interfaces;
using Entities.Interfaces.Collections;

namespace Implementations.Strategies.Update.Auction
{
    public class UpdateProvidersStrategy : IUpdateStrategy<Entities.Auction, UpdateProviderParameter>
    {
        public void Execute(Entities.Auction updatingEntity, UpdateProviderParameter parameter)
        {

            updatingEntity.RoundAuctionsStatus.UpdateProviders(parameter.Providers.Invited());

            updatingEntity.Status = updatingEntity.Status.UpdateProviders(parameter.Providers.Get());
        }

    }

    public class UpdateProviderParameter : IParameters
    {
        public IProviders Providers { get; set; }
        public UpdateProviderParameter(IProviders providers)
        {
            Providers = providers;
        }
    }
}
