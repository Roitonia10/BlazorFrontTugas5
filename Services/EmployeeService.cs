using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Json;
using Blazor358.Models; 

namespace Blazor358.Services
{
    public class EmployeeService : IEmployeeService
    {
        private HttpClient _httpClient;

        public EmployeeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        
        public async Task<Employee> GetEmployee(int id)
        {
             var result = await _httpClient.GetFromJsonAsync<Employee>($"api/Employees/{id}");
             return result;
        }
        public async Task<IEnumerable<Employee>> GetEmployee()
        {
            var results = await _httpClient.GetFromJsonAsync<IEnumerable<Employee>>("api/Employees");
            return results;
        }
        
    }
}