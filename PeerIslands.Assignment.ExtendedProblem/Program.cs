using Microsoft.Extensions.DependencyInjection;
using PeerIslands.Assignment.Common.Models;
using PeerIslands.Assignment.ExtendedProblem.Models;
using PeerIslands.Assignment.ExtendedProblem.Plumbing;
using PeerIslands.Assignment.Service;
using PeerIslands.Assignment.Service.Interfaces;
using System;
using System.IO;

namespace PeerIslands.Assignment.ExtendedProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputXmlExtended = File.ReadAllText(@"..\..\..\..\inputExtended.xml");

            ServiceProvider _serviceProvider = DependencyConfig.Register();

            var employeeService = _serviceProvider.GetService<IEmployeeService>();

            employeeService.AddEmployees<ExtentedEmployee>(inputXmlExtended);
        }
    }
}
