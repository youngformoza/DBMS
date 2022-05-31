using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace LibraryAPI
{
    public static class ServiceRegistration
    {
        public static void AddMediator(this IServiceCollection services)
        {
            var assm = Assembly.GetExecutingAssembly();
            services.AddMediatR(assm);
        }
    }
}
