using PeerIslands.Assignment.Common.Helpers;
using PeerIslands.Assignment.Common.Models;
using PeerIslands.Assignment.Repository.Interfaces;
using PeerIslands.Assignment.Service.Interfaces;
using System;

namespace PeerIslands.Assignment.Service
{
    public class EmployeeService : IEmployeeService
    {
        private IEmployeeRepository _employeeRepository;
        private IXmlParser _xmlParser;

        public EmployeeService(IEmployeeRepository employeeRepository, IXmlParser xmlParser)
        {
            _employeeRepository = employeeRepository;
            _xmlParser = xmlParser;
        }

        public void AddEmployees<T>(string xml)
                where T : Employee
        {
            var employees = _xmlParser.Deserialize<Employees<T>>(xml);

            _employeeRepository.AddEmployees(employees);
        }

        public void DeleteEmployee(int id)
        {
            throw new NotImplementedException();
        }
    }
}
