using NSubstitute;
using NUnit.Framework;
using PeerIslands.Assignment.Common.Helpers;
using PeerIslands.Assignment.Common.Models;
using PeerIslands.Assignment.Repository.Interfaces;
using PeerIslands.Assignment.Service;
using System;
using System.Collections.Generic;

namespace PeerIslands.Assignment.Tests
{
    public class EmployeeServiceTests
    {
        private IEmployeeRepository _employeeRepository;
        private IXmlParser _xmlParser;

        private EmployeeService _employeeService;

        private string _validXmlInput = @"<employees>
                                    <employee>
                                    <name>Mark</name> 
                                    <age>25</age> 
                                    <designation>Developer</designation> 
                                    </employee> 
                                    </employees> ";
        private Employees<Employee> _validEmployees;

        [SetUp]
        public void Setup()
        {
            _employeeRepository = Substitute.For<IEmployeeRepository>();
            _xmlParser = Substitute.For<IXmlParser>();

            _employeeService = new EmployeeService(_employeeRepository, _xmlParser);
            SetUpMocks();
        }

        [Test]
        public void AddEmployees_WhenInValidXml_ShouldReturn()
        {
            Assert.Throws<InvalidOperationException>(() => _employeeService.AddEmployees<Employee>("xyz"));
        }

        [Test]
        public void AddEmployees_WhenValidXml_ShouldCallRepo()
        {
            _employeeService.AddEmployees<Employee>(_validXmlInput);

            _employeeRepository.Received().AddEmployees(_validEmployees);
        }

        private void SetUpMocks()
        {
            _validEmployees = new Employees<Employee>() { ListOfEmployees = new List<Employee>() { new Employee() { Name = "Mark", Age = 23, Designation = "Engineer" } } };
            _xmlParser
                .When(x => x.Deserialize<Employees<Employee>>(Arg.Is<string>(x => x != _validXmlInput)))
                .Do(x => { throw new InvalidOperationException(); });

            _xmlParser.Deserialize<Employees<Employee>>(_validXmlInput).Returns(_validEmployees);

        }
    }
}