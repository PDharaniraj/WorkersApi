using EmployeeManagementApi.Models;

namespace EmployeeManagementApi.Repositories
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employees>> GetEmployees();
        Task<Employees> GetEmployee(int id);
        Task<Employees> AddEmployee(Employees employee);
        Task<Employees> UpdateEmployee(Employees employee);
        Task DeleteEmployee(int id);
    }
}