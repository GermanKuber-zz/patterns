using Entities;
using Entities.Interfaces;
using Implementations.Strategies.Update.Auction;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Implementations.Decorators.Strategies
{
    public class AuctionMilestoneUpdateOpeningDecorator : AuctionMilestoneDecoratorBase<UpdateOpeningParameter>
    {
        public override void Execute(Auction updatingEntity, UpdateOpeningParameter parameter)
        {
            Auction previousState = (Auction)updatingEntity.Clone();
            base.Execute(updatingEntity, parameter);

            if (updatingEntity.OpeningDate != previousState.OpeningDate)
                updatingEntity.Milestone.PropertyChange(previousState, updatingEntity.OpeningDate, previousState.OpeningDate);

        }
    }
    public class AuctionMilestoneDecoratorBase<TParameters> : AuctionDecorator<TParameters> where TParameters : IParameters
    {

       
    }
}
