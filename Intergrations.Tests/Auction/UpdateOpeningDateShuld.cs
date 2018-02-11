//using Entities;
//using Entities.Interfaces;
//using Implementations.ChainOfResponsibility.Decorator;
//using Implementations.Decorators.Strategies;
//using Implementations.Factories;
//using Implementations.Strategies.Update.Auction;
//using Moq;
//using System;
//using Xunit;

//namespace Intergrations.Tests
//{
//    public class UpdateOpeningDateShuld
//    {
//        protected AuctionFactory AuctionFactory;

//        protected AuctionStrategyFactory AuctionStrategyFactory;
//        private Mock<IDecoratorStepAuctionChainOfResponsibility<Auction, UpdateOpeningParameter>> _decoratorStepAuctionChainOfResponsibilityMock;
//        private IUpdateStrategy<Auction, UpdateOpeningParameter> _updateOpeningDateStrategy;
//        private AuctionsMilestoneDecoratorsChainOfResponsibilityFactory _auctionsMilestoneDecoratorsChainOfResponsibilityFactory;
//        private Mock<IUpdateStrategy<Auction, UpdateOpeningParameter>> _updateOpeningDateStrategyMock;
//        protected Auction Sut;

//        public UpdateOpeningDateShuld()
//        {
//            AuctionFactory = new AuctionFactory();
//            AuctionStrategyFactory = new AuctionStrategyFactory();
//            _updateOpeningDateStrategy = AuctionStrategyFactory.Make<UpdateOpeningParameter>(StrategyTypeEnum.UpdateOpeningDate);
//            _auctionsMilestoneDecoratorsChainOfResponsibilityFactory = new AuctionsMilestoneDecoratorsChainOfResponsibilityFactory();
//            SetupMocks();

//            Sut = AuctionFactory.Make(AuctionTypeEnum.Complete);
//        }


//        [Fact]
//        public void Update_Opening_Date_WithOut_Decorator()
//        {
//            var now = DateTime.Now;
//            var updateOpeningParameter = new UpdateOpeningParameter(now);

//            Sut.Update<UpdateOpeningParameter>(_updateOpeningDateStrategy, updateOpeningParameter);

//            Assert.Equal(now, Sut.OpeningDate);
//        }

//        //[Fact]
//        //public void Update_Opening_Date_With_Decorator_Milestone_With_One_Step()
//        //{
//        //    var now = DateTime.Now;
//        //    var auctionsDecoratorsFactory = new AuctionsMilestonesDecoratorsFactory();

//        //    IAuctionDecorator<UpdateOpeningParameter> decoratorAuctionMilestone = GenerateAuctionMilestoneDecoratorWithMock(auctionsDecoratorsFactory);

//        //    var openeningDateStep = _auctionsMilestoneDecoratorsChainOfResponsibilityFactory.Make< UpdateOpeningParameter>(AuctionsChainOfResponsibilityEnum.MilestoneOpeningDateStepAction);
//        //    var providersParameterStep = _auctionsMilestoneDecoratorsChainOfResponsibilityFactory.Make<AuctionMilestoneProvidersParameter>(AuctionsChainOfResponsibilityEnum.MilestoneProvidersStepAction);


//        //    openeningDateStep.SetSuccessor(providersParameterStep);
//        //    var updateOpeningParameter = new UpdateOpeningParameter(now);
//        //    Sut.Update<UpdateOpeningParameter>(decoratorAuctionMilestone, updateOpeningParameter);

//        //    Assert.Equal(now, Sut.OpeningDate);

//        //}

//        //private IAuctionDecorator<UpdateOpeningParameter> GenerateAuctionMilestoneDecoratorWithMock(AuctionsMilestonesDecoratorsFactory auctionsDecoratorsFactory)
//        //{
//        //    var decoratorAuctionMilestone = auctionsDecoratorsFactory.Make<UpdateOpeningParameter>(DecoratorsEnum.DecoratorAuctionMilestone);

//        //    decoratorAuctionMilestone.SetStrategy(_updateOpeningDateStrategy);

//        //    _decoratorStepAuctionChainOfResponsibilityMock.Setup(x => x.Process(It.IsAny<Auction>(), It.IsAny<UpdateOpeningParameter>()));

//        //    decoratorAuctionMilestone.SetStepsToProcess();
//        //    return decoratorAuctionMilestone;
//        //}
//        private void SetupMocks()
//        {
//            //_decoratorStepAuctionChainOfResponsibilityMock = new Mock<IDecoratorStepAuctionChainOfResponsibility<Auction, UpdateOpeningParameter>>();
//            _updateOpeningDateStrategyMock = new Mock<IUpdateStrategy<Auction, UpdateOpeningParameter>>();
//            _updateOpeningDateStrategyMock.Setup(x => x.Execute(It.IsAny<Auction>(), It.IsAny<UpdateOpeningParameter>()));
//            _updateOpeningDateStrategyMock.SetupAllProperties();
//        }

//    }
//}
