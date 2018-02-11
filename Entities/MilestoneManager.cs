using Entities.Interfaces.Collections;

namespace Entities
{
    public abstract class MilestoneManager<TMilestoneable> : IMilestoneManager<TMilestoneable>
    {
        private IMilestones Milestones;
        private bool _somePropertyMilestoneableChange;
        public void PropertyChange<TVMilestoneable, TValue>(TVMilestoneable milestone, TValue newValue, TValue oldValue)
        {
            _somePropertyMilestoneableChange = true;
        }
    }
}
