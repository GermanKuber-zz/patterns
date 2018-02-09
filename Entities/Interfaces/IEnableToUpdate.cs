namespace Entities.Interfaces
{
    public interface IEnableToUpdate<TEntity>
    {
        void Update<TParameters>(IUpdateStrategy<TEntity, TParameters> updateStrategy, TParameters parameters) where TParameters : IParameters;
    }
}
