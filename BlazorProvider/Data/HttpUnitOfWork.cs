namespace BlazorProvider.Data
{
    public class HttpUnitOfWork : UnitedOfWork
    {
        public HttpUnitOfWork(AppDbContext context) : base(context)
        {
        }
    }
}
