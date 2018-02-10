using Entities;
using Entities.Interfaces;
using Implementations.ChainOfResponsibility.Decorator;
using Implementations.Decorators.Strategies;
using Implementations.Factories;
using Implementations.Strategies.Update.Auction;
using System;
using Xunit;

namespace Intergrations.Tests
{
    public class UpdateOpeningDateShuld
    {
        protected AuctionFactory AuctionFactory;

        protected AuctionStrategyFactory AuctionStrategyFactory;
        private IUpdateStrategy<Auction, UpdateOpeningParameter> _updateOpeningDateStrategy;
        protected Auction Sut;

        public UpdateOpeningDateShuld()
        {
            AuctionFactory = new AuctionFactory();
            AuctionStrategyFactory = new AuctionStrategyFactory();
            _updateOpeningDateStrategy = AuctionStrategyFactory.Make<UpdateOpeningParameter>(StrategyTypeEnum.UpdateOpeningDate);
            Sut = AuctionFactory.Make(AuctionTypeEnum.Complete);
        }


        [Fact]
        public void Update_Opening_Date()
        {
            var now = DateTime.Now;
            var auctionsDecoratorsFactory = new AuctionsMilestonesDecoratorsFactory();

          var decoratorAuctionMilestone = auctionsDecoratorsFactory.Make<UpdateOpeningParameter>(DecoratorsEnum.DecoratorAuctionMilestone);

            var updateOpeningParameter = new UpdateOpeningParameter(now);
            decoratorAuctionMilestone.SetStrategy(_updateOpeningDateStrategy);

            var auctionsDecoratorsChainOfResponsibilityFactory = new AuctionsMilestoneDecoratorsChainOfResponsibilityFactory();

           var openingDateStep = auctionsDecoratorsChainOfResponsibilityFactory.Make<Auction, UpdateOpeningParameter>(AuctionsChainOfResponsibilityEnum.MilestoneOpeningDateStepAction);
            var providerStep = auctionsDecoratorsChainOfResponsibilityFactory.Make<Auction, UpdateOpeningParameter>(AuctionsChainOfResponsibilityEnum.MilestoneProvidersStepAction);
            openingDateStep.SetSuccessor(providerStep);

            decoratorAuctionMilestone.SetStepsToProcess(openingDateStep);

            Sut.Update<UpdateOpeningParameter>(decoratorAuctionMilestone, updateOpeningParameter);

        }
    }
}
