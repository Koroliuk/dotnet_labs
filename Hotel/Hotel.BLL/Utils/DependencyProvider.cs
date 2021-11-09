using Hotel.BLL.interfaces;
using Hotel.BLL.Services;
using Hotel.DAL.Interfaces;
using Hotel.DAL.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Hotel.BLL.Utils
{
    public static class DependencyProvider
    {
        private static ServiceProvider _provider;

        public static void Init()
        {
            var container = new ServiceCollection();
            container.AddSingleton<IUnitOfWork, EFUnitOfWork>();
            container.AddSingleton<IUserService, UserService>();

            _provider = container.BuildServiceProvider();
        }
        
        public static T GetDependency<T>()
        {
            return _provider.GetService<T>();
        }
    }
}