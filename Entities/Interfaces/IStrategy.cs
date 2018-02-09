namespace Entities.Interfaces
{
    public interface IStrategy<TUpdating, IParameters>
    {
        void Execute(TUpdating updatingEntity, IParameters parameter);
    }
}
