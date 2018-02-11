using System.Collections;
using System.Collections.Generic;

namespace Entities
{
    public interface IMilestoneManager<TMilestoneable, TMilestone>
    {
        IEnumerable<TMilestone> Get();
        void PropertyChange<TVMilestoneable, TValue>(TVMilestoneable milestone, TValue newValue, TValue oldValue);
    }
}