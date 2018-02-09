namespace ConsoleApp3
{
    public interface IStatus {
         StatusAuction Status { get;  set; }
        void ChangeStatus(StatusAuction newStatus);

    }
}
