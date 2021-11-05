using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazor358.Models;

namespace Blazor358.Services
{
    public interface IDepartmentService
    {
      
            Task<IEnumerable<Department>> GetAll();
         Task<Department> GetById(int id);
    }
}