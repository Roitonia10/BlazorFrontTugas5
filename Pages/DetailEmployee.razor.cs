using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazor358.Models;
using Blazor358.Services;
using Microsoft.AspNetCore.Components;

namespace Blazor358.Pages
{
    public partial class DetailEmployee
    {
         [Parameter]
        public string id { get; set; }
         [Inject]
        public IEmployeeService EmployeeService { get; set; }
        public Employee Employee { get; set; } = new Employee();
       
        protected override async Task OnInitializedAsync()
        {
            id = id ?? "1";
            Employee = await EmployeeService.GetEmployee(int.Parse(id));
        }
    }
}