using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazor358.Models;

namespace Blazor358.Services
{
    public interface IEmployeeService
    {
           Task<IEnumerable<Employee>> GetEmployee();
         Task<Employee> GetEmployee(int id);
    }
}