using Entities;
using Entities.Interfaces;
using Implementations.RoundAuctionsStatus;
using Implementations.Strategies.Update.Auction;
using System.Linq;
using Xunit;

namespace Implementations.Tests
{
    public class DeleteRoundAuctionStrategyTests : AuctionStrategyTestsBase<DeleteRoundAuctionParameter>
    {

        public DeleteRoundAuctionStrategyTests()
        {
            Sut = AuctionStrategyFactory.Make<DeleteRoundAuctionParameter>(StrategyTypeEnum.DeleteRound);

        }

        [Fact]
        public void Should_Delete_One_RoundAuction()
        {
            var roundAuctionToDelete = new RoundAuction(Auction);
            AddOneRoundAuctionInAuction(new RoundAuction(Auction));
            AddOneRoundAuctionInAuction(new RoundAuction(Auction));
            AddOneRoundAuctionInAuction(roundAuctionToDelete);

            var parameter = new DeleteRoundAuctionParameter(roundAuctionToDelete);

            Sut.Execute(Auction, parameter);

            Assert.Equal(2, Auction.RoundAuctionsStatus.Rounds.Count());
        }

        [Fact]
        public void Should_Change_RoundAuctionsStatusHasNotRounds_When_Delete_Last_RoundAuction()
        {
            var parameter = new DeleteRoundAuctionParameter(new RoundAuction(Auction));

            Sut.Execute(Auction, parameter);
            Assert.True(Auction.RoundAuctionsStatus is RoundAuctionsStatusHasNotRounds);

        }

        [Fact]
        public void Should_be_RoundAuctionsStatusHasRounds_When_Has_RoundAuctions()
        {
            AddOneRoundAuctionInAuction(new RoundAuction(Auction));

            Assert.True(Auction.RoundAuctionsStatus is RoundAuctionsStatusHasRounds);

        }

        private void AddOneRoundAuctionInAuction(RoundAuction roundAuction)
        {
            var addRoundAuctionStrategy = AuctionStrategyFactory.Make<AddRoundAuctionParameter>(StrategyTypeEnum.AddRound);
            var parameter = new AddRoundAuctionParameter(roundAuction);

            addRoundAuctionStrategy.Execute(Auction, parameter);
        }
    }
}
