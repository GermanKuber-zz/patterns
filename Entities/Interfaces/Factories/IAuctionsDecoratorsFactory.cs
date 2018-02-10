using Entities;
using Entities.Interfaces;

namespace Implementations.Factories
{
    public interface IAuctionsDecoratorsFactory
    {
        IDecorator<Auction, TParameters> Make<TParameters>(DecoratorsEnum type) where TParameters: IParameters;
    }
}