using PeerIslands.Assignment.Common.Models;

namespace PeerIslands.Assignment.Service.Interfaces
{
    public interface IEmployeeService
    {
        void AddEmployees<T>(string xml)
            where T :  Employee;

        void DeleteEmployee(int id);
    }
}
