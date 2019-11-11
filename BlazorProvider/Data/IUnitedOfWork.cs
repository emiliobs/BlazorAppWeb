using BlazorProvider.RepositoriesInterfaces;

namespace BlazorProvider.Data
{
    public interface IUnitedOfWork
    {
        IUserRepositories User { get; }
    }
}
