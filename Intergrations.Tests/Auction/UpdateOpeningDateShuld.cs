using Entities;
using Entities.Interfaces;
using Implementations.Factories;
using Implementations.Strategies.Update.Auction;
using System;
using Xunit;

namespace Intergrations.Tests
{
    public class UpdateOpeningDateShuld
    {
        protected AuctionFactory AuctionFactory = new AuctionFactory();

        protected AuctionStrategyFactory AuctionStrategyFactory = new AuctionStrategyFactory();
        protected AuctionsMilestonesDecoratorsFactory AuctionsMilestonesDecoratorsFactory = new AuctionsMilestonesDecoratorsFactory();

        protected Auction Sut;

        public UpdateOpeningDateShuld()
        {

            Sut = AuctionFactory.Make(AuctionTypeEnum.Complete);
        }


        [Fact]
        public void Update_Opening_Date_With_Decorator_Generate_One_Milestone()
        {

            var now = DateTime.Now;
            var updateOpeningParameter = new UpdateOpeningParameter(now);

            var upgradeOpeningDateStrategy = AuctionStrategyFactory.Make<UpdateOpeningParameter>(StrategyTypeEnum.UpdateOpeningDate);
            var decoratorMilestone = AuctionsMilestonesDecoratorsFactory.Make<UpdateOpeningParameter>(DecoratorsEnum.DecoratorAuctionMilestone);

            decoratorMilestone.SetStrategy(upgradeOpeningDateStrategy);
            Sut.Update<UpdateOpeningParameter>(decoratorMilestone, updateOpeningParameter);

            Assert.Single(Sut.Milestone.Get());
        }



    }
}
