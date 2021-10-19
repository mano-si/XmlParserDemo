using Microsoft.Extensions.DependencyInjection;
using PeerIslands.Assignment.Plumbing;
using PeerIslands.Assignment.Repository;
using PeerIslands.Assignment.Repository.Interfaces;
using PeerIslands.Assignment;
using System.IO;
using PeerIslands.Assignment.Service.Interfaces;
using PeerIslands.Assignment.Common.Models;

namespace PeerIslands.Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputXml = File.ReadAllText(@"..\..\..\..\input.xml");

            ServiceProvider _serviceProvider = DependencyConfig.Register();

            var employeeService = _serviceProvider.GetService<IEmployeeService>();
            employeeService.AddEmployees<Employee>(inputXml);
        }
    }
}
