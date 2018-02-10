using Entities;
using Implementations.Collections;
using Implementations.StatusAuction;
using Implementations.Strategies.Update.Auction;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Implementations.Tests
{
    public class ProvidersTest : CollectionBaseTests
    {

        private Provider _provider1 = new Provider { Status = ProviderStatusEnum.Invited, Id = 1 };
        private Provider _provider2 = new Provider { Status = ProviderStatusEnum.Active, Id = 2 };
        private Provider _provider3 = new Provider { Status = ProviderStatusEnum.Invited, Id = 3 };
        private List<Provider> _originalListOfProviders;
        private Providers _sut;

        public ProvidersTest()
        {
            _originalListOfProviders = new List<Provider> { _provider1, _provider2, _provider3 };
            _sut = new Providers(_originalListOfProviders);

        }



        [Fact]
        public void Return_Only_Auction_Already_To_Open()
        {
            Assert.Equal(2, _sut.Invited().Get().Count());
        }

        [Fact]
        public void Compare_Providers_List_With_The_Same_List()
        {
            var providersToCompare = new Providers(_originalListOfProviders);
            Assert.Equal(0, _sut.CompareTo(providersToCompare));
        }

        [Fact]
        public void Compare_Providers_List_With_The_Same_List_Minus_One()
        {
            var providersToCompare = new Providers(new List<Provider> { _provider1, _provider2 });
            Assert.Equal(1, _sut.CompareTo(providersToCompare));
        }
        [Fact]
        public void Compare_Providers_Send_Null()
        {
            Assert.Equal(1, _sut.CompareTo(null));
        }

    }
}
