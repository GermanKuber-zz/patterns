using Entities;
using Entities.Interfaces;

namespace Implementations.Factories
{
    public interface IAuctionsDecoratorsFactory
    {
        IAuctionDecorator<TParameters> Make<TParameters>(DecoratorsEnum type) where TParameters: IParameters;
    }
}