namespace Entities.Interfaces
{
    public interface IStrategy<TUpdating, TParameters> where TParameters : IParameters
    {
        void Execute(TUpdating updatingEntity, TParameters parameter);
    }
}
