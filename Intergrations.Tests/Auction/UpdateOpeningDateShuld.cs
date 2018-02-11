using Entities;
using Entities.Interfaces;
using Implementations.Collections;
using Implementations.Factories;
using Implementations.Strategies.Update.Auction;
using System;
using System.Collections.Generic;
using System.Linq;
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
            var decoratorMilestone = AuctionsMilestonesDecoratorsFactory.Make<UpdateOpeningParameter>(DecoratorsEnum.AuctionMilestoneUpdateOpeningDate);

            decoratorMilestone.SetStrategy(upgradeOpeningDateStrategy);
            Sut.Update<UpdateOpeningParameter>(decoratorMilestone, updateOpeningParameter);

            Assert.Single(Sut.Milestone.Get());
        }

        [Fact]
        public void Update_Opening_Date_And_Providers_With_Decorator_Generate_Two_Milestone()
        {

            var now = DateTime.Now;
            var updateOpeningParameter = new UpdateOpeningParameter(now);

            var upgradeOpeningDateStrategy = AuctionStrategyFactory.Make<UpdateOpeningParameter>(StrategyTypeEnum.UpdateOpeningDate);
            var decoratorMilestone = AuctionsMilestonesDecoratorsFactory.Make<UpdateOpeningParameter>(DecoratorsEnum.AuctionMilestoneUpdateOpeningDate);

            decoratorMilestone.SetStrategy(upgradeOpeningDateStrategy);
            Sut.Update<UpdateOpeningParameter>(decoratorMilestone, updateOpeningParameter);

            var upgradeProvidersStrategy = AuctionStrategyFactory.Make<UpdateProviderParameter>(StrategyTypeEnum.UpdateProvider);
            var decoratorMilestoneProvider = AuctionsMilestonesDecoratorsFactory.Make<UpdateProviderParameter>(DecoratorsEnum.AuctionMilestoneUpdateProviders);

            decoratorMilestoneProvider.SetStrategy(upgradeProvidersStrategy);
            var ipdateProvidersProperties = new UpdateProviderParameter(new Providers(new List<Provider> { new Provider { Id = 1, Status = ProviderStatusEnum.Active } }));

            Sut.Update<UpdateProviderParameter>(decoratorMilestoneProvider, ipdateProvidersProperties);

            Assert.Equal(2, Sut.Milestone.Get().Count());
        }

    }
}
