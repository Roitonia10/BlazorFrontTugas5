using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Json;
using Blazor358.Models; 

namespace Blazor358.Services
{
    public class DepartmentService   : IDepartmentService
    {
          private HttpClient _httpClient;

        public DepartmentService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<Department>> GetAll()
        {
            var results = await _httpClient.GetFromJsonAsync<IEnumerable<Department>>("api/Departments");
            return results;
        }
           public async Task<Department> GetById(int id)
        {
        
             var result = await _httpClient.GetFromJsonAsync<Department>($"api/Departments/{id}");
             return result;
        }
    }
}