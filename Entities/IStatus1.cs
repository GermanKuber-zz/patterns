namespace ConsoleApp3
{
    public interface IStatus<TStatus>
    {
        TStatus Status { get; set; }
    }
}
