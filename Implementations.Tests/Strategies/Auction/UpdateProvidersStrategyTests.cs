using Entities;
using Entities.Interfaces;
using Implementations.Collections;
using Implementations.Factories;
using Implementations.RoundAuctionsStatus;
using Implementations.StatusAuction;
using Implementations.Strategies.Update.Auction;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Implementations.Tests
{
    public class UpdateProvidersStrategyTests : AuctionStrategyTestsBase<UpdateProviderParameter>
    {
        private Provider _provider1 = new Provider { Status = ProviderStatusEnum.Invited };
        private Provider _provider2 = new Provider { Status = ProviderStatusEnum.Active };
        private Provider _provider3 = new Provider { Status = ProviderStatusEnum.Invited };
        private AuctionStatusFactory _auctionStatusFactory = new AuctionStatusFactory();
        private RoundAuctionStatusFactory _roundAuctionStatusFactory = new RoundAuctionStatusFactory();
        private List<Provider> _originalListOfProviders;
        private Mock<IAuctionStatusFactory> _auctionStatusFactoryMock;
        private Mock<Entities.RoundAuctionsStatus> _roundAuctionsStatusMock;
        private Mock<StatusAuction<Auction>> _statusAuctionMock;
        private Mock<IRoundAuctionStatusFactory> _roundAuctionStatusFactoryMock;
        public UpdateProvidersStrategyTests()
        {
            _originalListOfProviders = new List<Provider> { _provider1, _provider2, _provider3 };
            _auctionStatusFactoryMock = new Mock<IAuctionStatusFactory>();
            _statusAuctionMock = new Mock<StatusAuction<Auction>>(Auction);
            _roundAuctionStatusFactoryMock = new Mock<IRoundAuctionStatusFactory>();
            _roundAuctionsStatusMock = new Mock<Entities.RoundAuctionsStatus>(Auction);
            Sut = AuctionStrategyFactory.Make<UpdateProviderParameter>(StrategyTypeEnum.UpdateProvider);
            Auction = new Auction(_auctionStatusFactory, _roundAuctionStatusFactory, AuctionStatusTypeEnum.New);
        }


        [Fact]
        public void Should_Execute_Current_RoundAuctionsStatusHasNotRounds_UpdateProviders()
        {
            SetupMockToCheckIfCallUpdateProviderWithStatus(RoundAuctionStatusTypeEnum.HasNotRound);

            var parameter = new UpdateProviderParameter(new Providers(_originalListOfProviders));
            Auction = new Auction(_auctionStatusFactory, _roundAuctionStatusFactoryMock.Object, AuctionStatusTypeEnum.New);

            Sut.Execute(Auction, parameter);

            _roundAuctionsStatusMock.Verify();

        }
        [Fact]
        public void Should_Execute_Current_RoundAuctionsStatusHasRounds_UpdateProviders()
        {
            SetupMockToCheckIfCallUpdateProviderWithStatus(RoundAuctionStatusTypeEnum.HasRound);
            SetupMockToCheckIfCallUpdateProviderWithStatus(RoundAuctionStatusTypeEnum.HasNotRound);

            var parameter = new UpdateProviderParameter(new Providers(_originalListOfProviders));
            Auction = new Auction(_auctionStatusFactory, _roundAuctionStatusFactoryMock.Object, AuctionStatusTypeEnum.New);

            Sut.Execute(Auction, parameter);

            _roundAuctionsStatusMock.Verify();
        }

        [Fact]
        public void Should_Execute_Current_StatusAuction_UpdateProviders()
        {
            _statusAuctionMock.Setup(x => x.UpdateProviders(It.IsAny<Providers>()));
            _auctionStatusFactoryMock.Setup(x => x.Make(It.IsAny<AuctionStatusTypeEnum>(), It.IsAny<Auction>())).Returns(_statusAuctionMock.Object);

            Auction = new Auction(_auctionStatusFactoryMock.Object, _roundAuctionStatusFactory, AuctionStatusTypeEnum.New);

            var parameter = new UpdateProviderParameter(new Providers(_originalListOfProviders));
            Sut.Execute(Auction, parameter);

            _roundAuctionsStatusMock.Verify();
        }

        [Fact]
        public void Should_Execute_Current_StatusAuction_UpdateProviders_And_Set_Value_Of_Auction_Status()
        {
            var newReturnValue = new StatusAuctionDraft(Auction);

            _statusAuctionMock.Setup(x => x.UpdateProviders(It.IsAny<Providers>())).Returns(newReturnValue);

            _auctionStatusFactoryMock.Setup(x => x.Make(AuctionStatusTypeEnum.New, It.IsAny<Auction>())).Returns(_statusAuctionMock.Object);
            Auction = new Auction(_auctionStatusFactoryMock.Object, _roundAuctionStatusFactory, AuctionStatusTypeEnum.New);

            var parameter = new UpdateProviderParameter(new Providers(_originalListOfProviders));
            Sut.Execute(Auction, parameter);

            Assert.Equal(newReturnValue, Auction.Status);
        }

        private void SetupMockToCheckIfCallUpdateProviderWithStatus(RoundAuctionStatusTypeEnum status)
        {
            var providers = new Providers(_originalListOfProviders);
            _roundAuctionsStatusMock.Setup(x => x.UpdateProviders(providers));

            _roundAuctionStatusFactoryMock.Setup(x => x.Make(status, It.IsAny<Auction>(), It.IsAny<RoundAuction>())).Returns(_roundAuctionsStatusMock.Object);
        }
    }
}
