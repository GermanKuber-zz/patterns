namespace Entities.Interfaces
{
    public interface IDecorator<TUpdating, TParameters> where TParameters : IParameters
    {
        void Execute(TUpdating updatingEntity, TParameters parameter);
        void SetStrategy(IStrategy<TUpdating, TParameters> strategyToDecorate);
    }
}