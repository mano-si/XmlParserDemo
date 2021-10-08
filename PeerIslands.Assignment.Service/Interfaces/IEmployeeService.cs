using PeerIslands.Assignment.Common.Models;

namespace PeerIslands.Assignment.Service.Interfaces
{
    public interface IEmployeeService
    {
        void AddEmployees<T>(string xml);
            //where T : BaseEmployees<Employee>;

        void DeleteEmployee(int id);
    }
}
