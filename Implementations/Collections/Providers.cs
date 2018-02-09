using System.Collections.Generic;
using System.Linq;
using Entities;
using Entities.Interfaces.Collections;

namespace Implementations.Collections
{
    public class Providers : IProviders
    {
        private readonly IEnumerable<Provider> _proviers;

        public Providers(IEnumerable<Provider> proviers)
        {
            _proviers = proviers;
        }

        public IProviders Invited() => new Providers(_proviers.Where(x => x.Status == ProviderStatusEnum.Invited));

        public List<Provider> Get() => _proviers?.ToList();

    }
}