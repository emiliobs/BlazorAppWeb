using BlazorProvider.Data;
using BlazorProvider.Models;
using BlazorProvider.Provider;
using BlazorProvider.RepositoriesInterfaces;
using Microsoft.EntityFrameworkCore;

namespace BlazorProvider.Repositories
{
    public class UserRepositories : GenericRepository<User>, IUserRepositories
    {
        public UserRepositories(DbContext context) : base(context)
        {

        }

        private AppDbContext _appContext => (AppDbContext)_context;
    }
}
