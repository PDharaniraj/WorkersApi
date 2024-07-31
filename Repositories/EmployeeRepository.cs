using EmployeeManagementApi.Data;
using EmployeeManagementApi.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementApi.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeContext _context;

        public EmployeeRepository(EmployeeContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Employees>> GetEmployees()
        {
            return await _context.Employee.ToListAsync();
        }

        public async Task<Employees> GetEmployee(int id)
        {
            return await _context.Employee.FindAsync(id);
        }

        public async Task<Employees> AddEmployee(Employees employee)
        {
            _context.Employee.Add(employee);
            await _context.SaveChangesAsync();
            return employee;
        }

        public async Task<Employees> UpdateEmployee(Employees employee)
        {
            _context.Entry(employee).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return employee;
        }

        public async Task DeleteEmployee(int id)
        {
            var employee = await _context.Employee.FindAsync(id);
            _context.Employee.Remove(employee);
            await _context.SaveChangesAsync();
        }
    }
}

