﻿using Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repo
{
    public interface IRepo
    {
        Task<int> AddEmployee(Employee employee);
        Employee GetEmployee(int id);
        Task<int> UpdateEmployee(Employee employeeChanges);
        Employee DeleteEmployee(int id);
        IEnumerable<Employee> GetAllEmployees();
    }
}
