namespace BrookingsActivityCenter.Web.Repository
{
    public interface IUnitOfWork: IDisposable
    {
        ICustomerRepository CustomerRepository { get; }
        IReservationRepository ReservationRepository { get; }

        void Save();

        void Dispose();


    }
}
