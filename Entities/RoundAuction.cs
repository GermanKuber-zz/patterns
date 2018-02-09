using Entities.Interfaces;

namespace Entities
{
    public class RoundAuction : AuctionBase<RoundAuction>, IStatus<StatusAuction<RoundAuction>>, IEnableToUpdate<RoundAuction>, IEnableToAdd<RoundAuction>
    {

        private readonly Auction auction;

        public RoundAuction(Auction auction)
        {
            this.auction = auction;
        }


        public void Add<TParameters>(IAddStrategy<RoundAuction, TParameters> updateStrategy, TParameters parameters) where TParameters : IParameters
        {
            base.Add<TParameters>(this, updateStrategy, parameters);
        }

        public void Update<TParameters>(IUpdateStrategy<RoundAuction, TParameters> updateStrategy, TParameters parameters) where TParameters : IParameters
        {
            base.Update<TParameters>(this, updateStrategy, parameters);

        }

      
    }
}
