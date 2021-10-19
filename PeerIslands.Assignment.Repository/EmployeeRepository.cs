using PeerIslands.Assignment.Common.Helpers;
using PeerIslands.Assignment.Common.Models;
using PeerIslands.Assignment.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;

namespace PeerIslands.Assignment.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private const string OUTPUT_PATH = @"..\..\..\..\output.xml";

        private IXmlParser _xmlParser;

        public EmployeeRepository(IXmlParser xmlParser)
        {
            _xmlParser = xmlParser;
        }

        public void AddEmployees<T>(Employees<T> employees) 
            where T : Employee
        {
            try
            {
                string xml = _xmlParser.Serialize<Employees<T>>(employees);
                File.WriteAllText(OUTPUT_PATH, xml);

            }
            catch (Exception ex)
            {
                // log and handle
                throw;
            }
        }

        public void DeleteEmployee(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
