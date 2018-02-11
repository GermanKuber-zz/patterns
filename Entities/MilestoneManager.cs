using Entities.Interfaces.Collections;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Entities
{
    public abstract class MilestoneManager<TMilestoneable> : IMilestoneManager<TMilestoneable, MilestoneContainer>
    {
        private bool _somePropertyMilestoneableChange;
        public List<MilestoneContainer> Milestones { get; protected set; }

        public IEnumerable<MilestoneContainer> Get() => Milestones;

        public void PropertyChange<TVMilestoneable, TValue>(TVMilestoneable milestone, TValue newValue, TValue oldValue)
        {
            _somePropertyMilestoneableChange = true;

            if (Milestones == null) Milestones = new List<MilestoneContainer>();

            var json = JsonConvert.SerializeObject(milestone);
            Milestones.Add(new MilestoneContainer(json));
        }
    }
}
