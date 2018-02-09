using System;
using System.Linq;

namespace ConsoleApp3
{
    public class UpdateProvidersStrategy : IUpdateStrategy<Auction, UpdateProviderParameter>
    {
        public void Execute(Auction updatingEntity, UpdateProviderParameter parameter)
        {
            updatingEntity.Status =  updatingEntity.Status.UpdateProviders(parameter.ProvidersToUpdate);
        }

    }
}
