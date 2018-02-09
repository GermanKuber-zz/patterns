namespace Entities.Interfaces
{
    public interface IUpdateStrategyFactory<TUpdating>
    {
        IUpdateStrategy<TUpdating, TParam> Make<TParam>(StrategyTypeEnum type) where TParam : IParameters;
    }
}
