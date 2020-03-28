//-----------------------------------------------------------------------
// <copyright file="IEmployeeManager.cs" company="BridgeLabz">
//     Copyright © 2020
// </copyright>
// <creator name="Amit Singh"/>
//-----------------------------------------------------------------------

namespace Manager
{
    using Model;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    public interface IEmployeeManager
    {
        Task<int> AddEmployee(Employee employee);
        Employee GetEmployee(int id);
        Task<int> UpdateEmployee(Employee employeeChanges);
        Employee DeleteEmployee(int id);
        IEnumerable<Employee> GetAllEmployees();
    }
}
