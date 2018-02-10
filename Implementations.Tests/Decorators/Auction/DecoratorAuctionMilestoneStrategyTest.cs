using Entities;
using Entities.Interfaces;
using Implementations.Decorators.Strategies;
using Implementations.Factories;
using Implementations.RoundAuctionsStatus;
using Implementations.Strategies.Update.Auction;
using System;
using System.Linq;
using Xunit;

namespace Implementations.Tests
{
    public class DecoratorAuctionMilestoneStrategyTest
    {
        protected IAuctionStrategyFactory AuctionStrategyFactory { get; } = new AuctionStrategyFactory();
        private IAuctionsDecoratorsFactory _auctionsDecoratorsFactory;
        private IDecorator<Auction, UpdateOpeningParameter> _sut;
        private IUpdateStrategy<Auction, UpdateOpeningParameter> _updateOpeningDateStrategy;
        protected IAuctionFactory AuctionFactory { get; }
        protected Auction Auction { get; set; }

        public DecoratorAuctionMilestoneStrategyTest()
        {
            _auctionsDecoratorsFactory = new AuctionsDecoratorsFactory();
            AuctionFactory = new AuctionFactory();
            Auction = AuctionFactory.Make(AuctionTypeEnum.Complete);
            _sut = _auctionsDecoratorsFactory.Make<UpdateOpeningParameter>(DecoratorsEnum.DecoratorAuctionMilestone);
            _updateOpeningDateStrategy = AuctionStrategyFactory.Make<UpdateOpeningParameter>(StrategyTypeEnum.UpdateOpeningDate);
        }


        [Fact]
        public void Update_Opening_Date()
        {
            var newDate = new DateTime(1988, 8, 4);

            _sut.SetStrategy(_updateOpeningDateStrategy);

            _sut.Execute(Auction, new UpdateOpeningParameter(newDate));
        }
        [Fact]
        public void Update_Providers()
        {
            var newDate = new DateTime(1988, 8, 4);

            _sut.SetStrategy(_updateOpeningDateStrategy);

            _sut.Execute(Auction, new UpdateOpeningParameter(newDate));
        }
        //[Fact]
        //public void Should_Add_One_RoundAuction()
        //{
        //    var roundAuction = new RoundAuction(Auction);

        //    var parameter = new AddRoundAuctionParameter(roundAuction);
        //    Sut.Execute(Auction, parameter);

        //    Assert.Equal(1, Auction.RoundAuctionsStatus.Rounds.Count());
        //}


        //[Fact]
        //public void Shuuld_Be_RoundAuctionsStatusHastRounds_After_To_Add_First_RoundAuction()
        //{
        //    var roundAuction = new RoundAuction(Auction);

        //    var parameter = new AddRoundAuctionParameter(roundAuction);
        //    Sut.Execute(Auction, parameter);

        //    Assert.True(Auction.RoundAuctionsStatus is RoundAuctionsStatusHasRounds);

        //}


    }
}
