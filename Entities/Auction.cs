using System;
using System.Linq.Expressions;
using Entities.Interfaces;
using Entities.Interfaces.Collections;

namespace Entities
{
    public interface IMilestoneable
    {

    }
    [AttributeUsage(AttributeTargets.Property, Inherited = false)]
    public class MilestoneableAttribute : Attribute
    {
        public MilestoneableAttribute()
        {
        }
        public override bool Match(object obj)
        {
            return base.Match(obj);
        }

    }
    public class Auction : AuctionBase<Auction>, IStatus<StatusAuction<Auction>>, IEnableToUpdate<Auction>, IEnableToAdd<Auction>, ICloneable
    {
        public RoundAuctionsStatus RoundAuctionsStatus { get; set; }

        [Milestoneable]
        public DateTime OpeningDate { get; set; }


        public DateTime LimitOfQuestions { get; set; }

        public MilestoneManager Milestone { get; set; }

        public Auction(IAuctionStatusFactory auctionStatusFactory,
            IRoundAuctionStatusFactory roundAuctionStatusFactory,
             AuctionStatusTypeEnum initialAuctionStatus)
        {

            Status = auctionStatusFactory.Make(initialAuctionStatus, this);

            RoundAuctionsStatus = roundAuctionStatusFactory.Make(RoundAuctionStatusTypeEnum.HasNotRound, this);
        }



        public void Add<TParameters>(IAddStrategy<Auction, TParameters> updateStrategy, TParameters parameters) where TParameters : IParameters
        {
            base.Add<TParameters>(this, updateStrategy, parameters);
        }

        public void Update<TParameters>(IUpdateStrategy<Auction, TParameters> updateStrategy, TParameters parameters) where TParameters : IParameters
        {
            base.Update<TParameters>(this, updateStrategy, parameters);
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
    public class MilestoneManager
    {
        private IMilestones Milestones;
        private bool _somePropertyMilestoneableChange;
        public void PropertyChange<T>(Expression<Func<T, string>> propertyWasChanged)
        {
            _somePropertyMilestoneableChange = true;
        }
        public bool SomePropertyMilestoneableChange()
        {
            throw new NotImplementedException();
        }

        public void ResetMilestoneable()
        {
            _somePropertyMilestoneableChange = false;
        }
    }
}
