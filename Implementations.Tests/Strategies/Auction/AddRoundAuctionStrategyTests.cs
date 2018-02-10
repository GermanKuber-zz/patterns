using Entities;
using Entities.Interfaces;
using Implementations.RoundAuctionsStatus;
using Implementations.Strategies.Update.Auction;
using System.Linq;
using Xunit;

namespace Implementations.Tests
{
    public class AddRoundAuctionStrategyTests : AuctionStrategyTestsBase<AddRoundAuctionParameter>
    {

        public AddRoundAuctionStrategyTests()
        {
            Sut = AuctionStrategyFactory.Make<AddRoundAuctionParameter>(StrategyTypeEnum.AddRound);

        }


        [Fact]
        public void Shuuld_Starts_With_RoundAuctionsStatusHasNotRounds()
        {
            Assert.True(Auction.RoundAuctionsStatus is RoundAuctionsStatusHasNotRounds);

        }
        [Fact]
        public void Should_Add_One_RoundAuction()
        {
            var roundAuction = new RoundAuction(Auction);

            var parameter = new AddRoundAuctionParameter(roundAuction);
            Sut.Execute(Auction, parameter);

            Assert.Equal(1, Auction.RoundAuctionsStatus.Rounds.Count());
        }


        [Fact]
        public void Shuuld_Be_RoundAuctionsStatusHastRounds_After_To_Add_First_RoundAuction()
        {
            var roundAuction = new RoundAuction(Auction);

            var parameter = new AddRoundAuctionParameter(roundAuction);
            Sut.Execute(Auction, parameter);

            Assert.True(Auction.RoundAuctionsStatus is RoundAuctionsStatusHasRounds);

        }


    }
}
