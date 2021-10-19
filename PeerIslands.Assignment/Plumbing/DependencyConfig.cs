using Microsoft.Extensions.DependencyInjection;
using PeerIslands.Assignment.Common.Helpers;
using PeerIslands.Assignment.Repository;
using PeerIslands.Assignment.Repository.Interfaces;
using PeerIslands.Assignment.Service;
using PeerIslands.Assignment.Service.Interfaces;

namespace PeerIslands.Assignment.Plumbing
{
    public static class DependencyConfig
    {
        public static ServiceProvider Register()
        {
            return  new ServiceCollection()
                .AddScoped<IEmployeeRepository, EmployeeRepository>()
                .AddScoped<IEmployeeService, EmployeeService>()
                .AddScoped<IXmlParser, XmlParser>()
                .BuildServiceProvider();
        }
    }
}