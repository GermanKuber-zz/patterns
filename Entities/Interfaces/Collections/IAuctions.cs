namespace Entities.Interfaces.Collections
{
    public interface IAuctions
    {
        IAuctions ReadyToOpen();
        IAuctions WithOutProviders();
    }
}