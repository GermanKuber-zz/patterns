using Entities;
using Entities.Interfaces;
using Implementations.Collections;
using Implementations.Factories;
using Implementations.StatusAuction;
using Implementations.Strategies.Update.Auction;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Implementations.Tests
{
    public class AuctionsTest: CollectionBaseTests
    {
      
        private Auction _auction1;
        private Auction _auction2;
        private Auction _auction3;
        private List<Auction> _originalListOfAuctions;
        private Auctions _sut;

        public AuctionsTest()
        {
        
            _auction1 = new Auction(_auctionStatusFactory, _roundAuctionStatusFactory, AuctionStatusTypeEnum.Close);
            _auction2 = new Auction(_auctionStatusFactory, _roundAuctionStatusFactory, AuctionStatusTypeEnum.New);
            _auction3 = new Auction(_auctionStatusFactory, _roundAuctionStatusFactory, AuctionStatusTypeEnum.New);
            _originalListOfAuctions = new List<Auction> { _auction1, _auction2, _auction3 };
            _sut = new Auctions(_originalListOfAuctions);
        }



        [Theory]
        [InlineData(4, 1)]
        [InlineData(-1, 2)]
        public void Return_Only_Auction_Already_To_Open(int openingDateToAdd, int quantityToGet)
        {
            var openingDate = DateTime.Now.AddDays(openingDateToAdd);

            var updateDateOpeningStrategy = _auctionStrategyFactory.Make<UpdateOpeningParameter>(StrategyTypeEnum.UpdateOpeningDate);
            var parameters = new UpdateOpeningParameter(openingDate);

            _auction2.Update(updateDateOpeningStrategy, parameters);
            _sut = new Auctions(_originalListOfAuctions);


            Assert.Equal(quantityToGet, _sut.ReadyToOpen().Get().Count());

        }


        [Fact]
        public void Return_Only_Auction_WithOutProviders()
        {

            var providers = new Providers(new List<Provider> { new Provider(), new Provider() });

            var updateDateOpeningStrategy = _auctionStrategyFactory.Make<UpdateProviderParameter>(StrategyTypeEnum.UpdateProvider);

            var parameters = new UpdateProviderParameter(providers);

            _auction2.Update(updateDateOpeningStrategy, parameters);

            _sut = new Auctions(_originalListOfAuctions);


            Assert.Equal(2, _sut.WithOutProviders().Get().Count());

        }



    }
}
