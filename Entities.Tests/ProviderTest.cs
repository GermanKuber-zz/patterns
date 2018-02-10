using Xunit;

namespace Entities.Tests
{
    public class ProviderTest
    {
        private Provider _sut;

        public ProviderTest()
        {
            _sut = new Provider { Id = 1, Name = "Test" };
        }
        [Fact]
        public void CompareTo_ShouldBe_Equals_Compare_Id()
        {
            var providerToCompare = new Provider { Id = 1 };
            Assert.Equal(0, _sut.CompareTo(providerToCompare));
        }
    }
}
