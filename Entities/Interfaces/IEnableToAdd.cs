namespace Entities.Interfaces
{
    public interface IEnableToAdd<TEntity>
    {
        void Add<TParameters>(IAddStrategy<TEntity, TParameters> updateStrategy, TParameters parameters) where TParameters : IParameters;
    }
}
