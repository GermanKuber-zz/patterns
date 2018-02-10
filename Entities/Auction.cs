using System;
using System.Linq.Expressions;
using Entities.Interfaces;
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

    public class Auction : AuctionBase<Auction>, IMilestoneable<Auction>, IStatus<StatusAuction<Auction>>, IEnableToUpdate<Auction>, IEnableToAdd<Auction>, ICloneable
    {
        public RoundAuctionsStatus RoundAuctionsStatus { get; set; }

        //[Milestoneable]
        public DateTime OpeningDate { get; set; }

        public DateTime LimitOfQuestions { get; set; }

        public IAuctionMilestoneManager Milestone { get; set; } = new AuctionMilestoneManager();
        MilestoneManager<Auction> IMilestoneable<Auction>.Milestone { get ; set  ; }

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
    public abstract class MilestoneManager<TMilestoneable> : IMilestoneManager<TMilestoneable>
    {
        private IMilestones Milestones;
        private bool _somePropertyMilestoneableChange;
        public void PropertyChange<TVMilestoneable, TValue>(TVMilestoneable milestone, TValue newValue, TValue oldValue)
        {
            _somePropertyMilestoneableChange = true;
        }
    }

    public class AuctionMilestoneManager : MilestoneManager<Auction>, IAuctionMilestoneManager
    {
    }
    public interface IAuctionMilestoneManager : IMilestoneManager<Auction> { }
}
