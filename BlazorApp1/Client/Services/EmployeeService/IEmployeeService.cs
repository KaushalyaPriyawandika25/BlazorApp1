namespace BlazorApp1.Client.Services.EmployeeService
{
    public interface IEmployeeService
    {
        List<Employee> Employees { get; set; }
        List<Manager> Managers { get; set; }
        Task GetManager();
        Task GetEmployees();
        Task<Employee> GetEmployees(int id);

    }
}
