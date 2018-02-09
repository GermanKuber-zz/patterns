namespace ConsoleApp3
{
    public interface IStrategy<TUpdating, IParameters>
    {
        void Execute(TUpdating updatingEntity, IParameters parameter);
    }
}
