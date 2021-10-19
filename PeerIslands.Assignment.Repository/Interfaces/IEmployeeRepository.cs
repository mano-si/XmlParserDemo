using PeerIslands.Assignment.Common.Models;

namespace PeerIslands.Assignment.Repository.Interfaces
{
    public interface IEmployeeRepository
    {
        void AddEmployees<T>(Employees<T> employees)
            where T : Employee;

        void DeleteEmployee(int id);
    }
}
