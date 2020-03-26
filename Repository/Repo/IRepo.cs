using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repo
{
    public interface IRepo
    {
        
        bool AddEmployee(Employee employee);
        bool DeleteEmployee(int id);
        List<Employee> GetAllEmployee();
        bool UpdateEmployee(Employee employee);
    }
}
