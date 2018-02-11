using System;
using Entities.Interfaces.Collections;

namespace Entities
{
    public interface IMilestoneable<TMilestoneable> where TMilestoneable : IMilestoneable<TMilestoneable>
    {
        DateTime OpeningDate { get; set; }
        DateTime LimitOfQuestions { get; set; }
        IProviders Providers { get; set; }
        MilestoneManager<TMilestoneable> Milestone { get; set; }
    }
}
