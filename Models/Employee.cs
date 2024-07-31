namespace EmployeeManagementApi.Models
{
    public class Employees
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Department { get; set; }
        public string? Position { get; set; }
        public decimal Salary { get; set; }
    }
}
