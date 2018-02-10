using Entities;
using Entities.Interfaces;

namespace Implementations.Factories
{
    public interface IAuctionsMilestonesDecoratorsFactory
    {
        IAuctionDecorator<TParameters> Make<TParameters>(DecoratorsEnum type) where TParameters : IParameters;
    }
}