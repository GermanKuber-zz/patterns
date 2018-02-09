using System.Collections.Generic;

namespace ConsoleApp3
{
    public class Auction :AuctionBase, IStatus<StatusAuction>, IEnableToUpdate<Auction>, IEnableToAdd<Auction>
    {

        public Auction(IAuctionStatusFactory factory)
        {
            Status = factory.Make(AuctionStatusTypeEnum.New, this);
        }

        public void ChangeStatus(StatusAuction newStatus)
        {
            this.Status = newStatus;
        }

        public void Update<TParameters>(IUpdateStrategy<Auction, TParameters> updateStrategy, TParameters parameters) where TParameters : IParameters
        {
            updateStrategy.Execute(this, parameters);
        }

        public void Add<TParameters>(IAddStrategy<Auction, TParameters> addStrategy, TParameters parameters) where TParameters : IParameters
        {
            addStrategy.Execute(this, parameters);
        }
    }
}
