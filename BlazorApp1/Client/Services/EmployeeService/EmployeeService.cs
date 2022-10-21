using System.Net.Http.Json;

namespace BlazorApp1.Client.Services.EmployeeService
{
    public class EmployeeService : IEmployeeService
    {
        private readonly HttpClient _http;

        public EmployeeService(HttpClient http)
        {
            _http = http;
        }
        public List<Employee> Employees { get; set; } = new List<Employee>();
        public List<Manager> Managers { get; set; } = new List<Manager>();

        public Task GetEmployees()
        {
            throw new NotImplementedException();
        }

        public Task<Employee> GetEmployees(int id)
        {
            throw new NotImplementedException();
        }

        public async Task GetEmployee()
        {
            var result = await _http.GetFromJsonAsync<List<Employee>>("api/employees");
            if (result != null)
                Employees = result;
        }

        public Task GetManager()
        {
            throw new NotImplementedException();
        }
    }
}
