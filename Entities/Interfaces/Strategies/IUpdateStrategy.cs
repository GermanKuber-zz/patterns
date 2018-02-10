namespace Entities.Interfaces
{
    public interface IUpdateStrategy<TEntity, TParameters> : IStrategy<TEntity, TParameters> where TParameters : IParameters
    {

    }
}
