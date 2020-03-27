using Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repo
{
    public interface IRepo
    {
        Employee GetEmployee(int id);
        Task<int> AddEmployee(Employee employee);
        Task<int> UpdateEmployee(Employee employeeChanges);
        Employee DeleteEmployee(int id);
        IEnumerable<Employee> GetAllEmployees();
    }
}
