using BlazorProvider.Repositories;
using BlazorProvider.RepositoriesInterfaces;

namespace BlazorProvider.Data
{
    public class UnitedOfWork : IUnitedOfWork
    {
        private readonly AppDbContext _context;
        IUserRepositories _iUserRepositories;

        public UnitedOfWork(AppDbContext context)
        {
            _context = context;
        }



        public IUserRepositories User
        {
            get
            {
                if (_iUserRepositories == null)
                {
                    _iUserRepositories = new UserRepositories(_context);
                }

                return _iUserRepositories;
            }
        }
    }
}
