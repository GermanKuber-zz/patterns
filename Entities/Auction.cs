using System;
using System.Linq.Expressions;
using Entities.Interfaces;

namespace Entities
{
    public class Auction : AuctionBase<Auction>, IMilestoneable<Auction>, IStatus<StatusAuction<Auction>>, IEnableToUpdate<Auction>, IEnableToAdd<Auction>, ICloneable
    {
        public RoundAuctionsStatus RoundAuctionsStatus { get; set; }

        //[Milestoneable]
        public DateTime OpeningDate { get; set; }

        public DateTime LimitOfQuestions { get; set; }

        public IAuctionMilestoneManager Milestone { get; set; } = new AuctionMilestoneManager();
        MilestoneManager<Auction> IMilestoneable<Auction>.Milestone { get; set; }

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
}
