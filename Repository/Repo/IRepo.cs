using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repo
{
    public interface IRepo
    {
        
        Employee AddEmployee(Employee employee);
        Employee DeleteEmployee(int id);
        IEnumerable<Employee> GetAllEmployee();
        Employee UpdateEmployee(Employee employee);
    }
}
