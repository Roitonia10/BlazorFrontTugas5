using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazor358.Models;
using Blazor358.Services;
using Microsoft.AspNetCore.Components;

namespace Blazor358.Pages
{
    public partial class EmployeePage
    {
         public IEnumerable<Employee> Employees { get; set; } 
        
        [Inject]
        public IEmployeeService EmployeeService { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Employees = (await EmployeeService.GetEmployee()).ToList();
        }
    }
}