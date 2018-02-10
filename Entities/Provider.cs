using System;

namespace Entities
{
    public class Provider : IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ProviderStatusEnum Status { get; set; }

        public int CompareTo(object obj)
        {
            var providerToCompare = (Provider)obj;
            if (providerToCompare.Id == Id) return 0;
            return 1;
        }
    }


}
