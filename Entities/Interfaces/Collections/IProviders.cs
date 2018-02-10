using System;
using System.Collections.Generic;

namespace Entities.Interfaces.Collections
{
    public interface IProviders : IComparable
    {
        IProviders Invited();
        List<Provider> Get();
    }
    public interface IMilestones
    {
       
    }
}