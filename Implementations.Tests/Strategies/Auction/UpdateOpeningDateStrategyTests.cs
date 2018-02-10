using Entities;
using Entities.Interfaces;
using Implementations.RoundAuctionsStatus;
using Implementations.Strategies.Update.Auction;
using System;
using System.Linq;
using Xunit;

namespace Implementations.Tests
{
    public class UpdateOpeningDateStrategyTests : AuctionStrategyTestsBase<UpdateOpeningParameter>
    {

        public UpdateOpeningDateStrategyTests()
        {
            Sut = AuctionStrategyFactory.Make<UpdateOpeningParameter>(StrategyTypeEnum.UpdateOpeningDate);
        }


        [Fact]
        public void Should_Add_One_RoundAuction()
        {
            var dateToUpdate = new DateTime(1888, 2, 2);
            var roundAuction = new RoundAuction(Auction);

            var parameter = new UpdateOpeningParameter(dateToUpdate);
            Sut.Execute(Auction, parameter);

            Assert.Equal(dateToUpdate, Auction.OpeningDate);
        }

    }
}
