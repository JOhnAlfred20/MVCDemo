using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.DataAccess.Models.EmployeeModels;

namespace Demo.DataAccess.Repositories.Interface
{
    public interface IEmployeeRepository : IGenericRepository<Employee>
    {

    }
}