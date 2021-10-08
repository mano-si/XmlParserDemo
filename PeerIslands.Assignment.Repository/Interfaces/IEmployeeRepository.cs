using PeerIslands.Assignment.Common.Models;

namespace PeerIslands.Assignment.Repository.Interfaces
{
    public interface IEmployeeRepository
    {
        void AddEmployees<T>(T employees); 
            //where T : BaseEmployees<Employee>;

        void DeleteEmployee(int id);
    }
}
