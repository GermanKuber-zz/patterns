namespace ConsoleApp3
{
    public class RoundAuction : AuctionBase, IStatus<StatusAuction>, IEnableToUpdate<RoundAuction>, IEnableToAdd<RoundAuction>
    {

        private readonly Auction auction;

        public RoundAuction(Auction auction)
        {
            this.auction = auction;
        }

        public StatusAuction Status { get; set; }

        public void Add<TParameters>(IAddStrategy<RoundAuction, TParameters> updateStrategy, TParameters parameters) where TParameters : IParameters
        {
            throw new System.NotImplementedException();
        }

        public void ChangeStatus(StatusAuction newStatus)
        {
            throw new System.NotImplementedException();
        }

        public void Update<TParameters>(IUpdateStrategy<RoundAuction, TParameters> updateStrategy, TParameters parameters) where TParameters : IParameters
        {
            throw new System.NotImplementedException();
        }
    }
}
