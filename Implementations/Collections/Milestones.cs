using System.Collections.Generic;
using System.Linq;
using Entities;
using Entities.Interfaces.Collections;

namespace Implementations.Collections
{
    public class Milestones : IMilestones
    {
        private readonly IEnumerable<Milestone> _milestones;

        public Milestones(IEnumerable<Milestone> milestones)
        {
            _milestones = milestones;
        }



    }
}